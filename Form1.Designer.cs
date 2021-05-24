
using System.Diagnostics;
using System.Windows;
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
            this.button2 = new System.Windows.Forms.Button();
            this.CypherOpenFileButton = new System.Windows.Forms.Button();
            this.AttackButton = new System.Windows.Forms.Button();
            this.HackManagmentGroupBox = new System.Windows.Forms.GroupBox();
            this.FindPassRadioButton = new System.Windows.Forms.RadioButton();
            this.Timelabel = new System.Windows.Forms.Label();
            this.TimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FastCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SecretKeyLabel = new System.Windows.Forms.Label();
            this.SecretKeyTextBox = new System.Windows.Forms.TextBox();
            this.CypherTextBox = new System.Windows.Forms.TextBox();
            this.CypherLabel = new System.Windows.Forms.Label();
            this.Startbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultTreeView = new System.Windows.Forms.TreeView();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.ResultProgressBar = new System.Windows.Forms.ProgressBar();
            this.PowerShellTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CypherOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SecretOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.InputGroupBox.SuspendLayout();
            this.HackManagmentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.InputGroupBox.Controls.Add(this.button2);
            this.InputGroupBox.Controls.Add(this.CypherOpenFileButton);
            this.InputGroupBox.Controls.Add(this.AttackButton);
            this.InputGroupBox.Controls.Add(this.HackManagmentGroupBox);
            this.InputGroupBox.Controls.Add(this.SecretKeyLabel);
            this.InputGroupBox.Controls.Add(this.SecretKeyTextBox);
            this.InputGroupBox.Controls.Add(this.CypherTextBox);
            this.InputGroupBox.Controls.Add(this.CypherLabel);
            this.InputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(351, 292);
            this.InputGroupBox.TabIndex = 1;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Область вводу";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(303, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // CypherOpenFileButton
            // 
            this.CypherOpenFileButton.BackColor = System.Drawing.Color.Transparent;
            this.CypherOpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CypherOpenFileButton.Location = new System.Drawing.Point(303, 42);
            this.CypherOpenFileButton.Name = "CypherOpenFileButton";
            this.CypherOpenFileButton.Size = new System.Drawing.Size(26, 23);
            this.CypherOpenFileButton.TabIndex = 12;
            this.CypherOpenFileButton.UseVisualStyleBackColor = false;
            this.CypherOpenFileButton.Click += new System.EventHandler(this.CypherOpenFileButton_Click);
            // 
            // AttackButton
            // 
            this.AttackButton.Location = new System.Drawing.Point(210, 260);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(135, 23);
            this.AttackButton.TabIndex = 11;
            this.AttackButton.Text = "AttackButton";
            this.AttackButton.UseVisualStyleBackColor = true;
            // 
            // HackManagmentGroupBox
            // 
            this.HackManagmentGroupBox.Controls.Add(this.FindPassRadioButton);
            this.HackManagmentGroupBox.Controls.Add(this.Timelabel);
            this.HackManagmentGroupBox.Controls.Add(this.TimeNumericUpDown);
            this.HackManagmentGroupBox.Controls.Add(this.FastCheckBox);
            this.HackManagmentGroupBox.Controls.Add(this.checkBox3);
            this.HackManagmentGroupBox.Location = new System.Drawing.Point(7, 122);
            this.HackManagmentGroupBox.Name = "HackManagmentGroupBox";
            this.HackManagmentGroupBox.Size = new System.Drawing.Size(158, 164);
            this.HackManagmentGroupBox.TabIndex = 10;
            this.HackManagmentGroupBox.TabStop = false;
            this.HackManagmentGroupBox.Text = "Управління перевіркою";
            // 
            // FindPassRadioButton
            // 
            this.FindPassRadioButton.AutoSize = true;
            this.FindPassRadioButton.Location = new System.Drawing.Point(7, 48);
            this.FindPassRadioButton.Name = "FindPassRadioButton";
            this.FindPassRadioButton.Size = new System.Drawing.Size(84, 19);
            this.FindPassRadioButton.TabIndex = 11;
            this.FindPassRadioButton.TabStop = true;
            this.FindPassRadioButton.Text = "--find-pass";
            this.FindPassRadioButton.UseVisualStyleBackColor = true;
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Location = new System.Drawing.Point(97, 142);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(19, 15);
            this.Timelabel.TabIndex = 10;
            this.Timelabel.Text = "хв";
            // 
            // TimeNumericUpDown
            // 
            this.TimeNumericUpDown.Enabled = false;
            this.TimeNumericUpDown.Location = new System.Drawing.Point(6, 135);
            this.TimeNumericUpDown.Name = "TimeNumericUpDown";
            this.TimeNumericUpDown.Size = new System.Drawing.Size(75, 23);
            this.TimeNumericUpDown.TabIndex = 9;
            // 
            // FastCheckBox
            // 
            this.FastCheckBox.AutoSize = true;
            this.FastCheckBox.Location = new System.Drawing.Point(6, 22);
            this.FastCheckBox.Name = "FastCheckBox";
            this.FastCheckBox.Size = new System.Drawing.Size(91, 19);
            this.FastCheckBox.TabIndex = 8;
            this.FastCheckBox.Text = "--fast-check";
            this.FastCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(6, 110);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(121, 19);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Розрахунок часу ";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // SecretKeyLabel
            // 
            this.SecretKeyLabel.AutoSize = true;
            this.SecretKeyLabel.Location = new System.Drawing.Point(6, 68);
            this.SecretKeyLabel.Name = "SecretKeyLabel";
            this.SecretKeyLabel.Size = new System.Drawing.Size(88, 15);
            this.SecretKeyLabel.TabIndex = 4;
            this.SecretKeyLabel.Text = "Таємний ключ";
            // 
            // SecretKeyTextBox
            // 
            this.SecretKeyTextBox.Location = new System.Drawing.Point(6, 93);
            this.SecretKeyTextBox.Name = "SecretKeyTextBox";
            this.SecretKeyTextBox.Size = new System.Drawing.Size(291, 23);
            this.SecretKeyTextBox.TabIndex = 3;
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
            this.Startbutton.Location = new System.Drawing.Point(245, 223);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(116, 23);
            this.Startbutton.TabIndex = 1;
            this.Startbutton.Text = "Почати перевірку";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ResultTreeView);
            this.groupBox1.Controls.Add(this.MarkLabel);
            this.groupBox1.Controls.Add(this.ResultProgressBar);
            this.groupBox1.Controls.Add(this.Startbutton);
            this.groupBox1.Location = new System.Drawing.Point(369, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 463);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результати";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(126, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Оцінка";
            // 
            // ResultTreeView
            // 
            this.ResultTreeView.Location = new System.Drawing.Point(6, 264);
            this.ResultTreeView.Name = "ResultTreeView";
            this.ResultTreeView.Size = new System.Drawing.Size(355, 193);
            this.ResultTreeView.TabIndex = 3;
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MarkLabel.Location = new System.Drawing.Point(163, 114);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(48, 59);
            this.MarkLabel.TabIndex = 2;
            this.MarkLabel.Text = "0";
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
            // CypherOpenFileDialog
            // 
            this.CypherOpenFileDialog.FileName = "CypherOpenFileDialog";
            // 
            // SecretOpenFileDialog
            // 
            this.SecretOpenFileDialog.FileName = "SecKeyOpenFileDialog";
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
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel VersionLinkLabel;
        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.Label SecretKeyLabel;
        private System.Windows.Forms.TextBox SecretKeyTextBox;
        private System.Windows.Forms.TextBox CypherTextBox;
        private System.Windows.Forms.Label CypherLabel;
        private System.Windows.Forms.CheckBox FastCheckBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.ProgressBar ResultProgressBar;
        private System.Windows.Forms.TextBox PowerShellTextBox;
        private System.Windows.Forms.Label MarkLabel;
        //
        // Init Child processes
        //
        private System.Windows.Forms.TreeView ResultTreeView;
        private System.Windows.Forms.GroupBox HackManagmentGroupBox;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.NumericUpDown TimeNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AttackButton;
        private System.Windows.Forms.RadioButton FindPassRadioButton;
        private System.Windows.Forms.OpenFileDialog CypherOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog SecKeyOpenFileDialog;
        private System.Windows.Forms.Button CypherOpenFileButton;
        private System.Windows.Forms.OpenFileDialog SecretOpenFileDialog;
        private System.Windows.Forms.Button button2;
    }
}

