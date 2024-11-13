using ExteanstionExceaption;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace QueueSystem
{
    public partial class Form1 : Form
    {
        double mhoMMS = -1;
        double lambdaMMS = -1;
        double rhoMMS = -1;
        double p0MMS = -1;
        private double rho = -1;

        public Form1()
        {
            InitializeComponent();
            SetDefulatPropForMM1();
            SetDefulatPropForMMS();

        }

        private void SetDefulatPropForMMS()
        {
            txtMMSP0.ReadOnly = true;
        }

        private void SetDefulatPropForMM1()
        {
            txtLs.ReadOnly = true;
            txtLq.ReadOnly = true;
            txtWs.ReadOnly = true;
            txtWq.ReadOnly = true;
            txtRho.ReadOnly = true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double lambda = double.Parse(txtLambda.Text);
                double mu = double.Parse(txtMho.Text);
                if (mu == 0)
                {

                    throw new DivideByZeroException("لا يمكن ان تكون ميو صفر");
                }
                if (mu <= lambda)
                {
                    throw new SystemUnstableException("لا يمكن ان تكون متساوية القيم");
                }
                rho = lambda / mu;
                txtRho.Text = rho.ToString("F2");


            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                    MessageBox.Show("تأكد من إدخال قيم صحيحة للمدخلات.");
                else if (ex is DivideByZeroException)
                {
                    txtMho.BackColor = Color.Red;
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void CalcPerformance_Click(object sender, EventArgs e)
        {
            try
            {
                double lambda = double.Parse(txtLambda.Text);
                double mu = double.Parse(txtMho.Text);

                if (lambda >= mu)
                {
                    MessageBox.Show("النظام غير مستقر. تأكد من أن معدل الوصول أقل من معدل الخدمة.");
                    HighlightTextBox(txtLs, Color.Red);
                    return;
                }

                double rho = lambda / mu;

                double L = rho / (1 - rho);
                double Lq = Math.Pow(rho, 2) / (1 - rho);
                double W = 1 / (mu - lambda);
                double Wq = rho / (mu - lambda);

                txtLs.Text = L.ToString("F2");//F2 to show only two number after point 
                txtLq.Text = Lq.ToString("F2");
                txtWs.Text = W.ToString("F2");
                txtWq.Text = Wq.ToString("F2");

            }
            catch (FormatException)
            {
                MessageBox.Show("تأكد من إدخال قيم صحيحة للمدخلات.");
            }
        }

        private Color GetColorBasedOnValue(double value, double threshold)
        {
            if (value < threshold)
            {
                return Color.LightGreen;
            }
            else if (value < threshold * 2)
            {
                return Color.Orange;
            }
            else
            {
                return Color.Red;
            }
        }

        private void HighlightTextBox(TextBox textBox, Color color)
        {
            textBox.BackColor = color;
        }

        private void CalcP0_Click(object sender, EventArgs e)
        {
            if (rho == -1)
            {
                throw new Exception("the rho is Negtive");
            }
            txtP0.Text = (1 - rho).ToString();
        }

        private void calcMMSP0_Click(object sender, EventArgs e)
        {
            lblMMSReultP0.Text =string.Empty;
            mhoMMS = Convert.ToDouble(txtMMSmho.Text);
            lambdaMMS = Convert.ToDouble(txtMMSLambda.Text);
            //عدد المخدمات
            int servicesCount = Convert.ToInt32(txtMMSServicesCount.Text);
            double rateOfServices = mhoMMS * servicesCount;
            rhoMMS = lambdaMMS / rateOfServices;
            p0MMS = CalcP0(servicesCount, rhoMMS);
            p0MMS = p0MMS * 100;
            lblMMSReultP0.Text = ("P0 = " + p0MMS + "%");
             
            txtMMSP0.Text = ("P0 = " + p0MMS + "%");
        }

        private double CalcP0(int servicesCount, double rhoMMS)
        {
            double firstSecation = 0;
            for (int x = 0; x <= servicesCount - 1; x++)
            {
                firstSecation = firstSecation
                        + (Math.Pow(servicesCount * rhoMMS, x) / Fact(x));
            }
            double secoundSecation = (Math.Pow(servicesCount * rhoMMS, servicesCount)
                            / (Fact(servicesCount) * (1 - rhoMMS)));
            double result= firstSecation+secoundSecation;

            return 1/ result;
        }
        private static long Fact(int number)
        {
            long factResult = 1;
            for (int i = number; i > 1; i--)
            {
                factResult = factResult * i;
            }
            return factResult;
        }
    }
}
