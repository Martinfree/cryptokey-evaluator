
using System.Diagnostics;

namespace cryptokey_evaluator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VersionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.HackManagmentGroupBox = new System.Windows.Forms.GroupBox();
            this.FastCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.KeyManagmentGroupBox = new System.Windows.Forms.GroupBox();
            this.HashCheckBox = new System.Windows.Forms.CheckBox();
            this.DigitalSignatureCheckBox = new System.Windows.Forms.CheckBox();
            this.SecretKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.OpenKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.SecretKeyLabel = new System.Windows.Forms.Label();
            this.SecretKeyTextBox = new System.Windows.Forms.TextBox();
            this.FileRadioButton = new System.Windows.Forms.RadioButton();
            this.OpenKeyTextBox = new System.Windows.Forms.TextBox();
            this.OpenKeyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CypherTextBox = new System.Windows.Forms.TextBox();
            this.CypherLabel = new System.Windows.Forms.Label();
            this.Startbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResultTreeView = new System.Windows.Forms.TreeView();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultProgressBar = new System.Windows.Forms.ProgressBar();
            this.PowerShellTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Timelabel = new System.Windows.Forms.Label();
            this.InputGroupBox.SuspendLayout();
            this.HackManagmentGroupBox.SuspendLayout();
            this.KeyManagmentGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // VersionLinkLabel
            // 
            this.VersionLinkLabel.AutoSize = true;
            this.VersionLinkLabel.Location = new System.Drawing.Point(532, 478);
            this.VersionLinkLabel.Name = "VersionLinkLabel";
            this.VersionLinkLabel.Size = new System.Drawing.Size(204, 15);
            this.VersionLinkLabel.TabIndex = 0;
            this.VersionLinkLabel.TabStop = true;
            this.VersionLinkLabel.Text = "Cryptokey-evaluator build version 0.1";
            this.VersionLinkLabel.Click += new System.EventHandler(this.VersionlinkLabel_Click);
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.HackManagmentGroupBox);
            this.InputGroupBox.Controls.Add(this.KeyManagmentGroupBox);
            this.InputGroupBox.Controls.Add(this.SecretKeyLabel);
            this.InputGroupBox.Controls.Add(this.SecretKeyTextBox);
            this.InputGroupBox.Controls.Add(this.FileRadioButton);
            this.InputGroupBox.Controls.Add(this.OpenKeyTextBox);
            this.InputGroupBox.Controls.Add(this.OpenKeyLabel);
            this.InputGroupBox.Controls.Add(this.label2);
            this.InputGroupBox.Controls.Add(this.CypherTextBox);
            this.InputGroupBox.Controls.Add(this.CypherLabel);
            this.InputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(351, 292);
            this.InputGroupBox.TabIndex = 1;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Область вводу";
            // 
            // HackManagmentGroupBox
            // 
            this.HackManagmentGroupBox.Controls.Add(this.Timelabel);
            this.HackManagmentGroupBox.Controls.Add(this.TimeNumericUpDown);
            this.HackManagmentGroupBox.Controls.Add(this.FastCheckBox);
            this.HackManagmentGroupBox.Controls.Add(this.checkBox3);
            this.HackManagmentGroupBox.Controls.Add(this.Startbutton);
            this.HackManagmentGroupBox.Location = new System.Drawing.Point(148, 162);
            this.HackManagmentGroupBox.Name = "HackManagmentGroupBox";
            this.HackManagmentGroupBox.Size = new System.Drawing.Size(197, 124);
            this.HackManagmentGroupBox.TabIndex = 10;
            this.HackManagmentGroupBox.TabStop = false;
            this.HackManagmentGroupBox.Text = "Управління перевіркою";
            // 
            // FastCheckBox
            // 
            this.FastCheckBox.AutoSize = true;
            this.FastCheckBox.Enabled = false;
            this.FastCheckBox.Location = new System.Drawing.Point(6, 32);
            this.FastCheckBox.Name = "FastCheckBox";
            this.FastCheckBox.Size = new System.Drawing.Size(125, 19);
            this.FastCheckBox.TabIndex = 8;
            this.FastCheckBox.Text = "Швидка перевірка";
            this.FastCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(6, 57);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(121, 19);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Розрахунок часу ";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // KeyManagmentGroupBox
            // 
            this.KeyManagmentGroupBox.Controls.Add(this.HashCheckBox);
            this.KeyManagmentGroupBox.Controls.Add(this.DigitalSignatureCheckBox);
            this.KeyManagmentGroupBox.Controls.Add(this.SecretKeyCheckBox);
            this.KeyManagmentGroupBox.Controls.Add(this.OpenKeyCheckBox);
            this.KeyManagmentGroupBox.Location = new System.Drawing.Point(7, 162);
            this.KeyManagmentGroupBox.Name = "KeyManagmentGroupBox";
            this.KeyManagmentGroupBox.Size = new System.Drawing.Size(135, 124);
            this.KeyManagmentGroupBox.TabIndex = 9;
            this.KeyManagmentGroupBox.TabStop = false;
            this.KeyManagmentGroupBox.Text = "Управління ключами";
            // 
            // HashCheckBox
            // 
            this.HashCheckBox.AutoSize = true;
            this.HashCheckBox.Location = new System.Drawing.Point(6, 102);
            this.HashCheckBox.Name = "HashCheckBox";
            this.HashCheckBox.Size = new System.Drawing.Size(50, 19);
            this.HashCheckBox.TabIndex = 8;
            this.HashCheckBox.Text = "Хеш";
            this.HashCheckBox.UseVisualStyleBackColor = true;
            this.HashCheckBox.CheckedChanged += new System.EventHandler(this.HashCheckBox_CheckedChanged);
            // 
            // DigitalSignatureCheckBox
            // 
            this.DigitalSignatureCheckBox.AutoSize = true;
            this.DigitalSignatureCheckBox.Enabled = false;
            this.DigitalSignatureCheckBox.Location = new System.Drawing.Point(6, 82);
            this.DigitalSignatureCheckBox.Name = "DigitalSignatureCheckBox";
            this.DigitalSignatureCheckBox.Size = new System.Drawing.Size(50, 19);
            this.DigitalSignatureCheckBox.TabIndex = 7;
            this.DigitalSignatureCheckBox.Text = "ЕЦП";
            this.DigitalSignatureCheckBox.UseVisualStyleBackColor = true;
            // 
            // SecretKeyCheckBox
            // 
            this.SecretKeyCheckBox.AutoSize = true;
            this.SecretKeyCheckBox.Checked = true;
            this.SecretKeyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SecretKeyCheckBox.Location = new System.Drawing.Point(6, 32);
            this.SecretKeyCheckBox.Name = "SecretKeyCheckBox";
            this.SecretKeyCheckBox.Size = new System.Drawing.Size(107, 19);
            this.SecretKeyCheckBox.TabIndex = 5;
            this.SecretKeyCheckBox.Text = "Таємний ключ";
            this.SecretKeyCheckBox.UseVisualStyleBackColor = true;
            this.SecretKeyCheckBox.CheckedChanged += new System.EventHandler(this.SecretKeyCheckBox_CheckedChanged);
            // 
            // OpenKeyCheckBox
            // 
            this.OpenKeyCheckBox.AutoSize = true;
            this.OpenKeyCheckBox.Location = new System.Drawing.Point(6, 57);
            this.OpenKeyCheckBox.Name = "OpenKeyCheckBox";
            this.OpenKeyCheckBox.Size = new System.Drawing.Size(114, 19);
            this.OpenKeyCheckBox.TabIndex = 6;
            this.OpenKeyCheckBox.Text = "Відкритий ключ";
            this.OpenKeyCheckBox.UseVisualStyleBackColor = true;
            this.OpenKeyCheckBox.CheckedChanged += new System.EventHandler(this.OpenKeyCheckBox_CheckedChanged);
            // 
            // SecretKeyLabel
            // 
            this.SecretKeyLabel.AutoSize = true;
            this.SecretKeyLabel.Location = new System.Drawing.Point(3, 115);
            this.SecretKeyLabel.Name = "SecretKeyLabel";
            this.SecretKeyLabel.Size = new System.Drawing.Size(88, 15);
            this.SecretKeyLabel.TabIndex = 4;
            this.SecretKeyLabel.Text = "Таємний ключ";
            // 
            // SecretKeyTextBox
            // 
            this.SecretKeyTextBox.Location = new System.Drawing.Point(6, 133);
            this.SecretKeyTextBox.Name = "SecretKeyTextBox";
            this.SecretKeyTextBox.Size = new System.Drawing.Size(291, 23);
            this.SecretKeyTextBox.TabIndex = 3;
            // 
            // FileRadioButton
            // 
            this.FileRadioButton.AutoSize = true;
            this.FileRadioButton.Enabled = false;
            this.FileRadioButton.Location = new System.Drawing.Point(224, 17);
            this.FileRadioButton.Name = "FileRadioButton";
            this.FileRadioButton.Size = new System.Drawing.Size(105, 19);
            this.FileRadioButton.TabIndex = 3;
            this.FileRadioButton.TabStop = true;
            this.FileRadioButton.Text = "Відкрити файл";
            this.FileRadioButton.UseVisualStyleBackColor = true;
            // 
            // OpenKeyTextBox
            // 
            this.OpenKeyTextBox.Enabled = false;
            this.OpenKeyTextBox.Location = new System.Drawing.Point(7, 89);
            this.OpenKeyTextBox.Name = "OpenKeyTextBox";
            this.OpenKeyTextBox.Size = new System.Drawing.Size(291, 23);
            this.OpenKeyTextBox.TabIndex = 3;
            // 
            // OpenKeyLabel
            // 
            this.OpenKeyLabel.AutoSize = true;
            this.OpenKeyLabel.Location = new System.Drawing.Point(3, 70);
            this.OpenKeyLabel.Name = "OpenKeyLabel";
            this.OpenKeyLabel.Size = new System.Drawing.Size(95, 15);
            this.OpenKeyLabel.TabIndex = 2;
            this.OpenKeyLabel.Text = "Відкритий ключ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "еуte";
            // 
            // CypherTextBox
            // 
            this.CypherTextBox.Location = new System.Drawing.Point(7, 42);
            this.CypherTextBox.Name = "CypherTextBox";
            this.CypherTextBox.Size = new System.Drawing.Size(291, 23);
            this.CypherTextBox.TabIndex = 1;
            // 
            // CypherLabel
            // 
            this.CypherLabel.AutoSize = true;
            this.CypherLabel.Location = new System.Drawing.Point(6, 24);
            this.CypherLabel.Name = "CypherLabel";
            this.CypherLabel.Size = new System.Drawing.Size(76, 15);
            this.CypherLabel.TabIndex = 0;
            this.CypherLabel.Text = "Шифротекст";
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(122, 98);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(75, 23);
            this.Startbutton.TabIndex = 1;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResultTreeView);
            this.groupBox1.Controls.Add(this.ResultLabel);
            this.groupBox1.Controls.Add(this.ResultProgressBar);
            this.groupBox1.Location = new System.Drawing.Point(369, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 463);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результати";
            // 
            // ResultTreeView
            // 
            this.ResultTreeView.Location = new System.Drawing.Point(6, 264);
            this.ResultTreeView.Name = "ResultTreeView";
            this.ResultTreeView.Size = new System.Drawing.Size(355, 193);
            this.ResultTreeView.TabIndex = 3;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(163, 57);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(83, 59);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "0%";
            // 
            // ResultProgressBar
            // 
            this.ResultProgressBar.Location = new System.Drawing.Point(6, 31);
            this.ResultProgressBar.Name = "ResultProgressBar";
            this.ResultProgressBar.Size = new System.Drawing.Size(355, 23);
            this.ResultProgressBar.TabIndex = 0;
            // 
            // PowerShellTextBox
            // 
            this.PowerShellTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(36)))), ((int)(((byte)(86)))));
            this.PowerShellTextBox.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PowerShellTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.PowerShellTextBox.Location = new System.Drawing.Point(6, 22);
            this.PowerShellTextBox.Multiline = true;
            this.PowerShellTextBox.Name = "PowerShellTextBox";
            this.PowerShellTextBox.Size = new System.Drawing.Size(339, 151);
            this.PowerShellTextBox.TabIndex = 9;
            this.PowerShellTextBox.Text = "Hello I\'m your PowerShell like console >";
            this.PowerShellTextBox.Click += new System.EventHandler(this.PowerShellTextBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PowerShellTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 180);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Область управління";
            // 
            // TimeNumericUpDown
            // 
            this.TimeNumericUpDown.Enabled = false;
            this.TimeNumericUpDown.Location = new System.Drawing.Point(7, 77);
            this.TimeNumericUpDown.Name = "TimeNumericUpDown";
            this.TimeNumericUpDown.Size = new System.Drawing.Size(75, 23);
            this.TimeNumericUpDown.TabIndex = 9;
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Location = new System.Drawing.Point(89, 83);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(19, 15);
            this.Timelabel.TabIndex = 10;
            this.Timelabel.Text = "хв";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputGroupBox);
            this.Controls.Add(this.VersionLinkLabel);
            this.Name = "Form1";
            this.Text = "Cryptokey-evaluator";
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.HackManagmentGroupBox.ResumeLayout(false);
            this.HackManagmentGroupBox.PerformLayout();
            this.KeyManagmentGroupBox.ResumeLayout(false);
            this.KeyManagmentGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel VersionLinkLabel;
        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.Label SecretKeyLabel;
        private System.Windows.Forms.TextBox SecretKeyTextBox;
        private System.Windows.Forms.TextBox OpenKeyTextBox;
        private System.Windows.Forms.Label OpenKeyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CypherTextBox;
        private System.Windows.Forms.Label CypherLabel;
        private System.Windows.Forms.RadioButton FileRadioButton;
        private System.Windows.Forms.CheckBox FastCheckBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox OpenKeyCheckBox;
        private System.Windows.Forms.CheckBox SecretKeyCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.ProgressBar ResultProgressBar;
        private System.Windows.Forms.TextBox PowerShellTextBox;
        private System.Windows.Forms.Label ResultLabel;
        //
        // Init Child processes
        //
        Process ApiProcess; // api process
        Process PSProcess; // powershell process(optional now)
        Process BrowserProcess; //Child browser
        private System.Windows.Forms.TreeView ResultTreeView;
        private System.Windows.Forms.GroupBox HackManagmentGroupBox;
        private System.Windows.Forms.GroupBox KeyManagmentGroupBox;
        private System.Windows.Forms.CheckBox HashCheckBox;
        private System.Windows.Forms.CheckBox DigitalSignatureCheckBox;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.NumericUpDown TimeNumericUpDown;
    }
}

