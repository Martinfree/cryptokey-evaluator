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
        /// <summary>
        /// Find string from one string to other
        /// </summary>
        /// <param name="str"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        string FindStr(string str, string from, string to)
        {
            try
            {
                return str.Substring(str.IndexOf(from) + from.Length, str.IndexOf(to, str.IndexOf(from)) - str.IndexOf(from) - from.Length);
            }
            catch (Exception e)
            {
                return "<None>";
            }
        }
        /// <summary>
        /// Copy to the end
        /// </summary>
        /// <param name="str"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        string FindStrW(string str, string from)
        {
            try
            {
                return str.Substring(str.IndexOf(from) + from.Length, str.Length - from.Length);
            }
            catch (Exception e)
            {
                return "<None>";
            }
        }
        /// <summary>
        /// Except Convert to Int Errors
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        int ConvertToInt16(string str)
        {
            try
            {
                return Convert.ToInt16(str);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        void PowerShellBox(bool clean, string cmd)
        {
            if (clean)
            {
                PowerShellTextBox.Text = "PS cryptokey-evaluator> " + cmd;
            }
            else
            {
                PowerShellTextBox.AppendText(Environment.NewLine);
                PowerShellTextBox.Text += cmd;
            }
                return;
        }

        /// <summary>
        /// Create mask for password
        /// </summary>
        /// <param name="secret"></param>
        /// <returns></returns>
        string CreateMask(string secret)
        {
            string s = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            string mask = "";
            
            for (int str = 0; str < secret.Length; str++)
            {
                for (char u = 'a'; u <= 'z'; u++) if (secret[str] == u && Char.ToLower(secret[str]) == secret[str] && !Char.IsDigit(secret[str])) mask += "?l";
                for (char l = 'A'; l <= 'Z'; l++) if (secret[str] == l && Char.ToUpper(secret[str]) == secret[str]) mask += "?u";
                if (Char.IsDigit(secret[str])) mask += "?d";
                for (int special = 0; special < s.Length; special++) if (secret[str] == s[special]) mask += "?s";
            }
            
            return "\nMask: " + mask + ".";
        }
        /// <summary>
        /// Calculate mark for password 
        /// </summary>
        /// <param name="secret"></param>
        /// <returns></returns>
        double CalculatePass(string secret)
        {
            string s = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            double lower = 0; double number = 0; double special = 0; double upper = 0;
            
            for (int str = 0; str < secret.Length; str++)
            {
                for (char u = 'a'; u <= 'z'; u++) if (secret[str] == u && Char.ToLower(secret[str]) == secret[str] && !Char.IsDigit(secret[str])) lower+=1;
                for (char l = 'A'; l <= 'Z'; l++) if (secret[str] == l && Char.ToUpper(secret[str]) == secret[str]) upper+=1;
                if (Char.IsDigit(secret[str])) number+=1;
                for (int specia = 0; specia < s.Length; specia++) if (secret[str] == s[specia]) special+=1;
            }
            
            return (upper * 2 + lower + number + special * 3) * 3.5;
        }
        /// <summary>
        /// Calculate time to hack
        /// </summary>
        /// <returns></returns>
        double CalculateTimeToHack()
        {
            return 0.0;
        }

        /// <summary>
        /// Find password in rockyou.txt and create mask
        /// </summary>
        /// <param name="SecretFile"></param>
        /// <param name="secret"></param>
        /// <returns></returns>
        string FindPassThread(bool SecretFile, string secret)
        {
            string args = " --find-pass=" + secret;

            AppThread FindPass = new AppThread("powershell.exe ", "api.exe", args);
            
            
            FindPass.CreateFile(secret, ".seckey");
            PowerShellBox(false,FindPass.cmd);
            return FindPass.Exec() + "|" + CreateMask(secret);
        }

        void FindPass()
        {
            string res = "";
            int number;

            PowerShellBox(true, "wait...");

            switch (FindStr(CypherTextBox.Text, "<", ">"), FindStr(SecretKeyTextBox.Text, "<", ">"))
            {
                case ("dir", "dir"):
                    res = FindPassThread(true, FindStrW(SecretKeyTextBox.Text, "<dir>"));
                    res += FastCheckThread(true, FindStrW(CypherTextBox.Text, "<dir>"), FindStrW(SecretKeyTextBox.Text, "<dir>")); 
                    break;
                case ("<None>", "dir"):
                    res = FindPassThread(true, FindStrW(SecretKeyTextBox.Text, "<dir>"));
                    res += FastCheckThread(true, CypherTextBox.Text, FindStrW(SecretKeyTextBox.Text, "<dir>"));
                    break;
                case ("dir", "<None>"):
                    res = FindPassThread(false, SecretKeyTextBox.Text);
                    res += FastCheckThread(false, FindStrW(CypherTextBox.Text, "<dir>"), SecretKeyTextBox.Text);
                    break;
                default:
                    res = FindPassThread(false, SecretKeyTextBox.Text);
                    res += FastCheckThread(false, CypherTextBox.Text, SecretKeyTextBox.Text);
                    break;
            }

            number = CyphListView(CypherTextBox.Text, SecretKeyTextBox.Text, AlgTextBox.Text);
            
            TreeViewWriteChild(number, 1, "К-сть комбінацій: " + FindStr(res, "Possible combinations:", ";"), "");

            if (MaskCheckBox.Checked && MaskCheckBox.Enabled) TreeViewWriteChild(number, 1, "Маска для атаки: " + FindStr(CreateMask(SecretKeyTextBox.Text), "Mask:", "."), "");

            if (FindPassCheckBox.Checked && FindPassCheckBox.Enabled)
            {
                TreeViewWriteChild(number, 1, "Знайдено в:" + FindStr(res, "in file:", "|"), "");
                
                if (FindStr(res, "in file:", "|") != "<None>" && CalculatePass(SecretKeyTextBox.Text) > 30)
                {
                    ResTreeView.Nodes[number].Nodes.Add("Оцінка ключа: " + Convert.ToString(CalculatePass(SecretKeyTextBox.Text) - 30));
                    MarkLabel.Text = Convert.ToString(CalculatePass(SecretKeyTextBox.Text) - 30);
                }
                else
                {
                    ResTreeView.Nodes[number].Nodes.Add("Оцінка ключа: " + Convert.ToString(CalculatePass(SecretKeyTextBox.Text)));
                    MarkLabel.Text = Convert.ToString(CalculatePass(SecretKeyTextBox.Text));
                }
            }
            else
            {
                ResTreeView.Nodes[number].Nodes.Add("Оцінка ключа: " + Convert.ToString(CalculatePass(SecretKeyTextBox.Text)));
                MarkLabel.Text = Convert.ToString(CalculatePass(SecretKeyTextBox.Text));
            }
        }

        /// <summary>
        /// --fast-check
        /// </summary>
        /// <param name="SecretFile"></param>
        /// <param name="hash"></param>
        /// <param name="secret"></param>
        /// <returns></returns>
        string FastCheckThread(bool SecretFile, string hash, string secret)
        {            
            string args2 = " --fast-check" + " .hash";
            switch (SecretFile)
            {
                case true:
                    args2 += " " + secret;
                    break;
                default:
                    args2 += " .seckey";
                    break;
            }
            AppThread FastCheck = new AppThread("powershell.exe ", "api.exe", args2);
            FastCheck.CreateFile(hash, ".hash");
            
            PowerShellBox(false, FastCheck.cmd);
            
            return FastCheck.Exec();
        }

        void FastCheck()
        {
            string res = "";
            string res2 = "";
            int number;
            
            PowerShellBox(true, "wait");

            switch (FindStr(SecretKeyTextBox.Text, "<", ">"))
            {
                case "dir":
                    res = FastCheckThread(true, CypherTextBox.Text, FindStrW(SecretKeyTextBox.Text, "<dir>"));
                    break;
                default:
                    res = FastCheckThread(false, CypherTextBox.Text, SecretKeyTextBox.Text);
                    break;
            }

            number = CyphListView(CypherTextBox.Text, SecretKeyTextBox.Text, AlgTextBox.Text);
            
            TreeViewWriteChild(number, 0, "Довжина: " + FindStr(res, "Length:", "Algorithm:"), "");

            if (AlgTextBox.Text.Replace(" ", "") == "") res2 += FindFormat(false, CypherTextBox.Text);
            
            TreeViewWriteChild(number, 0, "Можливі Алгоритми: \n" + FindStr(res2, "Possible algorithms:", "."), "");

            ResTreeView.Nodes[number].Nodes.Add("Оцінка: " + FindStr(res, "Mark:", "."));
            MarkLabel.Text = FindStr(res, "Mark:", ".");
        }
        /// <summary>
        /// --find-whoami
        /// </summary>
        /// <param name="HashFile"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        string FindFormat(bool HashFile, string hash)
        {
            string args = " --find-whoami=";
            
            if (!HashFile) args += ".hash";
            else args += hash;

            AppThread FindFormat = new AppThread("powershell.exe ", "api.exe", args);
            FindFormat.CreateFile(CypherTextBox.Text, ".hash");
            
            PowerShellBox(false, FindFormat.cmd);
            
            return FindFormat.Exec() + ".";
        }

        /// <summary>
        /// --cracking-resistance
        /// </summary>
        /// <param name="HashFile"></param>
        /// <param name="SecretFile"></param>
        /// <param name="hash"></param>
        /// <param name="secret"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        string FullCrackingResistanceThread(bool HashFile, bool SecretFile,string hash, string secret, string format)
        {
            string args = " --cracking-resistance";
            
            if (!HashFile) args += " --hash-file=" + ".hash";
            else args += " --hash-file=" + hash;
            if (format != "<None>") args += " --format=" + format;
            if (!SecretFile) args += " --secret-file=" + ".seckey";
            else args += " --secret-file " + secret;
           
            AppThread CrackingResistance = new AppThread("powershell.exe ", "api.exe", args);
            
            if (!HashFile) CrackingResistance.CreateFile(CypherTextBox.Text, ".hash");
            if (!SecretFile) CrackingResistance.CreateFile(SecretKeyTextBox.Text, ".seckey");

            string HashRes, PassRes;
            HashRes = CrackingResistance.Exec();
            PassRes = HashRes;
            
            PowerShellBox(false, CrackingResistance.cmd);
            
            return CrackingResistance.Exec();
        }
        void FullCrackingResistance()
        {
            string res = "";
            int number;

            PowerShellBox(true, "wait...");
            switch ( FindStr(CypherTextBox.Text,"<",">"), FindStr(SecretKeyTextBox.Text, "<", ">"))
            {
                case ("dir","dir"): 
                    res = FullCrackingResistanceThread(true, true, FindStrW(CypherTextBox.Text,"<dir>"), FindStrW(SecretKeyTextBox.Text, "<dir>"), AlgTextBox.Text);
                    break;
                case ("<None>", "dir"):
                    res = FullCrackingResistanceThread(false, true, CypherTextBox.Text, FindStrW(SecretKeyTextBox.Text, "<dir>"), AlgTextBox.Text);
                    break;
                case ("dir", "<None>"):
                    res = FullCrackingResistanceThread(true, false, FindStrW(CypherTextBox.Text, "<dir>"), SecretKeyTextBox.Text, AlgTextBox.Text);
                    break;
                default:
                    res = FullCrackingResistanceThread(false, false, CypherTextBox.Text, SecretKeyTextBox.Text, AlgTextBox.Text);
                    break;
            }
            number = CyphListView(CypherTextBox.Text, SecretKeyTextBox.Text, AlgTextBox.Text);
            
            MarkLabel.Text = FindStr(res, "Mark:", ".");
            ResTreeView.Nodes[number].Nodes.Add("Оцінка: " + FindStr(res, "Mark:", "."));
            
            TreeViewWriteChild(number, 0, "Алгоритм: " + AlgTextBox.Text, "");
            TreeViewWriteChild(number, 0, "Частотний аналіз: " + FindStr(res, "Character   Frequency", "Info about Key:"), "");
            TreeViewWriteChild(number, 0, "Довжина: " + FindStr(res, "Length:", "Algorithm:"), ".");
            TreeViewWriteChild(number, 1, "К-сть комбінацій: " + FindStr(res, "Possible combinations:", ";"), "");
        }
        void HalfCrackingResistance()
        {
            string res = "";
            int number;
            
            PowerShellBox(true, "wait...");

            if (SecretKeyTextBox.Text.Replace(" ", "") != "")
            {
                switch (FindStr(SecretKeyTextBox.Text, "<", ">"))
                { 
                    case "dir":
                        res += FastCheckThread(true, CypherTextBox.Text, FindStrW(SecretKeyTextBox.Text, "<dir>"));
                        res += FindPassThread(true, FindStrW(SecretKeyTextBox.Text, "<dir>"));
                        break;
                    default:
                        res += FastCheckThread(false, CypherTextBox.Text, SecretKeyTextBox.Text);
                        res += FindPassThread(false, SecretKeyTextBox.Text);
                        break;
                }
                
            }

            if (AlgTextBox.Text.Replace(" ", "") == "")
            {
                switch (FindStr(SecretKeyTextBox.Text, "<", ">"))
                {
                    case "dir":
                        res += FindFormat(true, FindStr(SecretKeyTextBox.Text, "<dir>", "\0"));
                        break;
                    default:
                        res += FindFormat(false, CypherTextBox.Text);
                        break;

                }
            }

            number = CyphListView(CypherTextBox.Text, SecretKeyTextBox.Text, FindStr(res, "Possible algorithms:", "."));

            int mark = ConvertToInt16(FindStr(res, "Mark:", "."));

            if (FindStr(res, "in file:", "|") != "<None>" && ConvertToInt16(FindStr(res, "Mark:", ".")) > 30) mark -= 30;
            
            MarkLabel.Text = Convert.ToString(mark);
            ResTreeView.Nodes[number].Nodes.Add("Оцінка: " + Convert.ToString(mark));
            TreeViewWriteChild(number, 0, "Алгоритм: \n" + FindStr(res, "Possible algorithms:", "."), "");
            TreeViewWriteChild(number, 0, "Довжина: " + FindStr(res, "Length:", "Algorithm:"), "");
            TreeViewWriteChild(number, 1, "К-сть комбінацій: " + FindStr(res, "Possible combinations:", ";"), "");
            TreeViewWriteChild(number, 1, "Знайдено в:" + FindStr(res, "in file:", "|"), "");
        }
        string CopyFromTo(string str, string from, string to)
        {
            if (str !="") return str.Substring(str.IndexOf(from) + from.Length, str.IndexOf(to) - str.IndexOf(from) - to.Length - 6);

            else return "<None>";
        }
        /// <summary>
        /// Write child node to TreeView info to exist local word=""
        /// </summary>
        /// <param name="parent_count"></param>
        /// <param name="child_count"></param>
        /// <param name="str"></param>
        /// <param name="local_word"></param>
        void TreeViewWriteChild(int parent_count, int child_count, string str, string local_word)
        {
             ResTreeView.Nodes[parent_count].Nodes[child_count].Nodes.Add(str);
        }
        /// <summary>
        /// Write node and add child to him
        /// </summary>
        /// <param name="parent_count"></param>
        /// <param name="child_count"></param>
        /// <param name="str"></param>
        /// <param name="local_word"></param>
        void TreeViewWrite(int parent_count,int child_count, string str, string local_word)
        {
            ResTreeView.Nodes[parent_count].Nodes.Add(local_word);

            switch (str)
            {
                case "":
                    ResTreeView.Nodes[parent_count].Nodes[child_count].Nodes.Add("<None>");
                    break;

                default:
                    if (str.Length > 24) ResTreeView.Nodes[parent_count].Nodes[child_count].Nodes.Add(str.Remove(24)+"...");
                    else ResTreeView.Nodes[parent_count].Nodes[child_count].Nodes.Add(str);
                    break;
            }
        }
        /// <summary>
        /// Format cypher text to usable format
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="seckey"></param>
        /// <param name="algs"></param>
        /// <returns></returns>
        int CyphListView(string hash, string seckey, string algs)
        { 
            int a;
            
            if (hash.Length > 24 ) a = ResTreeView.Nodes.Add(DateTime.Now.ToString("<dd/MM H:mm>") + hash.Remove(24)+"...").Index;
            else a = ResTreeView.Nodes.Add(DateTime.Now.ToString("<dd/MM H:mm>") +hash).Index;

            ResTreeView.Nodes[a].Nodes.Add("Дослідження зашифрованого тексту");
            TreeViewWrite(a, 1, seckey, "таємний ключ");

            return a;
        }

        //-------------------------- EVENT SECTION --------------------------\\
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
        /// <summary>
        /// Start calculate results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Startbutton_Click(object sender, EventArgs e)
        {
            //string res = "";
            //int number;
            if (CypherTextBox.Text == "") return;
            
            if (CrackingResRadioButton.Checked)
            {
                if (FastCheckBox.Checked && FastCheckBox.Enabled) 
                {
                    FastCheck();
                }
                else
                {
                    if (SecretKeyTextBox.Text != "" && AlgTextBox.Text != "")
                    {
                        FullCrackingResistance();
                    }
                    else
                    {
                        HalfCrackingResistance();
                    }
                }
                if (TimeCheckBox.Checked && TimeCheckBox.Enabled) CalculateTimeToHack();
            }
            else if (FindPassRadioButton.Checked)
            {
                FindPass();
            }
            
            
        }

        private void CypherOpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog CypherOpenFileDialog = new OpenFileDialog();
            CypherOpenFileDialog.InitialDirectory = @"C:\";
            CypherOpenFileDialog.Title = "Зашифрований текст";
            CypherOpenFileDialog.CheckFileExists = true;
            CypherOpenFileDialog.CheckPathExists = true;
            CypherOpenFileDialog.ShowDialog();
            CypherTextBox.Text = "<dir>" + CypherOpenFileDialog.FileName + "\0";
        }

        private void FindPassRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CrackingResRadioButton.Checked = !FindPassRadioButton.Checked;
            FastCheckBox.Enabled = !FindPassRadioButton.Checked;
        }

        private void CrackingResRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FindPassRadioButton.Checked = !CrackingResRadioButton.Checked;
            MaskCheckBox.Enabled = !CrackingResRadioButton.Checked;
            FindPassCheckBox.Enabled = !CrackingResRadioButton.Checked;
        }

        private void FastCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TimeCheckBox.Enabled = !FastCheckBox.Checked;
        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            AttackForm form = new AttackForm(CypherTextBox.Text, AlgTextBox.Text);
            form.ShowDialog();
        }

        private void SecretOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
 
        }

        private void SecretOpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog SecretOpenFileDialog = new OpenFileDialog();
            
            SecretOpenFileDialog.InitialDirectory = @"C:\";
            SecretOpenFileDialog.Title = "Таємний ключ";
            SecretOpenFileDialog.CheckFileExists = true;
            SecretOpenFileDialog.CheckPathExists = true;
            SecretOpenFileDialog.ShowDialog();
            SecretKeyTextBox.Text = "<dir>"+SecretOpenFileDialog.FileName + "\0";
        }
    }
}
