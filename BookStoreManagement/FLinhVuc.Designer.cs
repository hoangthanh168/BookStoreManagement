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
			lVLinhVuc.Size = new Size(657, 268);
			lVLinhVuc.TabIndex = 0;
			lVLinhVuc.UseCompatibleStateImageBehavior = false;
			lVLinhVuc.UseWaitCursor = true;
			lVLinhVuc.View = View.SmallIcon;
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
			// FLinhVuc
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lVLinhVuc);
			Name = "FLinhVuc";
			Text = "FLinhVuc";
			ResumeLayout(false);
		}

		#endregion

		private ListView lVLinhVuc;
		private ColumnHeader columnHeader1;
		private ImageList icon;
		private ImageList icon1;
	}
}