using QuickTools.QCore;
using QuickTools.QData;
using QuickTools.QIO;
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
	{    
		private string YouPath = $"You{Get.Slash()}you.py";
		private bool IsReporting { get; set; } = false;
		private string TextStatus { get; set; } = null;
		private bool IsInitialBase { get; set; } = true;
		private int IntStatus { get; set; } = 0;
		private bool InfoLoaded { get; set; } = false;
		private string InfoFile { get; set; } = null;
		private bool FailOrCompleted { get; set; } = false;
		private bool IsIconAvailable { get; set; } = false;
		private string IconPath { get; set; }
		//MUST BE INITIALIZE WITH A VALUE GRETER THAN THE AMOUNT OF METADA
		private string[] Video_Info { get; set; } = new string[124];
		private string Video_Icon_Url { get; set; } = null;
		//private bool IsDownloading = false;
		private bool IsUpdated = false;
		private PictureBox VideoIcon;
		private List<string> Temps;
		private bool isFisrstTime = true;
		private string[] Links;
		private char ch = '\\';
		/// <summary>
		/// defines the time elapsed by each thread loop
		/// </summary>
		private int LoopsSpeed = 250;
		/*WORKER AREA STARTS*/
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
			}if(this.FailOrCompleted && !string.IsNullOrEmpty(this.InfoFile))
			{
				this.Video_Description.Text = this.Video_Info[1];// this.QKeyManager.GetKey("VIDEO_TITLE").Value;
				//Get.Wait(this.Video_Icon);
				//Get.Red($"{this.Video_Icon_Url}");
				//prviusly it was either if is this.IsAvailable but i think it wont need it
				if (!IsUpdated && this.IsIconAvailable)
				{
					this.UpdateIcon();
					this.IsUpdated = true;
					
				
				}
			}
		}
		private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{

			this.ProgressBar.Value = 0;
			this.CurrentStatus.Text = "";
			this.Text = "You";
			this.CurrentAction = null;
			this.Controls.Remove(this.VideoIcon);
			this.Video_Description.Text = "";
			this.TempPicturesBox.Visible = true;
			MessageBox.Show("Downloaded Completed!!!");
		}
		/*WORKER AREA ENDS*/
		public You_Graphic()
		{
			InitializeComponent();
		}
		/*
				type link download-location	
		 */

		 private void DownloadIcon()
		 {
			new Thread(() => {
			 
			DownloadManager download = new DownloadManager();
			download.AllowDebugger = true; 
			download.DownloadFile(this.Video_Icon_Url,this.IconPath);
			while (true) { if (!Get.IsFileBusy(this.IconPath)) break; }
			this.IsIconAvailable = true;
			}).Start();
			

		}
	
		private string GetType(string type)
		{
			if(type.Contains(" "))
			{
				return type.Replace(" ", "_");
			}	else{
				return type;
			}
		}

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
		private bool IsInfoAvailable(ref string download_location,ref string tempId)
		{
			this.InfoFile = $"{download_location}{Get.Slash()}{tempId}.mp4.info";
			this.Temps.Add(this.InfoFile);
			bool exist, isBusy;
			exist = File.Exists(this.InfoFile);
			isBusy = Get.IsFileBusy(this.InfoFile);
			if(exist && !isBusy){ Get.Red($"FILE: [{this.InfoFile}] EXIST: [{exist}] ISBUSY: [{isBusy}]"); }
			return exist && !isBusy;
		}
		
		private void LoadInfo(ref string download_location, ref string tempId)
		{
			while(!this.FailOrCompleted)
			{
				if(this.IsInfoAvailable(ref download_location,ref tempId))
				{
					this.Video_Info = File.ReadAllLines(this.InfoFile);
					Print.List(this.Video_Info);
					this.FailOrCompleted = true;
					this.Video_Icon_Url = this.Video_Info[4];
					if (!string.IsNullOrEmpty(this.Video_Icon_Url))					this.DownloadIcon();
					this.DownloadIcon();
					break;
				}
				Get.WaitTime(this.LoopsSpeed);
			}
		}
	


		private void UpdateIcon()
		{
			int x, y;
			x = 420;
			y = 360;
			Get.Yellow("UPDATED ICON");
			if (!this.isFisrstTime)
			{
				this.Controls.Remove(this.VideoIcon);
			}
				this.VideoIcon = new PictureBox
				{
					Name =  IRandom.RandomText(14),

					Size = new Size(x, y),//X: 83 Y: 272
					Location = new Point(20,50),//(125, 331),//(this.X.Value, this.Y.Value),
					ImageLocation =this.IconPath,//@"C:\Users\Melquiceded\Documents\csharp\ClownShell\clown.ico",
					SizeMode = PictureBoxSizeMode.StretchImage,
					BorderStyle = BorderStyle.Fixed3D
				};
				this.Controls.Add(VideoIcon);
				this.IsUpdated = true;
				this.isFisrstTime = false;
				return;
			
		}
		 
		 
		private void ResetState()
		{
			Get.Red("STATE RESET");
			this.Video_Info = new string[124];
			this.FailOrCompleted = false;
			//this.IsDownloading = false;
			this.IsUpdated = false; 
		}
		private void DownloadBtn_Click(object sender, EventArgs e)
		{
			if (this.CurrentAction != null) 
			{
				MessageBox.Show("Download already in progress...");
				return;
			}
			TempPicturesBox.Visible = false; 
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
						Get.WaitTime(LoopsSpeed);
					}
				}).Start();
				for (int line =0; line  < this.Links.Length; line++)
				{
					
					//worker.ReportProgress(0);

					link = this.Links[line];
					tempId = IRandom.RandomText(8);
					this.IconPath = $"{download_location}{Get.Slash()}{IRandom.RandomText(8)}.jpg";

					new Thread(() => 
					{
						this.LoadInfo(ref download_location,ref tempId);
						Get.WaitTime(this.LoopsSpeed);
					}).Start();
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
					this.Temps.Add(this.IconPath);
					this.ResetState();
				}
				
				this.Temps.ForEach((item) => {
					while (Get.IsFileBusy(item)) { }
					
					if (File.Exists(item))
					{
						File.Delete(item);
						Get.Red($"TEMP FILE DELETED: {item}");
					}
				});
				this.IsReporting = false;
			};
				this.Worker.RunWorkerAsync();
		}

		private void X_ValueChanged(object sender, EventArgs e)
		{
			//this.UpdatePictures();
		}
		private void You_Graphic_Load(object sender, EventArgs e)
		{
			/*
			this.X.Maximum = this.Width;
			this.Y.Maximum = this.Height;
			this.UpdateIcon();
			*/
		}

		private void You_Graphic_Resize(object sender, EventArgs e)
		{
			CurrentStatus.Location = new Point(this.ProgressBar.Location.X, this.ProgressBar.Location.Y-40);
			Video_Description.Location = new Point(this.ProgressBar.Location.X, Video_Description.Location.Y);
		}
	}
}
