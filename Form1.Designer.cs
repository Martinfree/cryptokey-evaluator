
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
            this.AlgLabel = new System.Windows.Forms.Label();
            this.AlgTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CypherOpenFileButton = new System.Windows.Forms.Button();
            this.HackManagmentGroupBox = new System.Windows.Forms.GroupBox();
            this.FindPassCheckBox = new System.Windows.Forms.CheckBox();
            this.TimeCheckBox = new System.Windows.Forms.CheckBox();
            this.MaskCheckBox = new System.Windows.Forms.CheckBox();
            this.FastCheckBox = new System.Windows.Forms.CheckBox();
            this.FindPassRadioButton = new System.Windows.Forms.RadioButton();
            this.CrackingResRadioButton = new System.Windows.Forms.RadioButton();
            this.SecretKeyLabel = new System.Windows.Forms.Label();
            this.SecretKeyTextBox = new System.Windows.Forms.TextBox();
            this.CypherTextBox = new System.Windows.Forms.TextBox();
            this.CypherLabel = new System.Windows.Forms.Label();
            this.AttackButton = new System.Windows.Forms.Button();
            this.Startbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResTreeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.ResultProgressBar = new System.Windows.Forms.ProgressBar();
            this.PowerShellTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CypherOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SecretOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.InputGroupBox.SuspendLayout();
            this.HackManagmentGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // VersionLinkLabel
            // 
            this.VersionLinkLabel.AutoSize = true;
            this.VersionLinkLabel.Location = new System.Drawing.Point(660, 526);
            this.VersionLinkLabel.Name = "VersionLinkLabel";
            this.VersionLinkLabel.Size = new System.Drawing.Size(204, 15);
            this.VersionLinkLabel.TabIndex = 0;
            this.VersionLinkLabel.TabStop = true;
            this.VersionLinkLabel.Text = "Cryptokey-evaluator build version 0.1";
            this.VersionLinkLabel.Click += new System.EventHandler(this.VersionlinkLabel_Click);
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.AlgLabel);
            this.InputGroupBox.Controls.Add(this.AlgTextBox);
            this.InputGroupBox.Controls.Add(this.button2);
            this.InputGroupBox.Controls.Add(this.CypherOpenFileButton);
            this.InputGroupBox.Controls.Add(this.HackManagmentGroupBox);
            this.InputGroupBox.Controls.Add(this.SecretKeyLabel);
            this.InputGroupBox.Controls.Add(this.SecretKeyTextBox);
            this.InputGroupBox.Controls.Add(this.CypherTextBox);
            this.InputGroupBox.Controls.Add(this.CypherLabel);
            this.InputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(508, 274);
            this.InputGroupBox.TabIndex = 1;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Область вводу";
            // 
            // AlgLabel
            // 
            this.AlgLabel.AutoSize = true;
            this.AlgLabel.Location = new System.Drawing.Point(25, 111);
            this.AlgLabel.Name = "AlgLabel";
            this.AlgLabel.Size = new System.Drawing.Size(62, 15);
            this.AlgLabel.TabIndex = 15;
            this.AlgLabel.Text = "Алгоритм";
            // 
            // AlgTextBox
            // 
            this.AlgTextBox.Location = new System.Drawing.Point(7, 129);
            this.AlgTextBox.Name = "AlgTextBox";
            this.AlgTextBox.Size = new System.Drawing.Size(233, 23);
            this.AlgTextBox.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(246, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // CypherOpenFileButton
            // 
            this.CypherOpenFileButton.BackColor = System.Drawing.Color.Transparent;
            this.CypherOpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CypherOpenFileButton.Location = new System.Drawing.Point(246, 41);
            this.CypherOpenFileButton.Name = "CypherOpenFileButton";
            this.CypherOpenFileButton.Size = new System.Drawing.Size(26, 23);
            this.CypherOpenFileButton.TabIndex = 12;
            this.CypherOpenFileButton.UseVisualStyleBackColor = false;
            this.CypherOpenFileButton.Click += new System.EventHandler(this.CypherOpenFileButton_Click);
            // 
            // HackManagmentGroupBox
            // 
            this.HackManagmentGroupBox.Controls.Add(this.FindPassCheckBox);
            this.HackManagmentGroupBox.Controls.Add(this.TimeCheckBox);
            this.HackManagmentGroupBox.Controls.Add(this.MaskCheckBox);
            this.HackManagmentGroupBox.Controls.Add(this.FastCheckBox);
            this.HackManagmentGroupBox.Controls.Add(this.FindPassRadioButton);
            this.HackManagmentGroupBox.Controls.Add(this.CrackingResRadioButton);
            this.HackManagmentGroupBox.Location = new System.Drawing.Point(278, 22);
            this.HackManagmentGroupBox.Name = "HackManagmentGroupBox";
            this.HackManagmentGroupBox.Size = new System.Drawing.Size(224, 246);
            this.HackManagmentGroupBox.TabIndex = 10;
            this.HackManagmentGroupBox.TabStop = false;
            this.HackManagmentGroupBox.Text = "Алгоритмізація перевірки";
            // 
            // FindPassCheckBox
            // 
            this.FindPassCheckBox.AutoSize = true;
            this.FindPassCheckBox.Location = new System.Drawing.Point(25, 145);
            this.FindPassCheckBox.Name = "FindPassCheckBox";
            this.FindPassCheckBox.Size = new System.Drawing.Size(142, 19);
            this.FindPassCheckBox.TabIndex = 15;
            this.FindPassCheckBox.Text = "Знайти ключ в файлі";
            this.FindPassCheckBox.UseVisualStyleBackColor = true;
            // 
            // TimeCheckBox
            // 
            this.TimeCheckBox.AutoSize = true;
            this.TimeCheckBox.Enabled = false;
            this.TimeCheckBox.Location = new System.Drawing.Point(25, 70);
            this.TimeCheckBox.Name = "TimeCheckBox";
            this.TimeCheckBox.Size = new System.Drawing.Size(121, 19);
            this.TimeCheckBox.TabIndex = 14;
            this.TimeCheckBox.Text = "Розрахунок часу ";
            this.TimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // MaskCheckBox
            // 
            this.MaskCheckBox.AutoSize = true;
            this.MaskCheckBox.Location = new System.Drawing.Point(25, 120);
            this.MaskCheckBox.Name = "MaskCheckBox";
            this.MaskCheckBox.Size = new System.Drawing.Size(140, 19);
            this.MaskCheckBox.TabIndex = 13;
            this.MaskCheckBox.Text = "Знайти маску ключа";
            this.MaskCheckBox.UseVisualStyleBackColor = true;
            // 
            // FastCheckBox
            // 
            this.FastCheckBox.AutoSize = true;
            this.FastCheckBox.Location = new System.Drawing.Point(25, 45);
            this.FastCheckBox.Name = "FastCheckBox";
            this.FastCheckBox.Size = new System.Drawing.Size(138, 19);
            this.FastCheckBox.TabIndex = 8;
            this.FastCheckBox.Text = "Швидка переревірка";
            this.FastCheckBox.UseVisualStyleBackColor = true;
            this.FastCheckBox.CheckedChanged += new System.EventHandler(this.FastCheckBox_CheckedChanged);
            // 
            // FindPassRadioButton
            // 
            this.FindPassRadioButton.AutoSize = true;
            this.FindPassRadioButton.Location = new System.Drawing.Point(6, 95);
            this.FindPassRadioButton.Name = "FindPassRadioButton";
            this.FindPassRadioButton.Size = new System.Drawing.Size(100, 19);
            this.FindPassRadioButton.TabIndex = 11;
            this.FindPassRadioButton.TabStop = true;
            this.FindPassRadioButton.Text = "Аналіз ключа";
            this.FindPassRadioButton.UseVisualStyleBackColor = true;
            this.FindPassRadioButton.CheckedChanged += new System.EventHandler(this.FindPassRadioButton_CheckedChanged);
            // 
            // CrackingResRadioButton
            // 
            this.CrackingResRadioButton.AutoSize = true;
            this.CrackingResRadioButton.Location = new System.Drawing.Point(6, 20);
            this.CrackingResRadioButton.Name = "CrackingResRadioButton";
            this.CrackingResRadioButton.Size = new System.Drawing.Size(117, 19);
            this.CrackingResRadioButton.TabIndex = 12;
            this.CrackingResRadioButton.TabStop = true;
            this.CrackingResRadioButton.Text = "Повна перевірка";
            this.CrackingResRadioButton.UseVisualStyleBackColor = true;
            this.CrackingResRadioButton.CheckedChanged += new System.EventHandler(this.CrackingResRadioButton_CheckedChanged);
            // 
            // SecretKeyLabel
            // 
            this.SecretKeyLabel.AutoSize = true;
            this.SecretKeyLabel.Location = new System.Drawing.Point(25, 68);
            this.SecretKeyLabel.Name = "SecretKeyLabel";
            this.SecretKeyLabel.Size = new System.Drawing.Size(88, 15);
            this.SecretKeyLabel.TabIndex = 4;
            this.SecretKeyLabel.Text = "Таємний ключ";
            // 
            // SecretKeyTextBox
            // 
            this.SecretKeyTextBox.Location = new System.Drawing.Point(7, 86);
            this.SecretKeyTextBox.Name = "SecretKeyTextBox";
            this.SecretKeyTextBox.Size = new System.Drawing.Size(233, 23);
            this.SecretKeyTextBox.TabIndex = 3;
            // 
            // CypherTextBox
            // 
            this.CypherTextBox.Location = new System.Drawing.Point(7, 42);
            this.CypherTextBox.Name = "CypherTextBox";
            this.CypherTextBox.Size = new System.Drawing.Size(233, 23);
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
            // AttackButton
            // 
            this.AttackButton.Location = new System.Drawing.Point(7, 251);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(135, 23);
            this.AttackButton.TabIndex = 11;
            this.AttackButton.Text = "Провести атаку";
            this.AttackButton.UseVisualStyleBackColor = true;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(209, 251);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(116, 23);
            this.Startbutton.TabIndex = 1;
            this.Startbutton.Text = "Почати перевірку";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResTreeView);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MarkLabel);
            this.groupBox1.Controls.Add(this.ResultProgressBar);
            this.groupBox1.Controls.Add(this.Startbutton);
            this.groupBox1.Controls.Add(this.AttackButton);
            this.groupBox1.Location = new System.Drawing.Point(526, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 511);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результати";
            // 
            // ResTreeView
            // 
            this.ResTreeView.Location = new System.Drawing.Point(7, 280);
            this.ResTreeView.Name = "ResTreeView";
            this.ResTreeView.Size = new System.Drawing.Size(325, 225);
            this.ResTreeView.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(104, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Оцінка";
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MarkLabel.Location = new System.Drawing.Point(143, 117);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(48, 59);
            this.MarkLabel.TabIndex = 2;
            this.MarkLabel.Text = "0";
            // 
            // ResultProgressBar
            // 
            this.ResultProgressBar.Location = new System.Drawing.Point(6, 31);
            this.ResultProgressBar.Name = "ResultProgressBar";
            this.ResultProgressBar.Size = new System.Drawing.Size(326, 23);
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
            this.PowerShellTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PowerShellTextBox.Size = new System.Drawing.Size(496, 203);
            this.PowerShellTextBox.TabIndex = 9;
            this.PowerShellTextBox.Text = "PS cryptokey-evaluator> wait...";
            this.PowerShellTextBox.Click += new System.EventHandler(this.PowerShellTextBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PowerShellTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 231);
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
            this.ClientSize = new System.Drawing.Size(869, 550);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.ProgressBar ResultProgressBar;
        private System.Windows.Forms.TextBox PowerShellTextBox;
        private System.Windows.Forms.Label MarkLabel;
        private System.Windows.Forms.GroupBox HackManagmentGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AttackButton;
        private System.Windows.Forms.RadioButton FindPassRadioButton;
        private System.Windows.Forms.OpenFileDialog CypherOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog SecKeyOpenFileDialog;
        private System.Windows.Forms.Button CypherOpenFileButton;
        private System.Windows.Forms.OpenFileDialog SecretOpenFileDialog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton CrackingResRadioButton;
        private System.Windows.Forms.CheckBox MaskCheckBox;
        private System.Windows.Forms.Label AlgLabel;
        private System.Windows.Forms.TextBox AlgTextBox;
        private System.Windows.Forms.TreeView ResTreeView;
        private System.Windows.Forms.CheckBox TimeCheckBox;
        private System.Windows.Forms.CheckBox FindPassCheckBox;
    }
}

