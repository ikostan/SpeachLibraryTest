namespace SpeachLibraryTest
{
    partial class SpeachLibraryTestForm
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
            this.tabControlManualPlayer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxPlayer = new System.Windows.Forms.GroupBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxPlayerProperties = new System.Windows.Forms.GroupBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonGenderNotSet = new System.Windows.Forms.RadioButton();
            this.radioButtonGenderNeutral = new System.Windows.Forms.RadioButton();
            this.radioButtonGenderfemale = new System.Windows.Forms.RadioButton();
            this.radioButtonGenderMale = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabControlManualPlayer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxPlayer.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxPlayerProperties.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlManualPlayer
            // 
            this.tabControlManualPlayer.Controls.Add(this.tabPage1);
            this.tabControlManualPlayer.Controls.Add(this.tabPage2);
            this.tabControlManualPlayer.Controls.Add(this.tabPage3);
            this.tabControlManualPlayer.Location = new System.Drawing.Point(12, 12);
            this.tabControlManualPlayer.Name = "tabControlManualPlayer";
            this.tabControlManualPlayer.SelectedIndex = 0;
            this.tabControlManualPlayer.Size = new System.Drawing.Size(664, 295);
            this.tabControlManualPlayer.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxPlayer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxPlayer
            // 
            this.groupBoxPlayer.Controls.Add(this.labelInstructions);
            this.groupBoxPlayer.Controls.Add(this.buttonClear);
            this.groupBoxPlayer.Controls.Add(this.textBoxUserInput);
            this.groupBoxPlayer.Controls.Add(this.buttonPlay);
            this.groupBoxPlayer.Location = new System.Drawing.Point(17, 16);
            this.groupBoxPlayer.Name = "groupBoxPlayer";
            this.groupBoxPlayer.Size = new System.Drawing.Size(620, 132);
            this.groupBoxPlayer.TabIndex = 5;
            this.groupBoxPlayer.TabStop = false;
            this.groupBoxPlayer.Text = "Player";
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(6, 25);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(202, 13);
            this.labelInstructions.TabIndex = 2;
            this.labelInstructions.Text = "Please enter the phrase you want to play:";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(458, 91);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxUserInput
            // 
            this.textBoxUserInput.Location = new System.Drawing.Point(9, 53);
            this.textBoxUserInput.Name = "textBoxUserInput";
            this.textBoxUserInput.Size = new System.Drawing.Size(605, 20);
            this.textBoxUserInput.TabIndex = 1;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(539, 91);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(656, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBoxPlayerProperties);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(656, 269);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBoxPlayerProperties
            // 
            this.groupBoxPlayerProperties.Controls.Add(this.groupBoxGender);
            this.groupBoxPlayerProperties.Location = new System.Drawing.Point(20, 15);
            this.groupBoxPlayerProperties.Name = "groupBoxPlayerProperties";
            this.groupBoxPlayerProperties.Size = new System.Drawing.Size(620, 237);
            this.groupBoxPlayerProperties.TabIndex = 6;
            this.groupBoxPlayerProperties.TabStop = false;
            this.groupBoxPlayerProperties.Text = "Player properties";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonGenderNotSet);
            this.groupBoxGender.Controls.Add(this.radioButtonGenderNeutral);
            this.groupBoxGender.Controls.Add(this.radioButtonGenderfemale);
            this.groupBoxGender.Controls.Add(this.radioButtonGenderMale);
            this.groupBoxGender.Location = new System.Drawing.Point(20, 31);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(94, 140);
            this.groupBoxGender.TabIndex = 0;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender:";
            // 
            // radioButtonGenderNotSet
            // 
            this.radioButtonGenderNotSet.AutoSize = true;
            this.radioButtonGenderNotSet.Location = new System.Drawing.Point(18, 101);
            this.radioButtonGenderNotSet.Name = "radioButtonGenderNotSet";
            this.radioButtonGenderNotSet.Size = new System.Drawing.Size(61, 17);
            this.radioButtonGenderNotSet.TabIndex = 3;
            this.radioButtonGenderNotSet.Text = "Not Set";
            this.radioButtonGenderNotSet.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenderNeutral
            // 
            this.radioButtonGenderNeutral.AutoSize = true;
            this.radioButtonGenderNeutral.Location = new System.Drawing.Point(18, 77);
            this.radioButtonGenderNeutral.Name = "radioButtonGenderNeutral";
            this.radioButtonGenderNeutral.Size = new System.Drawing.Size(59, 17);
            this.radioButtonGenderNeutral.TabIndex = 2;
            this.radioButtonGenderNeutral.Text = "Neutral";
            this.radioButtonGenderNeutral.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenderfemale
            // 
            this.radioButtonGenderfemale.AutoSize = true;
            this.radioButtonGenderfemale.Location = new System.Drawing.Point(18, 53);
            this.radioButtonGenderfemale.Name = "radioButtonGenderfemale";
            this.radioButtonGenderfemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonGenderfemale.TabIndex = 1;
            this.radioButtonGenderfemale.Text = "Female";
            this.radioButtonGenderfemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenderMale
            // 
            this.radioButtonGenderMale.AutoSize = true;
            this.radioButtonGenderMale.Checked = true;
            this.radioButtonGenderMale.Location = new System.Drawing.Point(18, 30);
            this.radioButtonGenderMale.Name = "radioButtonGenderMale";
            this.radioButtonGenderMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonGenderMale.TabIndex = 0;
            this.radioButtonGenderMale.TabStop = true;
            this.radioButtonGenderMale.Text = "Male";
            this.radioButtonGenderMale.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(597, 313);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // SpeachLibraryTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 348);
            this.Controls.Add(this.tabControlManualPlayer);
            this.Controls.Add(this.buttonClose);
            this.Name = "SpeachLibraryTestForm";
            this.Text = "Speach Library Test";
            this.tabControlManualPlayer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxPlayer.ResumeLayout(false);
            this.groupBoxPlayer.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBoxPlayerProperties.ResumeLayout(false);
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlManualPlayer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxPlayer;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxUserInput;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxPlayerProperties;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonGenderNotSet;
        private System.Windows.Forms.RadioButton radioButtonGenderNeutral;
        private System.Windows.Forms.RadioButton radioButtonGenderfemale;
        private System.Windows.Forms.RadioButton radioButtonGenderMale;
        private System.Windows.Forms.Button buttonClose;
    }
}

