namespace BookStoreManagement
{
    partial class fDangNhap
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
            lblTenDangNhap = new Label();
            lblMatKhau = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(36, 53);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(129, 20);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "TÊN ĐĂNG NHẬP:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(36, 109);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(87, 20);
            lblMatKhau.TabIndex = 1;
            lblMatKhau.Text = "MẬT KHẨU:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 27);
            textBox2.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(244, 172);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(203, 27);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // fDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 222);
            Controls.Add(btnDangNhap);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTenDangNhap);
            Name = "fDangNhap";
            Text = "ĐĂNG NHẬP TÀI KHOẢN";
            Load += fDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenDangNhap;
        private Label lblMatKhau;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnDangNhap;
    }
}