namespace BookStoreManagement
{
    partial class fXoaSach
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "SAO348", "Tieng anh 12", "Nguyen Van Nam" }, -1);
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnXoaSach = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(27, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(765, 373);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "MÃ SÁCH";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "TÊN SÁCH";
            columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "TÊN TÁC GIẢ";
            columnHeader3.Width = 180;
            // 
            // btnXoaSach
            // 
            btnXoaSach.Location = new Point(46, 409);
            btnXoaSach.Name = "btnXoaSach";
            btnXoaSach.Size = new Size(225, 29);
            btnXoaSach.TabIndex = 1;
            btnXoaSach.Text = "XÓA SÁCH";
            btnXoaSach.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(526, 409);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(225, 29);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // fXoaSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoaSach);
            Controls.Add(listView1);
            Name = "fXoaSach";
            Text = "XÓA SÁCH";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnXoaSach;
        private Button btnThoat;
    }
}