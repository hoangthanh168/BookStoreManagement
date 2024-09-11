namespace BookStoreManagement
{
	partial class FXoaTG
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
            btnXoaTG = new Button();
            btnThoat = new Button();
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
            listView1.Size = new Size(614, 276);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // btnXoaTG
            // 
            btnXoaTG.FlatAppearance.BorderColor = Color.Silver;
            btnXoaTG.FlatAppearance.BorderSize = 5;
            btnXoaTG.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnXoaTG.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnXoaTG.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaTG.Location = new Point(415, 292);
            btnXoaTG.Name = "btnXoaTG";
            btnXoaTG.Size = new Size(101, 30);
            btnXoaTG.TabIndex = 2;
            btnXoaTG.Text = "Xóa Tác giả";
            btnXoaTG.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.FlatAppearance.BorderColor = Color.Navy;
            btnThoat.FlatAppearance.BorderSize = 5;
            btnThoat.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnThoat.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnThoat.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(522, 292);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(102, 30);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // FXoaTG
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 331);
            Controls.Add(btnThoat);
            Controls.Add(btnXoaTG);
            Controls.Add(listView1);
            Name = "FXoaTG";
            Text = "FXoaTG";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
		private ColumnHeader TênTG;
		private ColumnHeader QQ;
		private ColumnHeader NSinh;
		private ColumnHeader SMat;
		private Button btnXoaTG;
		private Button btnThoat;
	}
}