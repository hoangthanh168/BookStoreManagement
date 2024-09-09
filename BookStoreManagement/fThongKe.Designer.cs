namespace BookStoreManagement
{
    partial class fThongKe
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "HD0170", "Khach Hang 1", "9/9/2024 12:00:00 AM", "37.000" }, -1);
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(331, 28);
            dateTimePicker2.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(184, 25);
            dateTimePicker2.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(261, 33);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 17);
            label8.TabIndex = 56;
            label8.Text = "Đến Ngày";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(73, 28);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(184, 25);
            dateTimePicker1.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 58;
            label1.Text = "Từ Ngày";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(519, 27);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(106, 26);
            button1.TabIndex = 60;
            button1.Text = "Tìm Kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(11, 69);
            listView1.Margin = new Padding(2, 2, 2, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(614, 275);
            listView1.TabIndex = 61;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(409, 348);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(106, 26);
            button2.TabIndex = 62;
            button2.Text = "Xóa Báo Cáo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(519, 348);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(106, 26);
            button3.TabIndex = 63;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // fThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 380);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label8);
            Margin = new Padding(2, 2, 2, 2);
            Name = "fThongKe";
            Text = "fThongKe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button2;
        private Button button3;
    }
}