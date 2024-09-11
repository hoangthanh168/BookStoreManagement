
namespace BookStoreManagement
{
	partial class FThemTG
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
            lbMaTG = new Label();
            lbTenTG = new Label();
            lbQQ = new Label();
            lbNSinh = new Label();
            lbNMat = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            cbNSinh = new ComboBox();
            cbNMat = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox4 = new CheckBox();
            btnThem = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lbMaTG
            // 
            lbMaTG.AutoSize = true;
            lbMaTG.Font = new Font("Segoe UI", 9.75F);
            lbMaTG.Location = new Point(12, 9);
            lbMaTG.Name = "lbMaTG";
            lbMaTG.Size = new Size(70, 17);
            lbMaTG.TabIndex = 0;
            lbMaTG.Text = "Mã tác giả";
            // 
            // lbTenTG
            // 
            lbTenTG.AutoSize = true;
            lbTenTG.Font = new Font("Segoe UI", 9.75F);
            lbTenTG.Location = new Point(12, 54);
            lbTenTG.Name = "lbTenTG";
            lbTenTG.Size = new Size(71, 17);
            lbTenTG.TabIndex = 0;
            lbTenTG.Text = "Tên tác giả";
            lbTenTG.Click += lbTenTG_Click;
            // 
            // lbQQ
            // 
            lbQQ.AutoSize = true;
            lbQQ.Font = new Font("Segoe UI", 9.75F);
            lbQQ.Location = new Point(13, 100);
            lbQQ.Name = "lbQQ";
            lbQQ.Size = new Size(65, 17);
            lbQQ.TabIndex = 0;
            lbQQ.Text = "Quê quán";
            // 
            // lbNSinh
            // 
            lbNSinh.AutoSize = true;
            lbNSinh.Font = new Font("Segoe UI", 9.75F);
            lbNSinh.Location = new Point(12, 145);
            lbNSinh.Name = "lbNSinh";
            lbNSinh.Size = new Size(66, 17);
            lbNSinh.TabIndex = 0;
            lbNSinh.Text = "Ngày sinh";
            // 
            // lbNMat
            // 
            lbNMat.AutoSize = true;
            lbNMat.Font = new Font("Segoe UI", 9.75F);
            lbNMat.Location = new Point(12, 192);
            lbNMat.Name = "lbNMat";
            lbNMat.Size = new Size(65, 17);
            lbNMat.TabIndex = 0;
            lbNMat.Text = "Ngày mất";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 25);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(88, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(88, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(202, 25);
            textBox3.TabIndex = 1;
            // 
            // cbNSinh
            // 
            cbNSinh.FormattingEnabled = true;
            cbNSinh.Location = new Point(88, 142);
            cbNSinh.Name = "cbNSinh";
            cbNSinh.Size = new Size(202, 25);
            cbNSinh.TabIndex = 2;
            cbNSinh.SelectedIndexChanged += cbNSinh_SelectedIndexChanged;
            // 
            // cbNMat
            // 
            cbNMat.FormattingEnabled = true;
            cbNMat.Location = new Point(88, 189);
            cbNMat.Name = "cbNMat";
            cbNMat.Size = new Size(202, 25);
            cbNMat.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(306, 99);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 21);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Chưa rõ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(306, 145);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(74, 21);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Chưa rõ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(306, 191);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(74, 21);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Chưa rõ";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.FlatAppearance.BorderColor = Color.White;
            btnThem.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnThem.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnThem.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.Desktop;
            btnThem.Location = new Point(256, 240);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(124, 34);
            btnThem.TabIndex = 4;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.FlatAppearance.BorderColor = Color.Red;
            btnThoat.FlatAppearance.BorderSize = 5;
            btnThoat.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnThoat.FlatAppearance.MouseOverBackColor = Color.DarkViolet;
            btnThoat.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.Desktop;
            btnThoat.Location = new Point(128, 240);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(122, 34);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // FThemTG
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 294);
            Controls.Add(btnThoat);
            Controls.Add(btnThem);
            Controls.Add(checkBox4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(cbNMat);
            Controls.Add(cbNSinh);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbNMat);
            Controls.Add(lbNSinh);
            Controls.Add(lbQQ);
            Controls.Add(lbTenTG);
            Controls.Add(lbMaTG);
            Name = "FThemTG";
            Text = "Fthemtacgia";
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void lbTenTG_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private Label lbMaTG;
		private Label lbTenTG;
		private Label lbQQ;
		private Label lbNSinh;
		private Label lbNMat;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private ComboBox cbNSinh;
		private ComboBox cbNMat;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private CheckBox checkBox4;
		private Button btnThem;
		private Button btnThoat;
	}
}