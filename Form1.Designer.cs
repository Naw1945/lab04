namespace lab04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            chkClean = new CheckBox();
            chkWhitening = new CheckBox();
            chkXRay = new CheckBox();
            numFilling = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTotal = new TextBox();
            label8 = new Label();
            btnExit = new Button();
            btnCalc = new Button();
            ((System.ComponentModel.ISupportInitialize)numFilling).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(83, 22);
            label1.Name = "label1";
            label1.Size = new Size(320, 42);
            label1.TabIndex = 0;
            label1.Text = "DENTAL PAYMENT FORM";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 98);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên Khách Hàng";
            // 
            // txtName
            // 
            txtName.Location = new Point(192, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(247, 31);
            txtName.TabIndex = 2;
            // 
            // chkClean
            // 
            chkClean.AutoSize = true;
            chkClean.Location = new Point(27, 146);
            chkClean.Name = "chkClean";
            chkClean.Size = new Size(98, 29);
            chkClean.TabIndex = 3;
            chkClean.Text = "Cạo vôi";
            chkClean.UseVisualStyleBackColor = true;
            // 
            // chkWhitening
            // 
            chkWhitening.AutoSize = true;
            chkWhitening.Location = new Point(27, 202);
            chkWhitening.Name = "chkWhitening";
            chkWhitening.Size = new Size(112, 29);
            chkWhitening.TabIndex = 4;
            chkWhitening.Text = "Tẩy trắng";
            chkWhitening.UseVisualStyleBackColor = true;
            // 
            // chkXRay
            // 
            chkXRay.AutoSize = true;
            chkXRay.Location = new Point(27, 253);
            chkXRay.Name = "chkXRay";
            chkXRay.Size = new Size(160, 29);
            chkXRay.TabIndex = 5;
            chkXRay.Text = "Chụp hình răng";
            chkXRay.UseVisualStyleBackColor = true;
            // 
            // numFilling
            // 
            numFilling.Location = new Point(133, 304);
            numFilling.Name = "numFilling";
            numFilling.Size = new Size(121, 31);
            numFilling.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 310);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 7;
            label3.Text = "Trám răng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 150);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 8;
            label4.Text = "100000 VND";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 203);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 9;
            label5.Text = "1200000 VND";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 257);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 10;
            label6.Text = "200000 VND";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(335, 310);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 11;
            label7.Text = "80000 VND";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(295, 374);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(144, 31);
            txtTotal.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(219, 380);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 13;
            label8.Text = "Total";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(83, 462);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 14;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(291, 462);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(112, 34);
            btnCalc.TabIndex = 15;
            btnCalc.Text = "Tính tiền";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 508);
            Controls.Add(btnCalc);
            Controls.Add(btnExit);
            Controls.Add(label8);
            Controls.Add(txtTotal);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numFilling);
            Controls.Add(chkXRay);
            Controls.Add(chkWhitening);
            Controls.Add(chkClean);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài1";
            ((System.ComponentModel.ISupportInitialize)numFilling).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private CheckBox chkClean;
        private CheckBox chkWhitening;
        private CheckBox chkXRay;
        private NumericUpDown numFilling;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTotal;
        private Label label8;
        private Button btnExit;
        private Button btnCalc;
    }
}
