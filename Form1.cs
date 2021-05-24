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
        string Attack()
        {
            return "<None>";
        }
        string AnalyzePass(bool SecretFile, string secret)
        {
            string args = " --find-pass=";
            string args2 = " --fast-check ";

            if (!SecretFile) args += ".seckey";
            else args += secret;

            AppThread FindPass = new AppThread("powershell.exe ", "api.exe", args);
            AppThread FastCheck = new AppThread("powershell.exe ", "api.exe", args2);
            //FindFormat.CreateFile(CypherTextBox.Text, ".seckey");
            return FindPass.Exec() + FastCheck.Exec();
        }
        string FindFormat(bool HashFile, string hash)
        {
            string args = " --find-whoami=";
            if (!HashFile) args += ".hash";
            else args += hash;

            AppThread FindFormat = new AppThread("powershell.exe ", "api.exe", args);
            //FindFormat.CreateFile(CypherTextBox.Text, ".hash");
            return FindFormat.Exec();
        }
        string CrackingResistance(bool HashFile, bool SecretFile,string hash, string secret, string format)
        {

            string args = " --cracking-resistance ";
            if (!HashFile) args += "--hash-file=" + ".hash";
            else args += "--hash-file=" + hash;

            if (!SecretFile) args += " --secret-file " + ".seckey";
            else args += " --secret-file " + secret;
            if (format != "<None>") args += " --format=" + format;
            

            AppThread CrackingResistance = new AppThread("powershell.exe ", "api.exe", args);
            //CrackingResistance.CreateFile(CypherTextBox.Text, ".hash");
            //CrackingResistance.CreateFile(SecretKeyTextBox.Text, ".seckey");
            return CrackingResistance.Exec();
        }
        string CopyFromTo(string str, string from, string to)
        {
            if (str !="") return str.Substring(str.IndexOf(from) + from.Length, str.IndexOf(to) - str.IndexOf(from) - to.Length - 6);

            else return "<None>";
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
            
            AppThread BrowserProcess = new AppThread(true, "https://github.com/Martinfree/cryptokey-evaluator/");
            BrowserProcess.Exec();
            
        }

        private void PowerShellListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PowerShellTextBox_Click(object sender, EventArgs e)
        {

        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            //string FormatCheck;
            //string FastCheck;

            if (CypherTextBox.Text == "") return;
            
            PowerShellTextBox.Text = CrackingResistance(false, false, CypherTextBox.Text, SecretKeyTextBox.Text, "<None>");
            
            int a = ResultTreeView.Nodes.Add(CypherTextBox.Text).Index;
            TreeView_Writer(a, 0, "<None>", "Алгоритми");
            //TreeView_Writer(a, 1, OpenKeyTextBox.Text, "відкритий ключ");
            TreeView_Writer(a, 1, SecretKeyTextBox.Text, "таємний ключ");


            

            //FastCheck.DeleteFile(".hash");
            //FastCheck.DeleteFile(".seckey");
            //.\api.exe --cracking-resistance --hash-file=hash.txt --format=ssh --secret=leonid123
            //ResultTreeView.Nodes[a].Nodes[2].Nodes.Add(
            //    FastCheck.Exec()
            //    );


        }


        private void CypherOpenFileButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
