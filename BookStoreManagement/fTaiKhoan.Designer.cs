namespace BookStoreManagement
{
    partial class fTaiKhoan
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
            ListViewItem listViewItem1 = new ListViewItem("uit");
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            btnChon = new Button();
            lblTenDN = new Label();
            lblMKHTai = new Label();
            lblMKMoi = new Label();
            lblNhapLai = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(602, 103);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "DANH SÁCH CÁC NGƯỜI DÙNG";
            columnHeader1.Width = 500;
            // 
            // btnChon
            // 
            btnChon.Location = new Point(12, 130);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(127, 29);
            btnChon.TabIndex = 1;
            btnChon.Text = "CHỌN";
            btnChon.UseVisualStyleBackColor = true;
            // 
            // lblTenDN
            // 
            lblTenDN.AutoSize = true;
            lblTenDN.Location = new Point(12, 198);
            lblTenDN.Name = "lblTenDN";
            lblTenDN.Size = new Size(129, 20);
            lblTenDN.TabIndex = 2;
            lblTenDN.Text = "TÊN ĐĂNG NHẬP:";
            // 
            // lblMKHTai
            // 
            lblMKHTai.AutoSize = true;
            lblMKHTai.Location = new Point(12, 248);
            lblMKHTai.Name = "lblMKHTai";
            lblMKHTai.Size = new Size(151, 20);
            lblMKHTai.TabIndex = 3;
            lblMKHTai.Text = "MẬT KHẨU HIỆN TẠI:";
            // 
            // lblMKMoi
            // 
            lblMKMoi.AutoSize = true;
            lblMKMoi.Location = new Point(12, 302);
            lblMKMoi.Name = "lblMKMoi";
            lblMKMoi.Size = new Size(119, 20);
            lblMKMoi.TabIndex = 4;
            lblMKMoi.Text = "MẬT KHẨU MỚI:";
            // 
            // lblNhapLai
            // 
            lblNhapLai.AutoSize = true;
            lblNhapLai.Location = new Point(12, 350);
            lblNhapLai.Name = "lblNhapLai";
            lblNhapLai.Size = new Size(77, 20);
            lblNhapLai.TabIndex = 5;
            lblNhapLai.Text = "NHẬP LẠI:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(216, 248);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(321, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(216, 302);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(321, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(216, 350);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(321, 27);
            textBox4.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(197, 402);
            button1.Name = "button1";
            button1.Size = new Size(252, 36);
            button1.TabIndex = 10;
            button1.Text = "CẬP NHẬT";
            button1.UseVisualStyleBackColor = true;
            // 
            // fTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 450);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblNhapLai);
            Controls.Add(lblMKMoi);
            Controls.Add(lblMKHTai);
            Controls.Add(lblTenDN);
            Controls.Add(btnChon);
            Controls.Add(listView1);
            Name = "fTaiKhoan";
            Text = "THÔNG TIN TÀI KHOẢN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Button btnChon;
        private Label lblTenDN;
        private Label lblMKHTai;
        private Label lblMKMoi;
        private Label lblNhapLai;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
    }
}