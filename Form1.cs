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
        //attack
        string Attack()
        {
            return "<None>";
        }
        
        //find string from one string to other
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
        
        // create mask for str
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
        //Find password in rockyou.txt and create mask (--find-pass not working)
        string FindPass(bool SecretFile, string secret)
        {
            string args = " --find-pass=" + secret;

            AppThread FindPass = new AppThread("powershell.exe ", "api.exe", args);
            
            
            FindPass.CreateFile(secret, ".seckey");

            return FindPass.Exec() + "|" + CreateMask(secret);
        }

        // --fast-check
        string FastCheck(bool SecretFile, string hash, string secret)
        {
            
            string args2 = " --fast-check" + " .hash" + " .seckey";

            
            AppThread FastCheck = new AppThread("powershell.exe ", "api.exe", args2);
            FastCheck.CreateFile(hash, ".hash");
            
            return FastCheck.Exec();
        }    

        // --find-whoami
        string FindFormat(bool HashFile, string hash)
        {
            string args = " --find-whoami=";
            if (!HashFile) args += ".hash";
            else args += hash;

            AppThread FindFormat = new AppThread("powershell.exe ", "api.exe", args);
            FindFormat.CreateFile(CypherTextBox.Text, ".hash");
            return FindFormat.Exec() + ".";
        }

        // --cracking-resistance
        string FullCrackingResistance(bool HashFile, bool SecretFile,string hash, string secret, string format)
        {

            string args = " --cracking-resistance";
            if (!HashFile) args += " --hash-file=" + ".hash";
            else args += "--hash-file=" + hash;
            if (format != "<None>") args += " --format=" + format;
            if (!SecretFile) args += " --secret-file=" + ".seckey";
            else args += " --secret-file " + secret;
            

            
            AppThread CrackingResistance = new AppThread("powershell.exe ", "api.exe", args);
            if (!HashFile) CrackingResistance.CreateFile(CypherTextBox.Text, ".hash");
            if (!SecretFile) CrackingResistance.CreateFile(SecretKeyTextBox.Text, ".seckey");

            string HashRes, PassRes;
            HashRes = CrackingResistance.Exec();
            PassRes = HashRes;
            return CrackingResistance.Exec();

            /*                FindStr(PassRes, "Password length:", ";") + FindStr(PassRes, "Uppercase:", ";") 
                            + FindStr(PassRes, "Lowercase:", ";") + FindStr(PassRes, "Numbers:", ";") 
                            + FindStr(PassRes, "Special:", ";") + FindStr(PassRes, "Possible combinations:", ";"), 
            */
        }

        string CopyFromTo(string str, string from, string to)
        {
            if (str !="") return str.Substring(str.IndexOf(from) + from.Length, str.IndexOf(to) - str.IndexOf(from) - to.Length - 6);

            else return "<None>";
        }
        void TreeViewWriteChild(int parent_count, int child_count, string str, string local_word)
        {
            //ResTreeView.Nodes[parent_count].Nodes.Add(local_word);
            //if (str.Length > 24) ResTreeView.Nodes[parent_count].Nodes[child_count].Nodes.Add(str.Remove(24) + "...");
             ResTreeView.Nodes[parent_count].Nodes[child_count].Nodes.Add(str);
        }
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
        int CyphListView(string hash, string seckey, string algs)
        { 
            int a;
            if (hash.Length > 24 ) a = ResTreeView.Nodes.Add(hash.Remove(24)+"...").Index;
            else a = ResTreeView.Nodes.Add(hash).Index;

            //TreeViewWrite(a, 0, algs, "Алгоритми");
            ResTreeView.Nodes[a].Nodes.Add("Дослідження зашифрованого тексту");// (a, 1, "Частотний аналіз",);
            TreeViewWrite(a, 1, seckey, "таємний ключ");
           // ResTreeView.EndUpdate();
            return a;
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
            string res = "";
            int number;
            if (CypherTextBox.Text == "") return;
            
            //PowerShellTextBox.Text = CrackingResistance(false, false, CypherTextBox.Text, SecretKeyTextBox.Text, AlgTextBox.Text).Item1;
            

            if (CrackingResRadioButton.Checked)
            {
                if (FastCheckBox.Checked && FastCheckBox.Enabled) 
                {
                    string res2 = "";
                    res = FastCheck(false, CypherTextBox.Text, SecretKeyTextBox.Text);
                    number = CyphListView(CypherTextBox.Text, SecretKeyTextBox.Text, AlgTextBox.Text);
                    TreeViewWriteChild(number, 0, "Довжина: " + FindStr(res, "Length:", "Algorithm:"), "");
                    
                    if (AlgTextBox.Text.Replace(" ", "") == "") res2 += FindFormat(false, CypherTextBox.Text);
                    TreeViewWriteChild(number, 0, "Можливі Алгоритми: \n" + FindStr(res2, "Possible algorithms:", "."), "");
                    
                    ResTreeView.Nodes[number].Nodes.Add("Оцінка: " + FindStr(res, "Mark:", "."));
                    MarkLabel.Text = FindStr(res, "Mark:", ".");
                }
                else
                {
                    if (SecretKeyTextBox.Text != "" && AlgTextBox.Text != "")
                    {
                        res = FullCrackingResistance(false, false, CypherTextBox.Text, SecretKeyTextBox.Text, AlgTextBox.Text);
                        number = CyphListView(CypherTextBox.Text, SecretKeyTextBox.Text, AlgTextBox.Text);
                        MarkLabel.Text = FindStr(res, "Mark:", ".");
                        ResTreeView.Nodes[number].Nodes.Add("Оцінка: " + FindStr(res, "Mark:", "."));
                        TreeViewWriteChild(number, 0, "Алгоритм: " + AlgTextBox.Text, "");
                        TreeViewWriteChild(number, 0, "Частотний аналіз: " + FindStr(res, "Character   Frequency", "Info about Key:"), "");
                        TreeViewWriteChild(number, 0, "Довжина: " + FindStr(res, "Length:", "Algorithm:"), ".");
                        TreeViewWriteChild(number, 1, "К-сть комбінацій: " + FindStr(res, "Possible combinations:", ";"), "");
                    }
                    else
                    {
                        if (SecretKeyTextBox.Text.Replace(" ", "") != "")
                        {
                            res += FastCheck(false, CypherTextBox.Text, SecretKeyTextBox.Text);
                            res += FindPass(false, SecretKeyTextBox.Text);
                        }
                        if (AlgTextBox.Text.Replace(" ", "") == "") res += FindFormat(false, CypherTextBox.Text);
                        number = CyphListView(CypherTextBox.Text, SecretKeyTextBox.Text, FindStr(res, "Possible algorithms:", "."));
                        
                        
                        int mark = Convert.ToInt16(FindStr(res, "Mark:", "."));
                        
                        if (FindStr(res, "in file:", "|") != "<None>" && Convert.ToInt16(FindStr(res, "Mark:", ".")) > 30) mark -= 30;
                        MarkLabel.Text = Convert.ToString(mark);
                        ResTreeView.Nodes[number].Nodes.Add("Оцінка: " + Convert.ToString(mark));
                        TreeViewWriteChild(number, 0, "Алгоритм: \n" + FindStr(res, "Possible algorithms:", "."),"");
                        //TreeViewWriteChild(number, 0, "Частотний аналіз: " + FindStr(res, "Character   Frequency", "Info about Key:"), "");
                        TreeViewWriteChild(number, 0, "Довжина: " + FindStr(res, "Length:", "Algorithm:"), "");
                        TreeViewWriteChild(number, 1, "К-сть комбінацій: " + FindStr(res, "Possible combinations:", ";"), "");
                        TreeViewWriteChild(number, 1, "Знайдено в:" + FindStr(res, "in file:", "|"), "");
                    }
                }
                //if (TimeCheckBox.Checked && TimeCheckBox.Enabled) FastCheck(false, SecretKeyTextBox.Text);
            }
            else if (FindPassRadioButton.Checked)
            {
                
                res = FindPass(false, SecretKeyTextBox.Text);
                res += FastCheck(false, CypherTextBox.Text, SecretKeyTextBox.Text);
                number = CyphListView(CypherTextBox.Text, SecretKeyTextBox.Text, AlgTextBox.Text);
                //TreeViewWriteChild(number, 0, "Довжина: " + FindStr(res, "Length:", "Algorithm:"), "");
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
                //res = FastCheck(false, SecretKeyTextBox.Text);
            }
            
            
        }


        private void CypherOpenFileButton_Click(object sender, EventArgs e)
        {
            
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
    }
}
