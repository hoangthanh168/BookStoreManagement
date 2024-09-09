namespace BookStoreManagement
{
    partial class fHoaDon
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "HD0170", "Khách Hàng 1", "9/9/2024 12:00:00 AM", "37.000" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "HD0170", "SA0348", "Tieng Anh 12", "1", "70000", "70000" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "SA0348", "Tieng Anh 12", "70000", "TG0534", "Nguyen Van A" }, -1);
            label5 = new Label();
            button5 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            listView1 = new ListView();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            listView3 = new ListView();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            label9 = new Label();
            domainUpDown1 = new DomainUpDown();
            button2 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(808, 386);
            label5.Name = "label5";
            label5.Size = new Size(128, 28);
            label5.TabIndex = 44;
            label5.Text = "CHỌN SÁCH";
            // 
            // button5
            // 
            button5.Location = new Point(612, 293);
            button5.Name = "button5";
            button5.Size = new Size(172, 39);
            button5.TabIndex = 38;
            button5.Text = "Chi Tiết Hóa Đơn";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(504, 477);
            button1.Name = "button1";
            button1.Size = new Size(146, 31);
            button1.TabIndex = 37;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 433);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 31);
            textBox1.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 483);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 34;
            label2.Text = "* Ngày Lập:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 439);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 33;
            label1.Text = "* Tên Khách Hàng:";
            // 
            // button4
            // 
            button4.Location = new Point(47, 293);
            button4.Name = "button4";
            button4.Size = new Size(146, 39);
            button4.TabIndex = 32;
            button4.Text = "Chọn Sửa";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(262, 293);
            button3.Name = "button3";
            button3.Size = new Size(212, 39);
            button3.TabIndex = 31;
            button3.Text = "Xóa Hóa Đơn";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(47, 41);
            listView1.Name = "listView1";
            listView1.Size = new Size(737, 227);
            listView1.TabIndex = 45;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            listView2.GridLines = true;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView2.Location = new Point(808, 41);
            listView2.Name = "listView2";
            listView2.Size = new Size(1173, 227);
            listView2.TabIndex = 46;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã Hóa Đơn";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên Khách Hàng";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày Lập";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tổng Tiền";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mã Hóa Đơn";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Mã Sách";
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Tên Sách";
            columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Số Lượng";
            columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Giá Tiền";
            columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Thành Tiền";
            columnHeader10.Width = 200;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 386);
            label6.Name = "label6";
            label6.Size = new Size(128, 28);
            label6.TabIndex = 47;
            label6.Text = "Sửa Hóa Đơn";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(237, 478);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(261, 31);
            dateTimePicker1.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 568);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 49;
            label3.Text = "Sửa Hóa Đơn";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 618);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(413, 31);
            textBox2.TabIndex = 51;
            textBox2.Text = "HD0859";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 624);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 50;
            label4.Text = "* Mã Hóa Đơn:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(237, 665);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(413, 31);
            textBox3.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 671);
            label7.Name = "label7";
            label7.Size = new Size(155, 25);
            label7.TabIndex = 52;
            label7.Text = "* Tên Khách Hàng:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(237, 718);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(261, 31);
            dateTimePicker2.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 723);
            label8.Name = "label8";
            label8.Size = new Size(104, 25);
            label8.TabIndex = 54;
            label8.Text = "* Ngày Lập:";
            // 
            // listView3
            // 
            listView3.CheckBoxes = true;
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15 });
            listView3.GridLines = true;
            listViewItem3.StateImageIndex = 0;
            listView3.Items.AddRange(new ListViewItem[] { listViewItem3 });
            listView3.Location = new Point(808, 439);
            listView3.Name = "listView3";
            listView3.Size = new Size(1173, 227);
            listView3.TabIndex = 56;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Mã Sách";
            columnHeader11.Width = 200;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Tên Sách";
            columnHeader12.Width = 200;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Giá Bìa";
            columnHeader13.Width = 200;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Mã Tác Giả";
            columnHeader14.Width = 200;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Tên Tác Giả";
            columnHeader15.Width = 200;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(808, 718);
            label9.Name = "label9";
            label9.Size = new Size(100, 28);
            label9.TabIndex = 57;
            label9.Text = "Số Lượng:";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(930, 718);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(274, 31);
            domainUpDown1.TabIndex = 58;
            domainUpDown1.Text = "1";
            // 
            // button2
            // 
            button2.Location = new Point(1238, 719);
            button2.Name = "button2";
            button2.Size = new Size(106, 32);
            button2.TabIndex = 59;
            button2.Text = "Chọn ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(1547, 708);
            button6.Name = "button6";
            button6.Size = new Size(319, 50);
            button6.TabIndex = 60;
            button6.Text = "Hoàn Thành Hóa Đơn";
            button6.UseVisualStyleBackColor = true;
            // 
            // fHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2032, 968);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(domainUpDown1);
            Controls.Add(label9);
            Controls.Add(listView3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Name = "fHoaDon";
            Text = "fHoaDon";
            Load += fHoaDon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button button5;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button3;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listView2;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private ListView listView3;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private Label label9;
        private DomainUpDown domainUpDown1;
        private Button button2;
        private Button button6;
    }
}