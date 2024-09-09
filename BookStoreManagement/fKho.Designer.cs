namespace BookStoreManagement
{
    partial class fKho
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "SAN0348", "Tieng Anh 12", "Nguyen Van A", "Tieu thuyet", "Sach" }, -1);
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            listView1 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            domainUpDown1 = new DomainUpDown();
            button1 = new Button();
            button2 = new Button();
            domainUpDown2 = new DomainUpDown();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button5 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView2.GridLines = true;
            listView2.Location = new Point(11, 42);
            listView2.Margin = new Padding(2, 2, 2, 2);
            listView2.Name = "listView2";
            listView2.Size = new Size(695, 179);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã Sách";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên Sách";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số Lượng";
            columnHeader3.Width = 200;
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listViewItem1.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(7, 337);
            listView1.Margin = new Padding(2, 2, 2, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(696, 158);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Mã Sách";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tên Sách";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tác Giả";
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Lĩnh Vực";
            columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Loại";
            columnHeader8.Width = 200;
            // 
            // button3
            // 
            button3.Location = new Point(117, 11);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(108, 27);
            button3.TabIndex = 14;
            button3.Text = "Xóa Sách";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(11, 11);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(102, 27);
            button4.TabIndex = 15;
            button4.Text = "Chọn Sửa";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 238);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 16;
            label1.Text = "Mã Sách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 267);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 17;
            label2.Text = "Số Lượng:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 236);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 25);
            textBox1.TabIndex = 18;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(117, 266);
            domainUpDown1.Margin = new Padding(2, 2, 2, 2);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(148, 25);
            domainUpDown1.TabIndex = 19;
            domainUpDown1.Text = "1";
            // 
            // button1
            // 
            button1.Location = new Point(305, 266);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(102, 25);
            button1.TabIndex = 20;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(305, 569);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(103, 26);
            button2.TabIndex = 27;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            // 
            // domainUpDown2
            // 
            domainUpDown2.Location = new Point(117, 570);
            domainUpDown2.Margin = new Padding(2, 2, 2, 2);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(148, 25);
            domainUpDown2.TabIndex = 26;
            domainUpDown2.Text = "1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 540);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 25);
            textBox2.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 571);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 24;
            label3.Text = "Số Lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 542);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 23;
            label4.Text = "Mã Sách:";
            // 
            // button5
            // 
            button5.Location = new Point(7, 499);
            button5.Margin = new Padding(2, 2, 2, 2);
            button5.Name = "button5";
            button5.Size = new Size(102, 27);
            button5.TabIndex = 22;
            button5.Text = "Chọn Thêm";
            button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 314);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 28;
            label5.Text = "CHỌN SÁCH";
            // 
            // fKho
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 630);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(domainUpDown2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(domainUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listView1);
            Controls.Add(listView2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "fKho";
            Text = "fKho";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listView2;
        private ListView listView1;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private DomainUpDown domainUpDown1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button1;
        private Button button2;
        private DomainUpDown domainUpDown2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button button5;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label5;
    }
}