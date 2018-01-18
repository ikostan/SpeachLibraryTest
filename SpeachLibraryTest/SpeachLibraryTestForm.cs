using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeachLibraryTest
{
    public partial class SpeachLibraryTestForm : Form
    {
        private bool propertieChanged; //Indicates that one of the program properties was changed by user
        private bool isDebug; //This flag specifies debug mode, meaning logs will be written into Output console
        private SpeechSynthesizer speechSynthesizer; //Provides access to the functionality of an installed a speech synthesis engine.

        public SpeachLibraryTestForm()
        {
            try
            {
                speechSynthesizer = new SpeechSynthesizer();
                propertieChanged = false;
                InitializeComponent();
                SetDebugMode(); //Set debug mode
            }
            catch (Exception ex) {
                //Shows error message
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set VoiceGender: Male, Female, Not Set, Neutral
        /// </summary>
        private void SetVoiceGender(){

            if (radioButtonGenderMale.Checked)
            {
                speechSynthesizer.SelectVoiceByHints(VoiceGender.Male);
            }
            else if (radioButtonGenderfemale.Checked)
            {
                speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
            }
            else if (radioButtonGenderNeutral.Checked)
            {
                speechSynthesizer.SelectVoiceByHints(VoiceGender.Neutral);
            }
            else {
                speechSynthesizer.SelectVoiceByHints(VoiceGender.NotSet);
            }
        }

        /// <summary>
        /// Set isDebug mode glag
        /// </summary>
        private void SetDebugMode() {
            isDebug = checkBoxDebugMode.Checked;
        }

        /// <summary>
        /// Display SpeechSynthesizer Properties: gender, age
        /// </summary>
        private void DisplaySpeechSynthesizerProperties() {
            string gender = speechSynthesizer.Voice.Gender.ToString();
            string age = speechSynthesizer.Voice.Age.ToString();
            string rate = speechSynthesizer.Rate.ToString();
            string volume = speechSynthesizer.Volume.ToString();
            string state = speechSynthesizer.State.ToString();

            System.Diagnostics.Debug.WriteLine(
                $"Speech Synthesizer properties: gender: {gender}, age: {age}, rate: {rate}, volume: {volume}, state: {state}");
        }

        /// <summary>
        /// Close button event handler - closes the window 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            WriteDebug(sender, System.Reflection.MethodBase.GetCurrentMethod().Name, e.ToString()); //Debug only
            this.Close();
        }

        /// <summary>
        /// Method that writes the log into Output console in case isDebug flag is TRUE.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="message"></param>
        private void WriteDebug(object sender, string message, string parameter = "") {
            //Debug only:
            if (isDebug) {
                System.Diagnostics.Debug.Print($"DEBUG: {sender.GetType().Name} => {message}, parameter: {parameter}");
            }
        }

        /// <summary>
        /// 1. Get user input from the textBoxUserInput control.
        /// 2. Trims the string.
        /// 3. Returns the result.
        /// </summary>
        /// <returns></returns>
        private string GetUserInput() {
            string userInput = textBoxUserInput.Text.ToString().Trim();
            //WriteDebug(System.Reflection.MethodBase.GetCurrentMethod(), userInput); //Debug only
            return userInput;
        }

        /// <summary>
        /// Event handler for buttonPlay control.
        /// Plays the text from textBoxUserInput control.
        /// Shows error message in case textBoxUserInput is empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //Debug only:
            DisplaySpeechSynthesizerProperties();

            String phrase = GetUserInput(); //get the frase user wants to play

            WriteDebug(sender, System.Reflection.MethodBase.GetCurrentMethod().Name, phrase); //Debug only

            if (!phrase.Equals(""))
            {
                //Debug only:
                if (isDebug) {
                    System.Diagnostics.Debug.Print($"DEBUG: phrase to play => {phrase}");
                }

                speechSynthesizer.Speak(phrase); //Play the phrase
            }
            else
            {
                //Set input field in focus
                textBoxUserInput.Focus();
                //Shows error message
                MessageBox.Show(
                    "Empty string is not allowed. Please re-enter.", 
                    "ERROR", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event handler for buttonClear control.
        /// Clears everything from textBoxUserInput control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            WriteDebug(sender, System.Reflection.MethodBase.GetCurrentMethod().Name, "clear user input"); //Debug only
            textBoxUserInput.Text = "";
        }

        /// <summary>
        /// Event handler for buttonApplayChanges control.
        /// Set a new properties.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonApplayChanges_Click(object sender, EventArgs e)
        {
            WriteDebug(sender, System.Reflection.MethodBase.GetCurrentMethod().Name, e.ToString()); //Debug only
            propertieChanged = false;
            SetDebugMode(); //Set debug mode
            SetVoiceGender(); //Set Voice gender
        }

        /// <summary>
        /// SetingsChanged is activated when one of the properties was changed
        /// </summary>
        private void SetingsChanged(object sender, EventArgs e) {
            propertieChanged = true;
            WriteDebug(sender, System.Reflection.MethodBase.GetCurrentMethod().Name, propertieChanged.ToString()); //Debug only
        }

        //End of class
    }
}
