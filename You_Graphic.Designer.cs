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
			this.label1 = new System.Windows.Forms.Label();
			this.LinksBox = new System.Windows.Forms.RichTextBox();
			this.DownloadBtn = new System.Windows.Forms.Button();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.CurrentStatus = new System.Windows.Forms.Label();
			this.Format = new System.Windows.Forms.ComboBox();
			this.Worker = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(534, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Video Link\'s";
			// 
			// LinksBox
			// 
			this.LinksBox.AcceptsTab = true;
			this.LinksBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.LinksBox.EnableAutoDragDrop = true;
			this.LinksBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LinksBox.ForeColor = System.Drawing.Color.Blue;
			this.LinksBox.Location = new System.Drawing.Point(196, 59);
			this.LinksBox.Name = "LinksBox";
			this.LinksBox.Size = new System.Drawing.Size(907, 435);
			this.LinksBox.TabIndex = 1;
			this.LinksBox.TabStop = false;
			this.LinksBox.Text = "";
			// 
			// DownloadBtn
			// 
			this.DownloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.DownloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DownloadBtn.Location = new System.Drawing.Point(1119, 59);
			this.DownloadBtn.Name = "DownloadBtn";
			this.DownloadBtn.Size = new System.Drawing.Size(132, 46);
			this.DownloadBtn.TabIndex = 2;
			this.DownloadBtn.Text = "Download";
			this.DownloadBtn.UseVisualStyleBackColor = false;
			this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
			// 
			// ProgressBar
			// 
			this.ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ProgressBar.Location = new System.Drawing.Point(-1, 668);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(1330, 34);
			this.ProgressBar.TabIndex = 3;
			// 
			// CurrentStatus
			// 
			this.CurrentStatus.AutoSize = true;
			this.CurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CurrentStatus.ForeColor = System.Drawing.Color.White;
			this.CurrentStatus.Location = new System.Drawing.Point(12, 633);
			this.CurrentStatus.Name = "CurrentStatus";
			this.CurrentStatus.Size = new System.Drawing.Size(0, 32);
			this.CurrentStatus.TabIndex = 4;
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
			this.Format.Location = new System.Drawing.Point(12, 59);
			this.Format.Name = "Format";
			this.Format.Size = new System.Drawing.Size(168, 37);
			this.Format.TabIndex = 5;
			this.Format.Text = "MP3";
			// 
			// Worker
			// 
			this.Worker.WorkerReportsProgress = true;
			this.Worker.WorkerSupportsCancellation = true;
			this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
			this.Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Worker_ProgressChanged);
			this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
			// 
			// You_Graphic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1694, 735);
			this.Controls.Add(this.Format);
			this.Controls.Add(this.CurrentStatus);
			this.Controls.Add(this.ProgressBar);
			this.Controls.Add(this.DownloadBtn);
			this.Controls.Add(this.LinksBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "You_Graphic";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "You";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox LinksBox;
		private System.Windows.Forms.Button DownloadBtn;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.Label CurrentStatus;
		private System.Windows.Forms.ComboBox Format;
		private System.ComponentModel.BackgroundWorker Worker;
	}
}

