using QuickTools.QCore;
using QuickTools.QData;
using QuickTools.QNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace You_Graphic
{
	public partial class You_Graphic : Form
	{       /*WORKER AREA STARTS*/
	 
		private bool IsReporting { get; set; } = false;
		private string TextStatus { get; set; } = null;
		private bool IsInitialBase { get; set; } = true;
		private int IntStatus { get; set; } = 0;
 
		private Action<BackgroundWorker> CurrentAction { get; set; } = null;
		private void Worker_DoWork(object sender, DoWorkEventArgs e)
		{
			if (this.CurrentAction != null)
			{
				this.CurrentAction(this.Worker);
			}
		}

		private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{

			if (this.ProgressBar.Value < this.ProgressBar.Maximum)
			{
				this.ProgressBar.Value = this.IntStatus;
				this.CurrentStatus.Text = this.TextStatus;
				this.Text = this.TextStatus;
			}
		}
		private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{

			this.ProgressBar.Value = 0;
			this.CurrentStatus.Text = "";
			this.Text = "You";
			this.CurrentAction = null;
			
			MessageBox.Show("Downloaded Completed!!!");
		}
		/*WORKER AREA ENDS*/
		public You_Graphic()
		{
			InitializeComponent();
		}
		string YouPath = $"You{Get.Slash()}you.py";
		/*
				type link download-location	
		 */
		private string[] Links;
		private string GetType(string type)
		{
			if(type.Contains(" "))
			{
				return type.Replace(" ", "_");
			}	else{
				return type;
			}
		}
		private List<string> Temps;
		private char ch = '\\';
		 private char Osilate()
		 {
			switch(ch)
			{
				case '\\':
					ch = '|';
					break;
				case '|':
					ch = '/';
					break;
				case '/':
					ch = '-';
					break;
				case '-':
					ch = '\\';
					break; 
			}
			return ch;
		 }
		
		private void DownloadBtn_Click(object sender, EventArgs e)
		{
			if (this.CurrentAction != null) 
			{
				MessageBox.Show("Download already in progress...");
				return;
			}
			this.Links = this.LinksBox.Lines;
			string type, link, download_location, tempId;
			Print.List(this.Links);
			QSettings settings = new QSettings("You.config");
			this.Temps = new List<string>();
			string path = settings.GetSetting("DOWNLOAD-LOCATION");
			if(string.IsNullOrEmpty(path)) 
			{
					FolderBrowserDialog dialog = new FolderBrowserDialog();
 					DialogResult result = dialog.ShowDialog();
					path = dialog.SelectedPath;
					if (result != DialogResult.OK) return;
					settings.AddSetting("DOWNLOAD-LOCATION", dialog.SelectedPath);
			}
			type = this.GetType(this.Format.Text);
			
			download_location = path;

			this.IsReporting = true;

			this.CurrentAction = ( BackgroundWorker worker) =>
			{
				new Thread(() => {
					while (this.IsReporting)
					{
						this.TextStatus = $"Please wait Downloading [{Osilate()}]";
						this.IntStatus = IRandom.RandomInt(0,100);//Get.StatusNumber(line, this.Links.Length);

						worker.ReportProgress(0);
						Get.WaitTime(250);
					}
				}).Start();
				for (int line =0; line  < this.Links.Length; line++)
				{
					
					//worker.ReportProgress(0);

					link = this.Links[line];
					tempId = IRandom.RandomText(8);

					if (!string.IsNullOrEmpty(link))
					{
						this.Temps.Add($"{download_location}{Get.Slash()}{tempId}.mp4");
						ProcessStartInfo info = new ProcessStartInfo();
						info.FileName = "python";
						info.Arguments = $"{this.YouPath} {type} {link} {download_location}{Get.Slash()} {tempId}";
						info.UseShellExecute = false;
						Process process = Process.Start(info);
						process.WaitForExit();
					}
				}
				this.Temps.ForEach((item) => { 
					if(!Get.IsFileBusy(item) && File.Exists(item))
					{
						File.Delete(item);
						Get.Red($"TEMP FILE DELETED: {item}");
					}
				});
				this.IsReporting = false;
			};
				this.Worker.RunWorkerAsync();
		}
	}
}
