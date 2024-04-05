namespace You_Graphic
{
	partial class Dependency_Installer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dependency_Installer));
			this.StatusLabel = new System.Windows.Forms.Label();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.Worker = new System.ComponentModel.BackgroundWorker();
			this.CurrentStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// StatusLabel
			// 
			this.StatusLabel.AutoSize = true;
			this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StatusLabel.ForeColor = System.Drawing.Color.White;
			this.StatusLabel.Location = new System.Drawing.Point(139, 9);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(607, 32);
			this.StatusLabel.TabIndex = 5;
			this.StatusLabel.Text = "Downloading some dependencys please wait...";
			// 
			// ProgressBar
			// 
			this.ProgressBar.Location = new System.Drawing.Point(1, 145);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(838, 35);
			this.ProgressBar.TabIndex = 6;
			// 
			// Worker
			// 
			this.Worker.WorkerReportsProgress = true;
			this.Worker.WorkerSupportsCancellation = true;
			this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
			this.Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Worker_ProgressChanged);
			this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
			// 
			// CurrentStatus
			// 
			this.CurrentStatus.AutoSize = true;
			this.CurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CurrentStatus.ForeColor = System.Drawing.Color.White;
			this.CurrentStatus.Location = new System.Drawing.Point(12, 116);
			this.CurrentStatus.Name = "CurrentStatus";
			this.CurrentStatus.Size = new System.Drawing.Size(261, 22);
			this.CurrentStatus.TabIndex = 7;
			this.CurrentStatus.Text = "CurrentStatus: NOT STARTED";
			// 
			// Dependency_Installer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(841, 183);
			this.Controls.Add(this.CurrentStatus);
			this.Controls.Add(this.ProgressBar);
			this.Controls.Add(this.StatusLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Dependency_Installer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DependencyInstaller";
			this.Load += new System.EventHandler(this.Dependency_Installer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label StatusLabel;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.ComponentModel.BackgroundWorker Worker;
		private System.Windows.Forms.Label CurrentStatus;
	}
}