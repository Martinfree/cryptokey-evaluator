using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptokey_evaluator
{
    public partial class AttackForm : Form
    {
        public AttackForm(string CypherText, string Format)
        {
            InitializeComponent();
            CyphTextBox.Text = CypherText;
            AlgoTextBox.Text = Format;
        }
        void CreateFile(string str, string name)
        {
            System.IO.StreamWriter file = new(name);
            file.Write(str);
            file.Close();
            //return System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug\\net5.0-windows", "").Replace("\\", "/") + name;
        }
        void HashcatAttack(bool BruteForceAttack, bool MaskAttack, bool DictAttack, string cypher, string path,string type = " 0",string mask = " ?a?a?a?a?a?a?a?a", string dict = "include/rockyou.txt")
        {
            
            if (path == "") return;
            string args = " " + path ;

            if (BruteForceAttack) args += " -a 3 -m" +type+ " .hash" + " ?a?a?a?a?a?a?a?a";
            if (MaskAttack)
            {
                args += " -a 3 -m" + type + " .hash" + mask;
            }
            if (DictAttack)
            {
                args += " -a 3 -m" + type + " .hash" + dict;
            }

            CreateFile(cypher, ".hash");
            System.Diagnostics.Process.Start("powershell.exe ", "-NoExit" + args);
        }
        void JohnAttack(bool BruteForceAttack, bool MaskAttack, bool DictAttack, string cypher, string mask="?a?a?a?a?a?a?a?a", string dict="include/rockyou.txt")
        {
            string args = " john";

            if (AlgoTextBox.Text != "") args += " --format="+AlgoTextBox.Text;
            //if (CyphTextBox.Text == "") args += " john";
            if (BruteForceAttack) args += " .hash";
            if (MaskAttack) 
            { 
                args += " --mask=" + mask + " .hash"; 
            }
            if (DictAttack) 
            {
                args += " --wordlist=" + dict + " .hash";
            }
               
            CreateFile(cypher, ".hash");
            System.Diagnostics.Process.Start("powershell.exe ", "-NoExit" + args);
        }
        private void HashCatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            JohnRadioButton.Checked = !HashCatRadioButton.Checked;
        }

        private void JohnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HashCatRadioButton.Checked = !JohnRadioButton.Checked;
        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            if (CyphTextBox.Text == "") MessageBox.Show("Вкажіть текст, який потрібно дешифрувати",
                                                        "Info",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Information,
                                                        MessageBoxDefaultButton.Button1,
                                                        MessageBoxOptions.DefaultDesktopOnly);

            switch (HashCatRadioButton.Checked)
            {
                case true:
                    HashcatAttack(BruteForceAttackCheckBox.Checked, MaskAttackCheckBox.Checked, DictAttackCheckBox.Checked, CyphTextBox.Text, PathTextBox.Text);
                    break;
                case false:
                    if (JohnRadioButton.Checked)
                    {
                        JohnAttack(BruteForceAttackCheckBox.Checked, MaskAttackCheckBox.Checked, DictAttackCheckBox.Checked, CyphTextBox.Text);
                        break;
                    }
                    MessageBox.Show("Виберіть програму для проведення атаки",
                        "Info", 
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    break;
            }
        }

        private void BruteForceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BruteForceAttackCheckBox.Checked)
            {
                MaskAttackCheckBox.Checked = false;
                DictAttackCheckBox.Checked = false;
                ThingTextBox.Enabled = false;
            }
        }

        private void MaskAttackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MaskAttackCheckBox.Checked)
            {
                BruteForceAttackCheckBox.Checked = false;
                DictAttackCheckBox.Checked = false;
                ThingTextBox.Enabled = true;
            }
        }

        private void DictAttackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DictAttackCheckBox.Checked)
            {
                BruteForceAttackCheckBox.Checked = false;
                MaskAttackCheckBox.Checked = false;
                ThingTextBox.Enabled = true;
            }
        }
    }
}
