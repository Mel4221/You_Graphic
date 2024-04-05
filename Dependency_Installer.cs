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
using QuickTools.QCore;
using QuickTools.QData;
using QuickTools.QNet;

namespace You_Graphic
{
	public partial class Dependency_Installer : Form
	{
		
	 
		/*WORKER AREA STARTS*/
		private void StartReportLoop()
		{
			new Thread(() =>
			{
				while (this.IsReporting)
				{
					if (IsInitialBase)
					{
						this.TextStatus =  Manager.CurrentTextStatus;
						this.IntStatus =  Manager.CurrentIntStatus;
					}
						Get.WaitTime(300);
				}
			}).Start();
		}
		private bool IsReporting { get; set; } = false;
		private string TextStatus { get; set; } = null;
		private bool IsInitialBase { get; set; } = true;
		private int IntStatus {get;set;} = 0;
		private static DownloadManager Manager { get; set; } = new DownloadManager();
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
			}
		}
		private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{

			this.ProgressBar.Value = 0;
			//this.CurrentStatus.Text = "";
			this.CurrentAction = null;
			this.Hide();
			new You_Graphic().Show();
		}
		/*WORKER AREA ENDS*/
		public Dependency_Installer()
		{
			InitializeComponent();
		}
		//https://www.python.org/ftp/python/3.11.9/python-3.11.9-amd64.exe
		private string PythonLink = "https://www.python.org/ftp/python/3.11.9/python-3.11.9-amd64.exe";
		private string[] PipDependencys = new string[]{"pytube", "regex" , "validators" , "moviepy" };
		private string PythonD = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}{Get.Slash()}python.exe";
		private Thread ReportThread;
 		private void DownloadPython()
		{

			QSettings setting = new QSettings("You.config");
			if (setting.GetSetting("FULLY-INSTALLED") == "TRUE")
			{
				this.CurrentAction = (BackgroundWorker worker) =>
				{
 				};
				this.Worker.RunWorkerAsync();
				return;
			}


			this.CurrentAction = (BackgroundWorker worker) =>
			{
				
				string pythonD = PythonD;
				this.IsReporting = true;
				this.StartReportLoop();
				this.ReportThread = new Thread(() => { while (this.IsReporting) { worker.ReportProgress(0); Get.WaitTime(100); } });
					this.ReportThread.Start();

					Manager.AllowDebugger = true;
					Manager.DownloadFile(PythonLink, pythonD);

					this.IsInitialBase = false;
					this.TextStatus = "INSTALLING PYTHON";
					this.IntStatus = 100;
					Get.WaitTime(5000);

					ProcessStartInfo info = new ProcessStartInfo();
					info.FileName = this.PythonD;
					Process process = Process.Start(info);
					process.WaitForExit();

					this.IntStatus = 0;
					this.IntStatus = IRandom.RandomInt(25, 100);
					this.TextStatus = "ALMOST DONE";
					Get.WaitTime(5000);
					InstallPips(ref worker);
				 
			};
			this.Worker.RunWorkerAsync();
		}
		private void InstallPips(ref BackgroundWorker worker)
		{
		 
				for (int pip = 0; pip < this.PipDependencys.Length; pip++)
				{
					this.TextStatus = $"installing: [{this.PipDependencys[pip]}]";
					this.IntStatus = Get.StatusNumber(pip, this.PipDependencys.Length);
					worker.ReportProgress(0);
					ProcessStartInfo info = new ProcessStartInfo();
					info.FileName = "pip";
					info.Arguments = $"install {this.PipDependencys[pip]}";
					Process process = Process.Start(info);
					process.WaitForExit();
					Get.WaitTime(5000);
				}
				this.TextStatus = "ALL PACKAGES HAS BEEN INSTALLED SUCESSFULLY!!!";
			 
				if(File.Exists(this.PythonD) && !Get.IsFileBusy(this.PythonD))File.Delete(this.PythonD);
				 
				QSettings setting = new QSettings("You.config");
				setting.Create();
				setting.AddSetting("USER-NAME", Environment.UserName);
				setting.AddSetting("FULLY-INSTALLED", "TRUE");
				worker.ReportProgress(0);
				this.IsReporting = false;
				Get.WaitTime(5000);
			


		}
		private void InstallDependencys()
		{
			this.Show();
			this.Focus();
			this.DownloadPython();
			//MessageBox.Show($"{Tools.GetPythonVersion().ToLower() != "Python 3.12.1".ToLower()}");
		}
		private void Dependency_Installer_Load(object sender, EventArgs e)
		{
			this.InstallDependencys();
		}
	}
}
