using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickTools.QCore;

namespace You_Graphic
{
	internal class Tools
	{
		public static string GetPythonVersion()
		{
			ProcessStartInfo start = new ProcessStartInfo();
			start.FileName = @"python"; // Specify exe name.
			start.Arguments = "--version";
			start.UseShellExecute = true;
			start.RedirectStandardOutput = true;
			start.UseShellExecute = false;
			//start.RedirectStandardError = true;
			start.CreateNoWindow = false;
			string input = "";
			using (Process process = Process.Start(start))
			{
				
				using (StreamReader reader = process.StandardOutput)
				{
				
					input = reader.ReadToEnd();	
				}
				process.WaitForExit();

			}
			//3.12.1
			input = input.Substring(input.IndexOf("3"));
			return input;
		}
	}
}
