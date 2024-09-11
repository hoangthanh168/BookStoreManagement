
namespace BookStoreManagement
{
	partial class FSuaTG
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
            ColumnHeader MãTG;
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "1", "Nguyen Van A", "Hue", "19XX", "19XX" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "2", "Pham Van B", "Quang Ngai", "188X", "19XX" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "3", "Pham Thi C", "Dong Nai", "199X", "20XX" }, -1);
            listView1 = new ListView();
            TênTG = new ColumnHeader();
            QQ = new ColumnHeader();
            NSinh = new ColumnHeader();
            SMat = new ColumnHeader();
            btnChon = new Button();
            btnLuu = new Button();
            checkBox4 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            cbNmat = new ComboBox();
            cbNsinh = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lbNMat = new Label();
            lbNSinh = new Label();
            lbQQ = new Label();
            lbTenTG = new Label();
            lbMaTG = new Label();
            MãTG = new ColumnHeader();
            SuspendLayout();
            // 
            // MãTG
            // 
            MãTG.Text = "Mã tác giả";
            MãTG.Width = 85;
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { MãTG, TênTG, QQ, NSinh, SMat });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.Location = new Point(10, 10);
            listView1.Name = "listView1";
            listView1.Size = new Size(489, 236);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // TênTG
            // 
            TênTG.Text = "Tên tác giả";
            TênTG.TextAlign = HorizontalAlignment.Center;
            TênTG.Width = 150;
            // 
            // QQ
            // 
            QQ.Text = "Quê quán";
            QQ.TextAlign = HorizontalAlignment.Center;
            QQ.Width = 115;
            // 
            // NSinh
            // 
            NSinh.Text = "Năm sinh";
            NSinh.TextAlign = HorizontalAlignment.Center;
            NSinh.Width = 100;
            // 
            // SMat
            // 
            SMat.Text = "Năm mất";
            SMat.TextAlign = HorizontalAlignment.Center;
            SMat.Width = 100;
            // 
            // btnChon
            // 
            btnChon.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnChon.FlatAppearance.BorderSize = 5;
            btnChon.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnChon.FlatAppearance.MouseOverBackColor = Color.DarkViolet;
            btnChon.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChon.ForeColor = SystemColors.Desktop;
            btnChon.Location = new Point(10, 263);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(183, 48);
            btnChon.TabIndex = 18;
            btnChon.Text = "Chọn";
            btnChon.UseVisualStyleBackColor = true;
            btnChon.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnLuu.FlatAppearance.BorderSize = 5;
            btnLuu.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnLuu.FlatAppearance.MouseOverBackColor = Color.DarkViolet;
            btnLuu.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = SystemColors.Desktop;
            btnLuu.Location = new Point(642, 277);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(183, 48);
            btnLuu.TabIndex = 19;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(866, 225);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(74, 21);
            checkBox4.TabIndex = 15;
            checkBox4.Text = "Chưa rõ";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(831, 130);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(74, 21);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "Chưa rõ";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(831, 92);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 21);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Chưa rõ";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // cbNmat
            // 
            cbNmat.FormattingEnabled = true;
            cbNmat.Location = new Point(631, 162);
            cbNmat.Name = "cbNmat";
            cbNmat.Size = new Size(192, 25);
            cbNmat.TabIndex = 13;
            // 
            // cbNsinh
            // 
            cbNsinh.FormattingEnabled = true;
            cbNsinh.Location = new Point(631, 128);
            cbNsinh.Name = "cbNsinh";
            cbNsinh.Size = new Size(192, 25);
            cbNsinh.TabIndex = 14;
            cbNsinh.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(631, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 25);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(631, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 25);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(631, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 25);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lbNMat
            // 
            lbNMat.AutoSize = true;
            lbNMat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbNMat.Location = new Point(523, 162);
            lbNMat.Name = "lbNMat";
            lbNMat.Size = new Size(85, 21);
            lbNMat.TabIndex = 5;
            lbNMat.Text = "Ngày mất";
            // 
            // lbNSinh
            // 
            lbNSinh.AutoSize = true;
            lbNSinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbNSinh.Location = new Point(520, 128);
            lbNSinh.Name = "lbNSinh";
            lbNSinh.Size = new Size(87, 21);
            lbNSinh.TabIndex = 6;
            lbNSinh.Text = "Ngày sinh";
            // 
            // lbQQ
            // 
            lbQQ.AutoSize = true;
            lbQQ.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbQQ.Location = new Point(523, 88);
            lbQQ.Name = "lbQQ";
            lbQQ.Size = new Size(84, 21);
            lbQQ.TabIndex = 7;
            lbQQ.Text = "Quê quán";
            lbQQ.Click += lbQQ_Click;
            // 
            // lbTenTG
            // 
            lbTenTG.AutoSize = true;
            lbTenTG.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbTenTG.Location = new Point(518, 47);
            lbTenTG.Name = "lbTenTG";
            lbTenTG.Size = new Size(92, 21);
            lbTenTG.TabIndex = 8;
            lbTenTG.Text = "Tên tác giả";
            // 
            // lbMaTG
            // 
            lbMaTG.AutoSize = true;
            lbMaTG.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbMaTG.Location = new Point(518, 10);
            lbMaTG.Name = "lbMaTG";
            lbMaTG.Size = new Size(89, 21);
            lbMaTG.TabIndex = 9;
            lbMaTG.Text = "Mã tác giả";
            // 
            // FSuaTG
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 436);
            Controls.Add(btnChon);
            Controls.Add(btnLuu);
            Controls.Add(checkBox4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(cbNmat);
            Controls.Add(cbNsinh);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbNMat);
            Controls.Add(lbNSinh);
            Controls.Add(lbQQ);
            Controls.Add(lbTenTG);
            Controls.Add(lbMaTG);
            Controls.Add(listView1);
            Name = "FSuaTG";
            Text = "Fsuatacgia";
            ResumeLayout(false);
            PerformLayout();
        }

        private void lbQQ_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private ListView listView1;
		private ColumnHeader TênTG;
		private ColumnHeader QQ;
		private ColumnHeader NSinh;
		private ColumnHeader SMat;
		private Button btnChon;
		private Button btnLuu;
		private CheckBox checkBox4;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private ComboBox cbNmat;
		private ComboBox cbNsinh;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label lbNMat;
		private Label lbNSinh;
		private Label lbQQ;
		private Label lbTenTG;
		private Label lbMaTG;
	}
}