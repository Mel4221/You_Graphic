namespace You_Graphic
{
	partial class You_Graphic
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(You_Graphic));
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.CurrentStatus = new System.Windows.Forms.Label();
			this.Worker = new System.ComponentModel.BackgroundWorker();
			this.Video_Description = new System.Windows.Forms.Label();
			this.LinksBox = new System.Windows.Forms.RichTextBox();
			this.Y = new System.Windows.Forms.TrackBar();
			this.DownloadBtn = new System.Windows.Forms.Button();
			this.Format = new System.Windows.Forms.ComboBox();
			this.X = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.TempPicturesBox = new System.Windows.Forms.PictureBox();
			this.ClearBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Y)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TempPicturesBox)).BeginInit();
			this.SuspendLayout();
			// 
			// ProgressBar
			// 
			this.ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ProgressBar.Location = new System.Drawing.Point(0, 791);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(1823, 44);
			this.ProgressBar.TabIndex = 3;
			// 
			// CurrentStatus
			// 
			this.CurrentStatus.AutoSize = true;
			this.CurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CurrentStatus.ForeColor = System.Drawing.Color.White;
			this.CurrentStatus.Location = new System.Drawing.Point(31, 631);
			this.CurrentStatus.Name = "CurrentStatus";
			this.CurrentStatus.Size = new System.Drawing.Size(0, 32);
			this.CurrentStatus.TabIndex = 4;
			// 
			// Worker
			// 
			this.Worker.WorkerReportsProgress = true;
			this.Worker.WorkerSupportsCancellation = true;
			this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
			this.Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Worker_ProgressChanged);
			this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
			// 
			// Video_Description
			// 
			this.Video_Description.AutoSize = true;
			this.Video_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Video_Description.ForeColor = System.Drawing.Color.White;
			this.Video_Description.Location = new System.Drawing.Point(12, 663);
			this.Video_Description.Name = "Video_Description";
			this.Video_Description.Size = new System.Drawing.Size(0, 22);
			this.Video_Description.TabIndex = 7;
			// 
			// LinksBox
			// 
			this.LinksBox.AcceptsTab = true;
			this.LinksBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.LinksBox.EnableAutoDragDrop = true;
			this.LinksBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LinksBox.ForeColor = System.Drawing.Color.Blue;
			this.LinksBox.Location = new System.Drawing.Point(691, 195);
			this.LinksBox.Name = "LinksBox";
			this.LinksBox.Size = new System.Drawing.Size(907, 435);
			this.LinksBox.TabIndex = 1;
			this.LinksBox.TabStop = false;
			this.LinksBox.Text = "";
			// 
			// Y
			// 
			this.Y.Location = new System.Drawing.Point(1719, 396);
			this.Y.Name = "Y";
			this.Y.Size = new System.Drawing.Size(104, 69);
			this.Y.TabIndex = 9;
			this.Y.Visible = false;
			// 
			// DownloadBtn
			// 
			this.DownloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.DownloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DownloadBtn.Location = new System.Drawing.Point(691, 640);
			this.DownloadBtn.Name = "DownloadBtn";
			this.DownloadBtn.Size = new System.Drawing.Size(733, 45);
			this.DownloadBtn.TabIndex = 2;
			this.DownloadBtn.Text = "Download";
			this.DownloadBtn.UseVisualStyleBackColor = false;
			this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
			// 
			// Format
			// 
			this.Format.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Format.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Format.FormattingEnabled = true;
			this.Format.Items.AddRange(new object[] {
            "MP3",
            "MP4 720P",
            "MP4 1080P"});
			this.Format.Location = new System.Drawing.Point(1430, 640);
			this.Format.Name = "Format";
			this.Format.Size = new System.Drawing.Size(168, 37);
			this.Format.TabIndex = 5;
			this.Format.Text = "MP3";
			// 
			// X
			// 
			this.X.Location = new System.Drawing.Point(1719, 285);
			this.X.Name = "X";
			this.X.Size = new System.Drawing.Size(104, 69);
			this.X.TabIndex = 8;
			this.X.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(1053, 147);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Video Link\'s";
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1823, 25);
			this.toolStrip1.TabIndex = 10;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// TempPicturesBox
			// 
			this.TempPicturesBox.Image = ((System.Drawing.Image)(resources.GetObject("TempPicturesBox.Image")));
			this.TempPicturesBox.Location = new System.Drawing.Point(37, 182);
			this.TempPicturesBox.Name = "TempPicturesBox";
			this.TempPicturesBox.Size = new System.Drawing.Size(616, 448);
			this.TempPicturesBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.TempPicturesBox.TabIndex = 11;
			this.TempPicturesBox.TabStop = false;
			// 
			// ClearBtn
			// 
			this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClearBtn.Location = new System.Drawing.Point(1604, 195);
			this.ClearBtn.Name = "ClearBtn";
			this.ClearBtn.Size = new System.Drawing.Size(78, 435);
			this.ClearBtn.TabIndex = 12;
			this.ClearBtn.Text = "Clear";
			this.ClearBtn.UseVisualStyleBackColor = false;
			this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
			// 
			// You_Graphic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1823, 835);
			this.Controls.Add(this.ClearBtn);
			this.Controls.Add(this.TempPicturesBox);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.Y);
			this.Controls.Add(this.X);
			this.Controls.Add(this.Video_Description);
			this.Controls.Add(this.Format);
			this.Controls.Add(this.CurrentStatus);
			this.Controls.Add(this.ProgressBar);
			this.Controls.Add(this.DownloadBtn);
			this.Controls.Add(this.LinksBox);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "You_Graphic";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "You";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.You_Graphic_Load);
			this.Resize += new System.EventHandler(this.You_Graphic_Resize);
			((System.ComponentModel.ISupportInitialize)(this.Y)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TempPicturesBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.Label CurrentStatus;
		private System.ComponentModel.BackgroundWorker Worker;
		private System.Windows.Forms.Label Video_Description;
		private System.Windows.Forms.RichTextBox LinksBox;
		private System.Windows.Forms.TrackBar Y;
		private System.Windows.Forms.Button DownloadBtn;
		private System.Windows.Forms.ComboBox Format;
		private System.Windows.Forms.TrackBar X;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.PictureBox TempPicturesBox;
		private System.Windows.Forms.Button ClearBtn;
	}
}

