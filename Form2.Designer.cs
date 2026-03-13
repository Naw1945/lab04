namespace lab04
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            txtHoten = new TextBox();
            btCapNhat = new Button();
            groupBox1 = new GroupBox();
            lstBandau = new ListBox();
            groupBox2 = new GroupBox();
            lstKetqua = new ListBox();
            btXoa = new Button();
            btKetthuc = new Button();
            btTraisangphai = new Button();
            btSangtrai = new Button();
            btTatcasangtrai = new Button();
            btTatcasangphai = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(77, 20);
            label1.Name = "label1";
            label1.Size = new Size(377, 37);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH  SINH VIÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(34, 84);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(149, 78);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(283, 31);
            txtHoten.TabIndex = 2;
            // 
            // btCapNhat
            // 
            btCapNhat.Location = new Point(481, 71);
            btCapNhat.Name = "btCapNhat";
            btCapNhat.Size = new Size(112, 34);
            btCapNhat.TabIndex = 3;
            btCapNhat.Text = "Cập nhật";
            btCapNhat.UseVisualStyleBackColor = true;
            btCapNhat.Click += btCapnhat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstBandau);
            groupBox1.Location = new Point(12, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 219);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lớp A";
            // 
            // lstBandau
            // 
            lstBandau.Dock = DockStyle.Fill;
            lstBandau.FormattingEnabled = true;
            lstBandau.Location = new Point(3, 27);
            lstBandau.Name = "lstBandau";
            lstBandau.Size = new Size(222, 189);
            lstBandau.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstKetqua);
            groupBox2.Location = new Point(404, 140);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(228, 219);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lớp B";
            // 
            // lstKetqua
            // 
            lstKetqua.Dock = DockStyle.Fill;
            lstKetqua.FormattingEnabled = true;
            lstKetqua.Location = new Point(3, 27);
            lstKetqua.Name = "lstKetqua";
            lstKetqua.Size = new Size(222, 189);
            lstKetqua.TabIndex = 1;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(62, 371);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(112, 34);
            btXoa.TabIndex = 6;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btKetthuc
            // 
            btKetthuc.Location = new Point(466, 371);
            btKetthuc.Name = "btKetthuc";
            btKetthuc.Size = new Size(112, 34);
            btKetthuc.TabIndex = 7;
            btKetthuc.Text = "Kết thúc";
            btKetthuc.UseVisualStyleBackColor = true;
            btKetthuc.Click += btKetthuc_Click;
            // 
            // btTraisangphai
            // 
            btTraisangphai.Location = new Point(246, 197);
            btTraisangphai.Name = "btTraisangphai";
            btTraisangphai.Size = new Size(66, 34);
            btTraisangphai.TabIndex = 8;
            btTraisangphai.Text = ">";
            btTraisangphai.UseVisualStyleBackColor = true;
            btTraisangphai.Click += btTraisangphai_Click;
            // 
            // btSangtrai
            // 
            btSangtrai.Location = new Point(335, 197);
            btSangtrai.Name = "btSangtrai";
            btSangtrai.Size = new Size(66, 34);
            btSangtrai.TabIndex = 9;
            btSangtrai.Text = "<";
            btSangtrai.UseVisualStyleBackColor = true;
            btSangtrai.Click += btPhaisangtrai_Click;
            // 
            // btTatcasangtrai
            // 
            btTatcasangtrai.Location = new Point(335, 237);
            btTatcasangtrai.Name = "btTatcasangtrai";
            btTatcasangtrai.Size = new Size(66, 34);
            btTatcasangtrai.TabIndex = 11;
            btTatcasangtrai.Text = "<<";
            btTatcasangtrai.UseVisualStyleBackColor = true;
            btTatcasangtrai.Click += btTatcaphaisangtrai_Click;
            // 
            // btTatcasangphai
            // 
            btTatcasangphai.Location = new Point(246, 237);
            btTatcasangphai.Name = "btTatcasangphai";
            btTatcasangphai.Size = new Size(66, 34);
            btTatcasangphai.TabIndex = 10;
            btTatcasangphai.Text = ">>";
            btTatcasangphai.UseVisualStyleBackColor = true;
            btTatcasangphai.Click += btTatcatraisangphai_Click;
            // 
            // Form2
            // 
            AcceptButton = btCapNhat;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 417);
            Controls.Add(btTatcasangtrai);
            Controls.Add(btTatcasangphai);
            Controls.Add(btSangtrai);
            Controls.Add(btTraisangphai);
            Controls.Add(btKetthuc);
            Controls.Add(btXoa);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btCapNhat);
            Controls.Add(txtHoten);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Bài4";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHoten;
        private Button btCapNhat;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox lstBandau;
        private ListBox lstKetqua;
        private Button btXoa;
        private Button btKetthuc;
        private Button btTraisangphai;
        private Button btSangtrai;
        private Button btTatcasangtrai;
        private Button btTatcasangphai;
    }
}