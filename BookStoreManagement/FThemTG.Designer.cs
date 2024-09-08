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
			comboBox1 = new ComboBox();
			comboBox2 = new ComboBox();
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
			lbMaTG.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
			lbMaTG.Location = new Point(43, 51);
			lbMaTG.Name = "lbMaTG";
			lbMaTG.Size = new Size(112, 28);
			lbMaTG.TabIndex = 0;
			lbMaTG.Text = "Mã tác giả";
			// 
			// lbTenTG
			// 
			lbTenTG.AutoSize = true;
			lbTenTG.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
			lbTenTG.Location = new Point(43, 104);
			lbTenTG.Name = "lbTenTG";
			lbTenTG.Size = new Size(115, 28);
			lbTenTG.TabIndex = 0;
			lbTenTG.Text = "Tên tác giả";
			lbTenTG.Click += this.lbTenTG_Click;
			// 
			// lbQQ
			// 
			lbQQ.AutoSize = true;
			lbQQ.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
			lbQQ.Location = new Point(45, 158);
			lbQQ.Name = "lbQQ";
			lbQQ.Size = new Size(103, 28);
			lbQQ.TabIndex = 0;
			lbQQ.Text = "Quê quán";
			// 
			// lbNSinh
			// 
			lbNSinh.AutoSize = true;
			lbNSinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
			lbNSinh.Location = new Point(43, 211);
			lbNSinh.Name = "lbNSinh";
			lbNSinh.Size = new Size(107, 28);
			lbNSinh.TabIndex = 0;
			lbNSinh.Text = "Ngày sinh";
			// 
			// lbNMat
			// 
			lbNMat.AutoSize = true;
			lbNMat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
			lbNMat.Location = new Point(43, 266);
			lbNMat.Name = "lbNMat";
			lbNMat.Size = new Size(105, 28);
			lbNMat.TabIndex = 0;
			lbNMat.Text = "Ngày mất";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(199, 51);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(333, 27);
			textBox1.TabIndex = 1;
			textBox1.TextChanged += this.textBox1_TextChanged;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(199, 104);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(333, 27);
			textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(199, 155);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(230, 27);
			textBox3.TabIndex = 1;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(199, 211);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(230, 28);
			comboBox1.TabIndex = 2;
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(199, 266);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(230, 28);
			comboBox2.TabIndex = 2;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(449, 158);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(83, 24);
			checkBox1.TabIndex = 3;
			checkBox1.Text = "Chưa rõ";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Location = new Point(449, 215);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(83, 24);
			checkBox2.TabIndex = 3;
			checkBox2.Text = "Chưa rõ";
			checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			checkBox4.AutoSize = true;
			checkBox4.Location = new Point(449, 270);
			checkBox4.Name = "checkBox4";
			checkBox4.Size = new Size(83, 24);
			checkBox4.TabIndex = 3;
			checkBox4.Text = "Chưa rõ";
			checkBox4.UseVisualStyleBackColor = true;
			// 
			// btnThem
			// 
			btnThem.FlatAppearance.BorderColor = Color.Red;
			btnThem.FlatAppearance.BorderSize = 5;
			btnThem.FlatAppearance.MouseDownBackColor = Color.Gold;
			btnThem.FlatAppearance.MouseOverBackColor = Color.DarkViolet;
			btnThem.FlatStyle = FlatStyle.Flat;
			btnThem.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			btnThem.ForeColor = SystemColors.Desktop;
			btnThem.Location = new Point(301, 335);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(209, 56);
			btnThem.TabIndex = 4;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			// 
			// btnThoat
			// 
			btnThoat.FlatAppearance.BorderColor = Color.Red;
			btnThoat.FlatAppearance.BorderSize = 5;
			btnThoat.FlatAppearance.MouseDownBackColor = Color.Gold;
			btnThoat.FlatAppearance.MouseOverBackColor = Color.DarkViolet;
			btnThoat.FlatStyle = FlatStyle.Flat;
			btnThoat.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			btnThoat.ForeColor = SystemColors.Desktop;
			btnThoat.Location = new Point(301, 424);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(209, 56);
			btnThoat.TabIndex = 4;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			// 
			// FThemTG
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(558, 511);
			Controls.Add(btnThoat);
			Controls.Add(btnThem);
			Controls.Add(checkBox4);
			Controls.Add(checkBox2);
			Controls.Add(checkBox1);
			Controls.Add(comboBox2);
			Controls.Add(comboBox1);
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

		#endregion

		private Label lbMaTG;
		private Label lbTenTG;
		private Label lbQQ;
		private Label lbNSinh;
		private Label lbNMat;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private CheckBox checkBox4;
		private Button btnThem;
		private Button btnThoat;
	}
}