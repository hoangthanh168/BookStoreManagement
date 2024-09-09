namespace BookStoreManagement
{
	partial class FLinhVuc
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
			components = new System.ComponentModel.Container();
			ListViewItem listViewItem1 = new ListViewItem("Sach giáo khoa", 0);
			ListViewItem listViewItem2 = new ListViewItem("Sách tham khảo", 2);
			ListViewItem listViewItem3 = new ListViewItem("Sách giải trí", 1);
			ListViewItem listViewItem4 = new ListViewItem("Sách khoa học", 3);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLinhVuc));
			lVLinhVuc = new ListView();
			columnHeader1 = new ColumnHeader();
			icon = new ImageList(components);
			icon1 = new ImageList(components);
			lbThemLV = new Label();
			textBox1 = new TextBox();
			btnThemLV = new Button();
			lbXoaLV = new Label();
			btnXoaLV = new Button();
			comboBox1 = new ComboBox();
			SuspendLayout();
			// 
			// lVLinhVuc
			// 
			lVLinhVuc.BackColor = SystemColors.HighlightText;
			lVLinhVuc.BackgroundImageTiled = true;
			lVLinhVuc.CheckBoxes = true;
			lVLinhVuc.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
			lVLinhVuc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lVLinhVuc.ForeColor = SystemColors.HotTrack;
			lVLinhVuc.GridLines = true;
			listViewItem1.StateImageIndex = 0;
			listViewItem2.StateImageIndex = 0;
			listViewItem3.StateImageIndex = 0;
			listViewItem4.StateImageIndex = 0;
			lVLinhVuc.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
			lVLinhVuc.LargeImageList = icon;
			lVLinhVuc.Location = new Point(63, 30);
			lVLinhVuc.Name = "lVLinhVuc";
			lVLinhVuc.RightToLeft = RightToLeft.Yes;
			lVLinhVuc.Size = new Size(690, 268);
			lVLinhVuc.TabIndex = 0;
			lVLinhVuc.UseCompatibleStateImageBehavior = false;
			lVLinhVuc.UseWaitCursor = true;
			lVLinhVuc.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Danh sách các lĩnh vực  sách ";
			columnHeader1.Width = 300;
			// 
			// icon
			// 
			icon.ColorDepth = ColorDepth.Depth32Bit;
			icon.ImageStream = (ImageListStreamer)resources.GetObject("icon.ImageStream");
			icon.TransparentColor = Color.Transparent;
			icon.Images.SetKeyName(0, "sgk.jpg");
			icon.Images.SetKeyName(1, "gtt.png");
			icon.Images.SetKeyName(2, "thamkhao.png");
			icon.Images.SetKeyName(3, "kh.jpg");
			// 
			// icon1
			// 
			icon1.ColorDepth = ColorDepth.Depth32Bit;
			icon1.ImageStream = (ImageListStreamer)resources.GetObject("icon1.ImageStream");
			icon1.TransparentColor = Color.Transparent;
			icon1.Images.SetKeyName(0, "sgk.jpg");
			icon1.Images.SetKeyName(1, "gtt.png");
			icon1.Images.SetKeyName(2, "thamkhao.png");
			icon1.Images.SetKeyName(3, "kh.jpg");
			// 
			// lbThemLV
			// 
			lbThemLV.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbThemLV.Location = new Point(63, 327);
			lbThemLV.Name = "lbThemLV";
			lbThemLV.Size = new Size(158, 28);
			lbThemLV.TabIndex = 1;
			lbThemLV.Text = "Thêm lĩnh vực :";
			lbThemLV.Click += label1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(227, 328);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(313, 27);
			textBox1.TabIndex = 2;
			// 
			// btnThemLV
			// 
			btnThemLV.FlatAppearance.BorderColor = Color.Blue;
			btnThemLV.FlatAppearance.BorderSize = 2;
			btnThemLV.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnThemLV.Location = new Point(630, 324);
			btnThemLV.Name = "btnThemLV";
			btnThemLV.Size = new Size(123, 28);
			btnThemLV.TabIndex = 3;
			btnThemLV.Text = "Thêm";
			btnThemLV.UseVisualStyleBackColor = true;
			btnThemLV.Click += button1_Click;
			// 
			// lbXoaLV
			// 
			lbXoaLV.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbXoaLV.Location = new Point(63, 380);
			lbXoaLV.Name = "lbXoaLV";
			lbXoaLV.Size = new Size(151, 28);
			lbXoaLV.TabIndex = 1;
			lbXoaLV.Text = "Xóa lĩnh vực :";
			lbXoaLV.Click += label1_Click;
			// 
			// btnXoaLV
			// 
			btnXoaLV.FlatAppearance.BorderColor = Color.Gray;
			btnXoaLV.FlatAppearance.BorderSize = 2;
			btnXoaLV.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnXoaLV.Location = new Point(630, 378);
			btnXoaLV.Name = "btnXoaLV";
			btnXoaLV.Size = new Size(123, 28);
			btnXoaLV.TabIndex = 3;
			btnXoaLV.Text = "Xóa ";
			btnXoaLV.UseVisualStyleBackColor = true;
			btnXoaLV.Click += button1_Click;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(227, 380);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(311, 28);
			comboBox1.TabIndex = 4;
			// 
			// FLinhVuc
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(comboBox1);
			Controls.Add(btnXoaLV);
			Controls.Add(btnThemLV);
			Controls.Add(textBox1);
			Controls.Add(lbXoaLV);
			Controls.Add(lbThemLV);
			Controls.Add(lVLinhVuc);
			Name = "FLinhVuc";
			Text = "FLinhVuc";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListView lVLinhVuc;
		private ColumnHeader columnHeader1;
		private ImageList icon;
		private ImageList icon1;
		private Label lbThemLV;
		private TextBox textBox1;
		private Button btnThemLV;
		private Label lbXoaLV;
		private Button btnXoaLV;
		private ComboBox comboBox1;
	}
}