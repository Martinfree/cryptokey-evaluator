using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptokey_evaluator
{
    
    public partial class Form1 : Form
    {
        string ApiProcessExec(Process proc, string args) 
        {
            proc.StartInfo.FileName = "powershell.exe ";
            proc.StartInfo.Arguments = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug\\net5.0-windows", "").Replace("\\", "/") + "api.exe " + args;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
          
            proc.Start();
            proc.WaitForExit();
            return proc.StandardOutput.ReadToEnd();
        }

        string CopyFromTo(string str, string from, string to)
        {
            string res = str.Substring(str.IndexOf(from) + from.Length, str.IndexOf(to) - str.IndexOf(from) - to.Length - 6);
            
            return res;
        }
        void TreeView_Writer(int parent_count,int child_count, string str, string local_word)
        {

            ResultTreeView.Nodes[parent_count].Nodes.Add(local_word);

            switch (str)
            {
                case "":
                    ResultTreeView.Nodes[parent_count].Nodes[child_count].Nodes.Add("<None>");
                    break;
                default:
                    ResultTreeView.Nodes[parent_count].Nodes[child_count].Nodes.Add(str);
                    break;
            }


        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void VersionlinkLabel_Click(object sender, EventArgs e)
        {
            
            BrowserProcess = new Process();
            BrowserProcess.StartInfo.FileName = "explorer";
            BrowserProcess.StartInfo.Arguments = "https://github.com/Martinfree/cryptokey-evaluator/";
            BrowserProcess.Start();
            
        }

        private void PowerShellListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PowerShellTextBox_Click(object sender, EventArgs e)
        {

        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            string FormatCheck;
            string FastCheck;

            if (CypherTextBox.Text == "") return;
            

            FastCheck = ApiProcessExec(ApiProcess, "-fast " + CypherTextBox.Text.Replace(" ","") + " " + SecretKeyTextBox.Text.Replace(" ", ""));
            //PowerShellTextBox.Text = "Result: " + FastCheck;        
            
            PowerShellTextBox.Text = ApiProcess.ExitCode.ToString();
            FormatCheck = ApiProcessExec(ApiProcess, "-f " + CypherTextBox.Text);
            //PowerShellTextBox.Text = ApiProcess.ExitCode.ToString();
            
            int a = ResultTreeView.Nodes.Add(CypherTextBox.Text).Index;
            TreeView_Writer(a, 0, CopyFromTo(FormatCheck, "Possible algorithms:", "Info about Key:"), "Алгоритми");
            TreeView_Writer(a, 1, OpenKeyTextBox.Text, "відкритий ключ");
            TreeView_Writer(a, 2, SecretKeyTextBox.Text, "таємний ключ");
            ResultTreeView.Nodes[a].Nodes[2].Nodes.Add(
                FastCheck
                );
            
            
        }

        private void SecretKeyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SecretKeyTextBox.Enabled = SecretKeyCheckBox.Checked;
        }

        private void OpenKeyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OpenKeyTextBox.Enabled = OpenKeyCheckBox.Checked;
        }

        private void HashCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OpenKeyTextBox.Enabled = !HashCheckBox.Checked;
            OpenKeyCheckBox.Enabled = !HashCheckBox.Checked;
            SecretKeyTextBox.Enabled = !HashCheckBox.Checked;
            SecretKeyCheckBox.Enabled = !HashCheckBox.Checked;

        }
    }
}
