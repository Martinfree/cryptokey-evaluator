using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptokey_evaluator
{
    class AppThread
    {
		System.Diagnostics.Process App;
		string Result = "";
		public AppThread(string FileName, string AppName, string args )
		{
			App = new System.Diagnostics.Process();
			App.StartInfo.FileName = FileName;
			App.StartInfo.Arguments = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Release\\net5.0-windows", "").Replace("\\", "/") + AppName + args;
			App.StartInfo.RedirectStandardInput = true;
			App.StartInfo.RedirectStandardOutput = true;
			App.StartInfo.CreateNoWindow = true;
			App.StartInfo.UseShellExecute = false;

		}
		public AppThread(bool external,string FileName, string AppName, string args)
		{
			
			//App = new System.Diagnostics.Process();
			//App.StartInfo.FileName = FileName;
			//App.StartInfo.Arguments = AppName + args;
			//App.StartInfo.UseShellExecute = false;
			///App.StartInfo.EnvironmentVariables.Add("RedirectStandardOutput", "true");
			///App.StartInfo.EnvironmentVariables.Add("RedirectStandardError", "true");
			///App.StartInfo.EnvironmentVariables.Add("UseShellExecute", "false");
			//App.StartInfo.EnvironmentVariables.Add("CreateNoWindow", "true");
			//App.StartInfo.UseShellExecute = false;

		}
		public AppThread(bool browser, string url)
		{
			App = new System.Diagnostics.Process();
			App.StartInfo.FileName = "explorer";
			App.StartInfo.Arguments = url;
			App.StartInfo.RedirectStandardOutput = true;
			App.Start();
		}
		public string Exec()
		{
            
			App.Start();
			//App.WaitForExit();
			Result = App.StandardOutput.ReadToEnd();
			return Result;
		}
		public void CreateFile(string str, string name)
		{
			System.IO.StreamWriter file = new (name);
			file.Write(str);
			file.Close();
			//return System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug\\net5.0-windows", "").Replace("\\", "/") + name;
		}
		public void DeleteFile(string name)
		{
			System.IO.File.Delete(System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug\\net5.0-windows", "").Replace("\\", "/") + name);
		}
	};
}
