namespace DiscCalc
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMisc = new System.Windows.Forms.TextBox();
            this.radMisc = new System.Windows.Forms.RadioButton();
            this.radK2k = new System.Windows.Forms.RadioButton();
            this.radEmp = new System.Windows.Forms.RadioButton();
            this.radMil = new System.Windows.Forms.RadioButton();
            this.radFreq = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(41, 446);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(149, 446);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(256, 446);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.txtSubtotal);
            this.groupBox1.Location = new System.Drawing.Point(27, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Discount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subtotal";
            // 
            // lblAmount
            // 
            this.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmount.Location = new System.Drawing.Point(124, 105);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(100, 23);
            this.lblAmount.TabIndex = 5;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(124, 40);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMisc);
            this.groupBox2.Controls.Add(this.radMisc);
            this.groupBox2.Controls.Add(this.radK2k);
            this.groupBox2.Controls.Add(this.radEmp);
            this.groupBox2.Controls.Add(this.radMil);
            this.groupBox2.Controls.Add(this.radFreq);
            this.groupBox2.Location = new System.Drawing.Point(27, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 244);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type of Discount";
            // 
            // txtMisc
            // 
            this.txtMisc.Location = new System.Drawing.Point(52, 197);
            this.txtMisc.Name = "txtMisc";
            this.txtMisc.Size = new System.Drawing.Size(54, 20);
            this.txtMisc.TabIndex = 5;
            // 
            // radMisc
            // 
            this.radMisc.AutoSize = true;
            this.radMisc.Location = new System.Drawing.Point(32, 197);
            this.radMisc.Name = "radMisc";
            this.radMisc.Size = new System.Drawing.Size(14, 13);
            this.radMisc.TabIndex = 4;
            this.radMisc.UseVisualStyleBackColor = true;
            // 
            // radK2k
            // 
            this.radK2k.AutoSize = true;
            this.radK2k.Location = new System.Drawing.Point(32, 153);
            this.radK2k.Name = "radK2k";
            this.radK2k.Size = new System.Drawing.Size(74, 17);
            this.radK2k.TabIndex = 3;
            this.radK2k.Text = "K2K (15%)";
            this.radK2k.UseVisualStyleBackColor = true;
            // 
            // radEmp
            // 
            this.radEmp.AutoSize = true;
            this.radEmp.Location = new System.Drawing.Point(32, 112);
            this.radEmp.Name = "radEmp";
            this.radEmp.Size = new System.Drawing.Size(100, 17);
            this.radEmp.TabIndex = 2;
            this.radEmp.Text = "Employee (30%)";
            this.radEmp.UseVisualStyleBackColor = true;
            // 
            // radMil
            // 
            this.radMil.AutoSize = true;
            this.radMil.Location = new System.Drawing.Point(32, 73);
            this.radMil.Name = "radMil";
            this.radMil.Size = new System.Drawing.Size(86, 17);
            this.radMil.TabIndex = 1;
            this.radMil.Text = "Military (10%)";
            this.radMil.UseVisualStyleBackColor = true;
            // 
            // radFreq
            // 
            this.radFreq.AutoSize = true;
            this.radFreq.Checked = true;
            this.radFreq.Location = new System.Drawing.Point(32, 34);
            this.radFreq.Name = "radFreq";
            this.radFreq.Size = new System.Drawing.Size(139, 17);
            this.radFreq.TabIndex = 0;
            this.radFreq.TabStop = true;
            this.radFreq.Text = "Frequent Shopper (20%)";
            this.radFreq.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(364, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(364, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Discount Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radK2k;
        private System.Windows.Forms.RadioButton radEmp;
        private System.Windows.Forms.RadioButton radMil;
        private System.Windows.Forms.RadioButton radFreq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMisc;
        private System.Windows.Forms.RadioButton radMisc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

