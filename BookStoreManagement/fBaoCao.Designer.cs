namespace BookStoreManagement
{
    partial class fBaoCao
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
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "SA0348", "Tieng Anh 12", "8" }, -1);
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem6 });
            listView1.Location = new Point(38, 41);
            listView1.Name = "listView1";
            listView1.Size = new Size(877, 423);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            columnHeader3.Text = "Số Lượng Bán Ra";
            columnHeader3.Width = 200;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(38, 502);
            label9.Name = "label9";
            label9.Size = new Size(161, 28);
            label9.TabIndex = 58;
            label9.Text = "Tổng Doanh Thu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 557);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 59;
            label1.Text = "60000 VND ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(218, 502);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 60;
            label2.Text = "560000 VND";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 557);
            label3.Name = "label3";
            label3.Size = new Size(105, 28);
            label3.TabIndex = 61;
            label3.Text = "Lợi Nhuận:";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(763, 525);
            button3.Name = "button3";
            button3.Size = new Size(152, 38);
            button3.TabIndex = 64;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            // 
            // fBaoCao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 758);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(listView1);
            Name = "fBaoCao";
            Text = "fBaoCao";
            Load += this.fBaoCao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label9;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
    }
}