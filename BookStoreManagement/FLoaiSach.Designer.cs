namespace BookStoreManagement
{
	partial class FLoaiSach
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
			ListViewItem listViewItem1 = new ListViewItem("Sách Tiếng Việt");
			ListViewItem listViewItem2 = new ListViewItem("Sách Tiếng Anh");
			ListViewItem listViewItem3 = new ListViewItem("Sách Tiếng Pháp");
			comboBox1 = new ComboBox();
			btnXoaLV = new Button();
			btnThemLV = new Button();
			textBox1 = new TextBox();
			lbXoaLS = new Label();
			lbThemLS = new Label();
			lVLoaiSach = new ListView();
			columnHeader1 = new ColumnHeader();
			SuspendLayout();
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(239, 386);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(311, 28);
			comboBox1.TabIndex = 11;
			// 
			// btnXoaLV
			// 
			btnXoaLV.FlatAppearance.BorderColor = Color.Gray;
			btnXoaLV.FlatAppearance.BorderSize = 2;
			btnXoaLV.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnXoaLV.Location = new Point(622, 384);
			btnXoaLV.Name = "btnXoaLV";
			btnXoaLV.Size = new Size(123, 28);
			btnXoaLV.TabIndex = 9;
			btnXoaLV.Text = "Xóa ";
			btnXoaLV.UseVisualStyleBackColor = true;
			// 
			// btnThemLV
			// 
			btnThemLV.FlatAppearance.BorderColor = Color.Blue;
			btnThemLV.FlatAppearance.BorderSize = 2;
			btnThemLV.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnThemLV.Location = new Point(622, 330);
			btnThemLV.Name = "btnThemLV";
			btnThemLV.Size = new Size(123, 28);
			btnThemLV.TabIndex = 10;
			btnThemLV.Text = "Thêm";
			btnThemLV.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(239, 334);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(313, 27);
			textBox1.TabIndex = 8;
			// 
			// lbXoaLS
			// 
			lbXoaLS.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbXoaLS.Location = new Point(55, 386);
			lbXoaLS.Name = "lbXoaLS";
			lbXoaLS.Size = new Size(151, 28);
			lbXoaLS.TabIndex = 6;
			lbXoaLS.Text = "Xóa loại sách :";
			// 
			// lbThemLS
			// 
			lbThemLS.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbThemLS.Location = new Point(55, 333);
			lbThemLS.Name = "lbThemLS";
			lbThemLS.Size = new Size(178, 28);
			lbThemLS.TabIndex = 7;
			lbThemLS.Text = "Thêm loại sách :";
			// 
			// lVLoaiSach
			// 
			lVLoaiSach.BackColor = SystemColors.HighlightText;
			lVLoaiSach.BackgroundImageTiled = true;
			lVLoaiSach.CheckBoxes = true;
			lVLoaiSach.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
			lVLoaiSach.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lVLoaiSach.ForeColor = SystemColors.HotTrack;
			lVLoaiSach.GridLines = true;
			listViewItem1.StateImageIndex = 0;
			listViewItem2.StateImageIndex = 0;
			listViewItem3.StateImageIndex = 0;
			lVLoaiSach.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
			lVLoaiSach.Location = new Point(55, 36);
			lVLoaiSach.Name = "lVLoaiSach";
			lVLoaiSach.RightToLeft = RightToLeft.Yes;
			lVLoaiSach.Size = new Size(690, 268);
			lVLoaiSach.TabIndex = 5;
			lVLoaiSach.UseCompatibleStateImageBehavior = false;
			lVLoaiSach.UseWaitCursor = true;
			lVLoaiSach.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Danh sách các loại sách";
			columnHeader1.Width = 300;
			// 
			// FLoaiSach
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(comboBox1);
			Controls.Add(btnXoaLV);
			Controls.Add(btnThemLV);
			Controls.Add(textBox1);
			Controls.Add(lbXoaLS);
			Controls.Add(lbThemLS);
			Controls.Add(lVLoaiSach);
			Name = "FLoaiSach";
			Text = "FLoaiSach";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox comboBox1;
		private Button btnXoaLV;
		private Button btnThemLV;
		private TextBox textBox1;
		private Label lbXoaLS;
		private Label lbThemLS;
		private ListView lVLoaiSach;
		private ColumnHeader columnHeader1;
	}
}