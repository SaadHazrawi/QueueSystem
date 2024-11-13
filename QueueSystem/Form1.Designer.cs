namespace QueueSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtP0 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRho = new System.Windows.Forms.TextBox();
            this.CalcPerformance = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLs = new System.Windows.Forms.TextBox();
            this.calcMM1P0 = new System.Windows.Forms.Button();
            this.btnCalcRho = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtMMSP0 = new System.Windows.Forms.TextBox();
            this.txtMMSServicesCount = new System.Windows.Forms.TextBox();
            this.txtMMSmho = new System.Windows.Forms.TextBox();
            this.txtMMSLambda = new System.Windows.Forms.TextBox();
            this.calcMMSP0 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblMMSReultP0 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1099, 604);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtP0);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtRho);
            this.tabPage1.Controls.Add(this.CalcPerformance);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtWq);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtWs);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtLq);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtLs);
            this.tabPage1.Controls.Add(this.calcMM1P0);
            this.tabPage1.Controls.Add(this.btnCalcRho);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtMho);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtLambda);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1091, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "M/M/1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1018, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "P0";
            // 
            // txtP0
            // 
            this.txtP0.Location = new System.Drawing.Point(765, 64);
            this.txtP0.Name = "txtP0";
            this.txtP0.Size = new System.Drawing.Size(223, 24);
            this.txtP0.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Rho";
            // 
            // txtRho
            // 
            this.txtRho.Location = new System.Drawing.Point(420, 162);
            this.txtRho.Name = "txtRho";
            this.txtRho.Size = new System.Drawing.Size(132, 24);
            this.txtRho.TabIndex = 14;
            // 
            // CalcPerformance
            // 
            this.CalcPerformance.Location = new System.Drawing.Point(329, 216);
            this.CalcPerformance.Name = "CalcPerformance";
            this.CalcPerformance.Size = new System.Drawing.Size(223, 23);
            this.CalcPerformance.TabIndex = 13;
            this.CalcPerformance.Text = "Calc Performance";
            this.CalcPerformance.UseVisualStyleBackColor = true;
            this.CalcPerformance.Click += new System.EventHandler(this.CalcPerformance_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Wq";
            // 
            // txtWq
            // 
            this.txtWq.Location = new System.Drawing.Point(329, 406);
            this.txtWq.Name = "txtWq";
            this.txtWq.Size = new System.Drawing.Size(223, 24);
            this.txtWq.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ws";
            // 
            // txtWs
            // 
            this.txtWs.Location = new System.Drawing.Point(329, 354);
            this.txtWs.Name = "txtWs";
            this.txtWs.Size = new System.Drawing.Size(223, 24);
            this.txtWs.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lq";
            // 
            // txtLq
            // 
            this.txtLq.Location = new System.Drawing.Point(329, 301);
            this.txtLq.Name = "txtLq";
            this.txtLq.Size = new System.Drawing.Size(223, 24);
            this.txtLq.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ls";
            // 
            // txtLs
            // 
            this.txtLs.Location = new System.Drawing.Point(329, 245);
            this.txtLs.Name = "txtLs";
            this.txtLs.Size = new System.Drawing.Size(223, 24);
            this.txtLs.TabIndex = 5;
            // 
            // calcMM1P0
            // 
            this.calcMM1P0.Location = new System.Drawing.Point(765, 145);
            this.calcMM1P0.Name = "calcMM1P0";
            this.calcMM1P0.Size = new System.Drawing.Size(85, 23);
            this.calcMM1P0.TabIndex = 4;
            this.calcMM1P0.Text = "Calc p0";
            this.calcMM1P0.UseVisualStyleBackColor = true;
            this.calcMM1P0.Click += new System.EventHandler(this.CalcP0_Click);
            // 
            // btnCalcRho
            // 
            this.btnCalcRho.Location = new System.Drawing.Point(329, 162);
            this.btnCalcRho.Name = "btnCalcRho";
            this.btnCalcRho.Size = new System.Drawing.Size(85, 23);
            this.btnCalcRho.TabIndex = 4;
            this.btnCalcRho.Text = "CalcRho";
            this.btnCalcRho.UseVisualStyleBackColor = true;
            this.btnCalcRho.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "mho";
            // 
            // txtMho
            // 
            this.txtMho.Location = new System.Drawing.Point(329, 111);
            this.txtMho.Name = "txtMho";
            this.txtMho.Size = new System.Drawing.Size(223, 24);
            this.txtMho.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "lambda";
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(329, 64);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(223, 24);
            this.txtLambda.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblMMSReultP0);
            this.tabPage2.Controls.Add(this.txtMMSP0);
            this.tabPage2.Controls.Add(this.txtMMSServicesCount);
            this.tabPage2.Controls.Add(this.txtMMSmho);
            this.tabPage2.Controls.Add(this.txtMMSLambda);
            this.tabPage2.Controls.Add(this.calcMMSP0);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1091, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "M/M/S";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtMMSP0
            // 
            this.txtMMSP0.Location = new System.Drawing.Point(389, 402);
            this.txtMMSP0.Name = "txtMMSP0";
            this.txtMMSP0.Size = new System.Drawing.Size(193, 24);
            this.txtMMSP0.TabIndex = 11;
            // 
            // txtMMSServicesCount
            // 
            this.txtMMSServicesCount.Location = new System.Drawing.Point(389, 156);
            this.txtMMSServicesCount.Name = "txtMMSServicesCount";
            this.txtMMSServicesCount.Size = new System.Drawing.Size(193, 24);
            this.txtMMSServicesCount.TabIndex = 12;
            // 
            // txtMMSmho
            // 
            this.txtMMSmho.Location = new System.Drawing.Point(389, 97);
            this.txtMMSmho.Name = "txtMMSmho";
            this.txtMMSmho.Size = new System.Drawing.Size(193, 24);
            this.txtMMSmho.TabIndex = 9;
            // 
            // txtMMSLambda
            // 
            this.txtMMSLambda.Location = new System.Drawing.Point(389, 48);
            this.txtMMSLambda.Name = "txtMMSLambda";
            this.txtMMSLambda.Size = new System.Drawing.Size(193, 24);
            this.txtMMSLambda.TabIndex = 7;
            // 
            // calcMMSP0
            // 
            this.calcMMSP0.Location = new System.Drawing.Point(389, 211);
            this.calcMMSP0.Name = "calcMMSP0";
            this.calcMMSP0.Size = new System.Drawing.Size(193, 28);
            this.calcMMSP0.TabIndex = 15;
            this.calcMMSP0.Text = "Calc P";
            this.calcMMSP0.UseVisualStyleBackColor = true;
            this.calcMMSP0.Click += new System.EventHandler(this.calcMMSP0_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(613, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "P0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Services Count";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(613, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "mho";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(613, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "lambda";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1091, 575);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblMMSReultP0
            // 
            this.lblMMSReultP0.AutoSize = true;
            this.lblMMSReultP0.Location = new System.Drawing.Point(409, 299);
            this.lblMMSReultP0.Name = "lblMMSReultP0";
            this.lblMMSReultP0.Size = new System.Drawing.Size(24, 17);
            this.lblMMSReultP0.TabIndex = 16;
            this.lblMMSReultP0.Text = "P0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 604);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLs;
        private System.Windows.Forms.Button btnCalcRho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMho;
        private System.Windows.Forms.Button CalcPerformance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRho;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtP0;
        //private System.Windows.Forms.Button CalcP0;
        private System.Windows.Forms.TextBox txtMMSP0;
        private System.Windows.Forms.TextBox txtMMSServicesCount;
        private System.Windows.Forms.TextBox txtMMSmho;
        private System.Windows.Forms.TextBox txtMMSLambda;
        private System.Windows.Forms.Button calcMMSP0;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button calcMM1P0;
        private System.Windows.Forms.Label lblMMSReultP0;
    }
}

