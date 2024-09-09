namespace BookStoreManagement
{
    partial class fSuaSach
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "SAO348", "Tieng Anh 12", "Nguyen Van Nam", "Sách tham khảo", "Sach tieng viet", "3000" }, -1);
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btnChon = new Button();
            lblLoaiSach = new Label();
            lblNXB = new Label();
            lblTaiBan = new Label();
            lblXuatBan = new Label();
            lblLinhVuc = new Label();
            lblTacGia = new Label();
            lblGiaBia = new Label();
            lblGiaMua = new Label();
            lblTenSach = new Label();
            lblMaSach = new Label();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnLuu = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.GridLines = true;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(25, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(1104, 201);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "MÃ SÁCH";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "TÊN SÁCH";
            columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "TÁC GIẢ";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "LĨNH VỰC";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "LOẠI SÁCH";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "GIÁ MUA";
            columnHeader6.Width = 100;
            // 
            // btnChon
            // 
            btnChon.Location = new Point(25, 236);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(94, 29);
            btnChon.TabIndex = 1;
            btnChon.Text = "CHỌN";
            btnChon.UseVisualStyleBackColor = true;
            // 
            // lblLoaiSach
            // 
            lblLoaiSach.AutoSize = true;
            lblLoaiSach.Location = new Point(25, 473);
            lblLoaiSach.Name = "lblLoaiSach";
            lblLoaiSach.Size = new Size(85, 20);
            lblLoaiSach.TabIndex = 28;
            lblLoaiSach.Text = "LOẠI SÁCH:";
            // 
            // lblNXB
            // 
            lblNXB.AutoSize = true;
            lblNXB.Location = new Point(603, 300);
            lblNXB.Name = "lblNXB";
            lblNXB.Size = new Size(72, 20);
            lblNXB.TabIndex = 27;
            lblNXB.Text = "TÊN NXB:";
            // 
            // lblTaiBan
            // 
            lblTaiBan.AutoSize = true;
            lblTaiBan.Location = new Point(603, 432);
            lblTaiBan.Name = "lblTaiBan";
            lblTaiBan.Size = new Size(99, 20);
            lblTaiBan.TabIndex = 26;
            lblTaiBan.Text = "LẦN TÁI BẢN:";
            // 
            // lblXuatBan
            // 
            lblXuatBan.AutoSize = true;
            lblXuatBan.Location = new Point(604, 473);
            lblXuatBan.Name = "lblXuatBan";
            lblXuatBan.Size = new Size(121, 20);
            lblXuatBan.TabIndex = 25;
            lblXuatBan.Text = "NĂM XUẤT BẢN:";
            // 
            // lblLinhVuc
            // 
            lblLinhVuc.AutoSize = true;
            lblLinhVuc.Location = new Point(25, 432);
            lblLinhVuc.Name = "lblLinhVuc";
            lblLinhVuc.Size = new Size(78, 20);
            lblLinhVuc.TabIndex = 24;
            lblLinhVuc.Text = "LĨNH VỰC:";
            // 
            // lblTacGia
            // 
            lblTacGia.AutoSize = true;
            lblTacGia.Location = new Point(25, 393);
            lblTacGia.Name = "lblTacGia";
            lblTacGia.Size = new Size(66, 20);
            lblTacGia.TabIndex = 23;
            lblTacGia.Text = "TÁC GIẢ:";
            // 
            // lblGiaBia
            // 
            lblGiaBia.AutoSize = true;
            lblGiaBia.Location = new Point(603, 393);
            lblGiaBia.Name = "lblGiaBia";
            lblGiaBia.Size = new Size(63, 20);
            lblGiaBia.TabIndex = 22;
            lblGiaBia.Text = "GIÁ BÌA:";
            // 
            // lblGiaMua
            // 
            lblGiaMua.AutoSize = true;
            lblGiaMua.Location = new Point(604, 343);
            lblGiaMua.Name = "lblGiaMua";
            lblGiaMua.Size = new Size(73, 20);
            lblGiaMua.TabIndex = 21;
            lblGiaMua.Text = "GIÁ MUA:";
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Location = new Point(25, 349);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(81, 20);
            lblTenSach.TabIndex = 20;
            lblTenSach.Text = "TÊN SÁCH:";
            // 
            // lblMaSach
            // 
            lblMaSach.AutoSize = true;
            lblMaSach.Location = new Point(25, 309);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(77, 20);
            lblMaSach.TabIndex = 19;
            lblMaSach.Text = "MÃ SÁCH:";
            lblMaSach.Click += lblMaSach_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(731, 468);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(414, 27);
            dateTimePicker1.TabIndex = 38;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(731, 425);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(421, 27);
            numericUpDown3.TabIndex = 37;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(731, 336);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(421, 27);
            numericUpDown2.TabIndex = 36;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(731, 385);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(421, 27);
            numericUpDown1.TabIndex = 35;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(112, 465);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(423, 28);
            comboBox4.TabIndex = 34;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(109, 424);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(423, 28);
            comboBox3.TabIndex = 33;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(729, 292);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(423, 28);
            comboBox2.TabIndex = 32;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(112, 385);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(423, 28);
            comboBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 340);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(423, 27);
            textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 302);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(423, 27);
            textBox1.TabIndex = 29;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(105, 524);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(178, 29);
            btnLuu.TabIndex = 39;
            btnLuu.Text = "LƯU";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // fSuaSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 573);
            Controls.Add(btnLuu);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblLoaiSach);
            Controls.Add(lblNXB);
            Controls.Add(lblTaiBan);
            Controls.Add(lblXuatBan);
            Controls.Add(lblLinhVuc);
            Controls.Add(lblTacGia);
            Controls.Add(lblGiaBia);
            Controls.Add(lblGiaMua);
            Controls.Add(lblTenSach);
            Controls.Add(lblMaSach);
            Controls.Add(btnChon);
            Controls.Add(listView1);
            Name = "fSuaSach";
            Text = "SỬA SÁCH";
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnChon;
        private Label lblLoaiSach;
        private Label lblNXB;
        private Label lblTaiBan;
        private Label lblXuatBan;
        private Label lblLinhVuc;
        private Label lblTacGia;
        private Label lblGiaBia;
        private Label lblGiaMua;
        private Label lblTenSach;
        private Label lblMaSach;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnLuu;
    }
}