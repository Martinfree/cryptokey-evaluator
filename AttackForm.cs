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
        public AttackForm()
        {
            InitializeComponent();
        }
        void HashcatAttack()
        {
            string args = "";
            if (CyphTextBox.Text == "") args += " hashcat";
            else args += CyphTextBox.Text + "hashcat.exe";
        }
        void JohnAttack()
        {
            string args = "";
            if (CyphTextBox.Text == "") args += " john";
            else args += CyphTextBox.Text + "john.exe";
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
                    HashcatAttack();
                    break;
                case false:
                    if (JohnRadioButton.Checked)
                    {
                        JohnAttack();
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
