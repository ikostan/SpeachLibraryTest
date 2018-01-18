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
            this.tabPageManualPlayer = new System.Windows.Forms.TabPage();
            this.groupBoxPlayer = new System.Windows.Forms.GroupBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.tabPagePlayFromText = new System.Windows.Forms.TabPage();
            this.tabPageProperties = new System.Windows.Forms.TabPage();
            this.groupBoxPlayerProperties = new System.Windows.Forms.GroupBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonGenderNotSet = new System.Windows.Forms.RadioButton();
            this.radioButtonGenderNeutral = new System.Windows.Forms.RadioButton();
            this.radioButtonGenderfemale = new System.Windows.Forms.RadioButton();
            this.radioButtonGenderMale = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonApplayChanges = new System.Windows.Forms.Button();
            this.groupBoxDebugMode = new System.Windows.Forms.GroupBox();
            this.checkBoxDebugMode = new System.Windows.Forms.CheckBox();
            this.textBoxLogs = new System.Windows.Forms.TextBox();
            this.groupBoxLogs = new System.Windows.Forms.GroupBox();
            this.buttonPlaySample = new System.Windows.Forms.Button();
            this.tabControlManualPlayer.SuspendLayout();
            this.tabPageManualPlayer.SuspendLayout();
            this.groupBoxPlayer.SuspendLayout();
            this.tabPageProperties.SuspendLayout();
            this.groupBoxPlayerProperties.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxDebugMode.SuspendLayout();
            this.groupBoxLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlManualPlayer
            // 
            this.tabControlManualPlayer.Controls.Add(this.tabPageManualPlayer);
            this.tabControlManualPlayer.Controls.Add(this.tabPagePlayFromText);
            this.tabControlManualPlayer.Controls.Add(this.tabPageProperties);
            this.tabControlManualPlayer.Location = new System.Drawing.Point(12, 12);
            this.tabControlManualPlayer.Name = "tabControlManualPlayer";
            this.tabControlManualPlayer.SelectedIndex = 0;
            this.tabControlManualPlayer.Size = new System.Drawing.Size(664, 331);
            this.tabControlManualPlayer.TabIndex = 7;
            // 
            // tabPageManualPlayer
            // 
            this.tabPageManualPlayer.Controls.Add(this.groupBoxPlayer);
            this.tabPageManualPlayer.Location = new System.Drawing.Point(4, 22);
            this.tabPageManualPlayer.Name = "tabPageManualPlayer";
            this.tabPageManualPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManualPlayer.Size = new System.Drawing.Size(656, 305);
            this.tabPageManualPlayer.TabIndex = 0;
            this.tabPageManualPlayer.Text = "Manual Player";
            this.tabPageManualPlayer.UseVisualStyleBackColor = true;
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
            // tabPagePlayFromText
            // 
            this.tabPagePlayFromText.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlayFromText.Name = "tabPagePlayFromText";
            this.tabPagePlayFromText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlayFromText.Size = new System.Drawing.Size(656, 305);
            this.tabPagePlayFromText.TabIndex = 1;
            this.tabPagePlayFromText.Text = "Play Text File";
            this.tabPagePlayFromText.UseVisualStyleBackColor = true;
            // 
            // tabPageProperties
            // 
            this.tabPageProperties.Controls.Add(this.buttonPlaySample);
            this.tabPageProperties.Controls.Add(this.groupBoxPlayerProperties);
            this.tabPageProperties.Controls.Add(this.buttonApplayChanges);
            this.tabPageProperties.Location = new System.Drawing.Point(4, 22);
            this.tabPageProperties.Name = "tabPageProperties";
            this.tabPageProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProperties.Size = new System.Drawing.Size(656, 305);
            this.tabPageProperties.TabIndex = 2;
            this.tabPageProperties.Text = "Properties";
            this.tabPageProperties.UseVisualStyleBackColor = true;
            this.tabPageProperties.Leave += new System.EventHandler(this.tabPageProperties_Leave);
            // 
            // groupBoxPlayerProperties
            // 
            this.groupBoxPlayerProperties.Controls.Add(this.groupBoxDebugMode);
            this.groupBoxPlayerProperties.Controls.Add(this.groupBoxGender);
            this.groupBoxPlayerProperties.Location = new System.Drawing.Point(20, 15);
            this.groupBoxPlayerProperties.Name = "groupBoxPlayerProperties";
            this.groupBoxPlayerProperties.Size = new System.Drawing.Size(620, 248);
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
            this.groupBoxGender.Location = new System.Drawing.Point(15, 19);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(94, 140);
            this.groupBoxGender.TabIndex = 0;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender:";
            this.groupBoxGender.Enter += new System.EventHandler(this.SetingsChanged);
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
            this.buttonClose.Location = new System.Drawing.Point(581, 429);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonApplayChanges
            // 
            this.buttonApplayChanges.Location = new System.Drawing.Point(565, 276);
            this.buttonApplayChanges.Name = "buttonApplayChanges";
            this.buttonApplayChanges.Size = new System.Drawing.Size(75, 23);
            this.buttonApplayChanges.TabIndex = 1;
            this.buttonApplayChanges.Text = "Applay";
            this.buttonApplayChanges.UseVisualStyleBackColor = true;
            this.buttonApplayChanges.Click += new System.EventHandler(this.buttonApplayChanges_Click);
            // 
            // groupBoxDebugMode
            // 
            this.groupBoxDebugMode.Controls.Add(this.checkBoxDebugMode);
            this.groupBoxDebugMode.Location = new System.Drawing.Point(15, 166);
            this.groupBoxDebugMode.Name = "groupBoxDebugMode";
            this.groupBoxDebugMode.Size = new System.Drawing.Size(94, 66);
            this.groupBoxDebugMode.TabIndex = 2;
            this.groupBoxDebugMode.TabStop = false;
            this.groupBoxDebugMode.Text = "Debug Mode:";
            this.groupBoxDebugMode.Enter += new System.EventHandler(this.SetingsChanged);
            // 
            // checkBoxDebugMode
            // 
            this.checkBoxDebugMode.AutoSize = true;
            this.checkBoxDebugMode.Location = new System.Drawing.Point(22, 30);
            this.checkBoxDebugMode.Name = "checkBoxDebugMode";
            this.checkBoxDebugMode.Size = new System.Drawing.Size(48, 17);
            this.checkBoxDebugMode.TabIndex = 0;
            this.checkBoxDebugMode.Text = "True";
            this.checkBoxDebugMode.UseVisualStyleBackColor = true;
            // 
            // textBoxLogs
            // 
            this.textBoxLogs.Location = new System.Drawing.Point(6, 19);
            this.textBoxLogs.Multiline = true;
            this.textBoxLogs.Name = "textBoxLogs";
            this.textBoxLogs.ReadOnly = true;
            this.textBoxLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLogs.Size = new System.Drawing.Size(644, 40);
            this.textBoxLogs.TabIndex = 8;
            // 
            // groupBoxLogs
            // 
            this.groupBoxLogs.Controls.Add(this.textBoxLogs);
            this.groupBoxLogs.Location = new System.Drawing.Point(12, 349);
            this.groupBoxLogs.Name = "groupBoxLogs";
            this.groupBoxLogs.Size = new System.Drawing.Size(660, 65);
            this.groupBoxLogs.TabIndex = 9;
            this.groupBoxLogs.TabStop = false;
            this.groupBoxLogs.Text = "Logs:";
            this.groupBoxLogs.Visible = false;
            // 
            // buttonPlaySample
            // 
            this.buttonPlaySample.Location = new System.Drawing.Point(484, 276);
            this.buttonPlaySample.Name = "buttonPlaySample";
            this.buttonPlaySample.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaySample.TabIndex = 7;
            this.buttonPlaySample.Text = "Play Sample";
            this.buttonPlaySample.UseVisualStyleBackColor = true;
            this.buttonPlaySample.Click += new System.EventHandler(this.buttonPlaySample_Click);
            // 
            // SpeachLibraryTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 464);
            this.Controls.Add(this.groupBoxLogs);
            this.Controls.Add(this.tabControlManualPlayer);
            this.Controls.Add(this.buttonClose);
            this.Name = "SpeachLibraryTestForm";
            this.Text = "Speach Library Test";
            this.tabControlManualPlayer.ResumeLayout(false);
            this.tabPageManualPlayer.ResumeLayout(false);
            this.groupBoxPlayer.ResumeLayout(false);
            this.groupBoxPlayer.PerformLayout();
            this.tabPageProperties.ResumeLayout(false);
            this.groupBoxPlayerProperties.ResumeLayout(false);
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxDebugMode.ResumeLayout(false);
            this.groupBoxDebugMode.PerformLayout();
            this.groupBoxLogs.ResumeLayout(false);
            this.groupBoxLogs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlManualPlayer;
        private System.Windows.Forms.TabPage tabPageManualPlayer;
        private System.Windows.Forms.GroupBox groupBoxPlayer;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxUserInput;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TabPage tabPagePlayFromText;
        private System.Windows.Forms.TabPage tabPageProperties;
        private System.Windows.Forms.GroupBox groupBoxPlayerProperties;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonGenderNotSet;
        private System.Windows.Forms.RadioButton radioButtonGenderNeutral;
        private System.Windows.Forms.RadioButton radioButtonGenderfemale;
        private System.Windows.Forms.RadioButton radioButtonGenderMale;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonApplayChanges;
        private System.Windows.Forms.GroupBox groupBoxDebugMode;
        private System.Windows.Forms.CheckBox checkBoxDebugMode;
        private System.Windows.Forms.TextBox textBoxLogs;
        private System.Windows.Forms.GroupBox groupBoxLogs;
        private System.Windows.Forms.Button buttonPlaySample;
    }
}

