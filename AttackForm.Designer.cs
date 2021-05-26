
namespace cryptokey_evaluator
{
    partial class AttackForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HashCatRadioButton = new System.Windows.Forms.RadioButton();
            this.JohnRadioButton = new System.Windows.Forms.RadioButton();
            this.MaskAttackCheckBox = new System.Windows.Forms.CheckBox();
            this.BruteForceAttackCheckBox = new System.Windows.Forms.CheckBox();
            this.DictAttackCheckBox = new System.Windows.Forms.CheckBox();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ThingTextBox = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.CyphTextBox = new System.Windows.Forms.TextBox();
            this.AttackButton = new System.Windows.Forms.Button();
            this.AlgoLabel = new System.Windows.Forms.Label();
            this.AlgoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HashCatRadioButton
            // 
            this.HashCatRadioButton.AutoSize = true;
            this.HashCatRadioButton.Location = new System.Drawing.Point(119, 12);
            this.HashCatRadioButton.Name = "HashCatRadioButton";
            this.HashCatRadioButton.Size = new System.Drawing.Size(68, 19);
            this.HashCatRadioButton.TabIndex = 0;
            this.HashCatRadioButton.Text = "Hashcat";
            this.HashCatRadioButton.UseVisualStyleBackColor = true;
            this.HashCatRadioButton.CheckedChanged += new System.EventHandler(this.HashCatRadioButton_CheckedChanged);
            // 
            // JohnRadioButton
            // 
            this.JohnRadioButton.AutoSize = true;
            this.JohnRadioButton.Checked = true;
            this.JohnRadioButton.Location = new System.Drawing.Point(10, 12);
            this.JohnRadioButton.Name = "JohnRadioButton";
            this.JohnRadioButton.Size = new System.Drawing.Size(103, 19);
            this.JohnRadioButton.TabIndex = 1;
            this.JohnRadioButton.TabStop = true;
            this.JohnRadioButton.Text = "JohnTheRipper";
            this.JohnRadioButton.UseVisualStyleBackColor = true;
            this.JohnRadioButton.CheckedChanged += new System.EventHandler(this.JohnRadioButton_CheckedChanged);
            // 
            // MaskAttackCheckBox
            // 
            this.MaskAttackCheckBox.AutoSize = true;
            this.MaskAttackCheckBox.Location = new System.Drawing.Point(6, 47);
            this.MaskAttackCheckBox.Name = "MaskAttackCheckBox";
            this.MaskAttackCheckBox.Size = new System.Drawing.Size(108, 19);
            this.MaskAttackCheckBox.TabIndex = 2;
            this.MaskAttackCheckBox.Text = "Атака по масці";
            this.MaskAttackCheckBox.UseVisualStyleBackColor = true;
            this.MaskAttackCheckBox.CheckedChanged += new System.EventHandler(this.MaskAttackCheckBox_CheckedChanged);
            // 
            // BruteForceAttackCheckBox
            // 
            this.BruteForceAttackCheckBox.AutoSize = true;
            this.BruteForceAttackCheckBox.Location = new System.Drawing.Point(6, 22);
            this.BruteForceAttackCheckBox.Name = "BruteForceAttackCheckBox";
            this.BruteForceAttackCheckBox.Size = new System.Drawing.Size(120, 19);
            this.BruteForceAttackCheckBox.TabIndex = 3;
            this.BruteForceAttackCheckBox.Text = "Brute-Force атака";
            this.BruteForceAttackCheckBox.UseVisualStyleBackColor = true;
            this.BruteForceAttackCheckBox.CheckedChanged += new System.EventHandler(this.BruteForceCheckBox_CheckedChanged);
            // 
            // DictAttackCheckBox
            // 
            this.DictAttackCheckBox.AutoSize = true;
            this.DictAttackCheckBox.Location = new System.Drawing.Point(6, 72);
            this.DictAttackCheckBox.Name = "DictAttackCheckBox";
            this.DictAttackCheckBox.Size = new System.Drawing.Size(129, 19);
            this.DictAttackCheckBox.TabIndex = 4;
            this.DictAttackCheckBox.Text = "Атака по словнику";
            this.DictAttackCheckBox.UseVisualStyleBackColor = true;
            this.DictAttackCheckBox.CheckedChanged += new System.EventHandler(this.DictAttackCheckBox_CheckedChanged);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(121, 50);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(217, 23);
            this.PathTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ThingTextBox);
            this.groupBox1.Controls.Add(this.BruteForceAttackCheckBox);
            this.groupBox1.Controls.Add(this.MaskAttackCheckBox);
            this.groupBox1.Controls.Add(this.DictAttackCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 127);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип атаки";
            // 
            // ThingTextBox
            // 
            this.ThingTextBox.Location = new System.Drawing.Point(6, 98);
            this.ThingTextBox.Name = "ThingTextBox";
            this.ThingTextBox.Size = new System.Drawing.Size(185, 23);
            this.ThingTextBox.TabIndex = 5;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(4, 53);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(111, 15);
            this.PathLabel.TabIndex = 9;
            this.PathLabel.Text = "Шлях до програми";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(4, 82);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(76, 15);
            this.TextLabel.TabIndex = 11;
            this.TextLabel.Text = "Шифротекст";
            // 
            // CyphTextBox
            // 
            this.CyphTextBox.Location = new System.Drawing.Point(86, 79);
            this.CyphTextBox.Name = "CyphTextBox";
            this.CyphTextBox.Size = new System.Drawing.Size(252, 23);
            this.CyphTextBox.TabIndex = 10;
            // 
            // AttackButton
            // 
            this.AttackButton.Location = new System.Drawing.Point(263, 237);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(75, 23);
            this.AttackButton.TabIndex = 12;
            this.AttackButton.Text = "Атакувати";
            this.AttackButton.UseVisualStyleBackColor = true;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // AlgoLabel
            // 
            this.AlgoLabel.AutoSize = true;
            this.AlgoLabel.Location = new System.Drawing.Point(4, 111);
            this.AlgoLabel.Name = "AlgoLabel";
            this.AlgoLabel.Size = new System.Drawing.Size(62, 15);
            this.AlgoLabel.TabIndex = 14;
            this.AlgoLabel.Text = "Алгоритм";
            // 
            // AlgoTextBox
            // 
            this.AlgoTextBox.Location = new System.Drawing.Point(72, 108);
            this.AlgoTextBox.Name = "AlgoTextBox";
            this.AlgoTextBox.Size = new System.Drawing.Size(266, 23);
            this.AlgoTextBox.TabIndex = 13;
            // 
            // AttackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 270);
            this.Controls.Add(this.AlgoLabel);
            this.Controls.Add(this.AlgoTextBox);
            this.Controls.Add(this.AttackButton);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.CyphTextBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.JohnRadioButton);
            this.Controls.Add(this.HashCatRadioButton);
            this.Name = "AttackForm";
            this.Text = "AttackForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton HashCatRadioButton;
        private System.Windows.Forms.RadioButton JohnRadioButton;
        private System.Windows.Forms.CheckBox MaskAttackCheckBox;
        private System.Windows.Forms.CheckBox BruteForceCheckBox;
        private System.Windows.Forms.CheckBox DictAttackCheckBox;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ThingTextBox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.TextBox CyphTextBox;
        private System.Windows.Forms.Button AttackButton;
        private System.Windows.Forms.CheckBox BruteForceAttackCheckBox;
        private System.Windows.Forms.Label AlgoLabel;
        private System.Windows.Forms.TextBox AlgoTextBox;
    }
}