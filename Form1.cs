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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void VersionlinkLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", "https://github.com/Martinfree/cryptokey-evaluator/tree/Win32App");
        }

        private void PowerShellListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PowerShellTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
