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
        /// Set isDebug mode.
        /// Enable/disable logs output visibility.
        /// </summary>
        private void SetDebugMode() {
            isDebug = checkBoxDebugMode.Checked;
            groupBoxLogs.Visible = isDebug;
        }

        /// <summary>
        /// Display SpeechSynthesizer Properties: gender, age
        /// </summary>
        private void DisplaySpeechSynthesizerProperties() {

            //Speech Synthesizer properties:
            string gender = speechSynthesizer.Voice.Gender.ToString();
            string age = speechSynthesizer.Voice.Age.ToString();
            string rate = speechSynthesizer.Rate.ToString();
            string volume = speechSynthesizer.Volume.ToString();
            string state = speechSynthesizer.State.ToString();

            //Debug only:
            if (isDebug) {
                string log = $"\nSpeech Synthesizer properties => gender: {gender}, age: {age}, rate: {rate}, volume: {volume}, state: {state}";
                WriteDebug(this, System.Reflection.MethodBase.GetCurrentMethod().Name, log);
            }
        }

        /// <summary>
        /// Close button event handler - closes the window 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            WriteDebug(sender, System.Reflection.MethodBase.GetCurrentMethod().Name, e.ToString()); //Debug only
            this.Close(); //Close the app
        }

        /// <summary>
        /// Method that writes the log into Output console in case isDebug flag is TRUE.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="message"></param>
        private void WriteDebug(object sender, string message, string parameter = "") {
            //Debug only:
            if (isDebug) {
                DateTime time = DateTime.Now;
                string log = $"{time.Date.ToString("dd/MM/yyyy")} - {time.Hour}:{time.Minute}:{time.Second} - DEBUG: {sender.GetType().Name} => {message}, parameter: {parameter}\n";
                System.Diagnostics.Debug.Print(log);
                textBoxLogs.AppendText(log);
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
        /// Plays the text from textBoxUserInput control (or sample text in case isTest == true).
        /// Shows error message in case textBoxUserInput is empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            PlayText(sender, false); //Play the text entered (or sample text in case isTest == true)
        }

        /// <summary>
        /// Play text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="isTest"></param>
        private void PlayText(object sender, bool isTest = false) {

            string phrase = "";

            if (isTest == false)
            {
                phrase = GetUserInput(); //get the frase user wants to play                
            }
            else {
                //Sample text
                phrase = "As designers attempting to creating functional work, " +
                    "oftentimes we are required to make our designs look as finished as possible. " +
                    "For example, if you are designing a brand new website for someone, " +
                    "most times you will have to make sure the prototype looks finished by inserting text or " +
                    "photos or what have you.";
            }

            WriteDebug(sender, System.Reflection.MethodBase.GetCurrentMethod().Name, phrase); //Debug only

            if (!phrase.Equals(""))
            {
                //Debug only:
                if (isDebug)
                {
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

        /// <summary>
        /// Event handler that activated when user closes "Properties" tab.
        /// Warning message will be displayed in case program properties were changed but were not applayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPageProperties_Leave(object sender, EventArgs e)
        {
            WriteDebug(sender, System.Reflection.MethodBase.GetCurrentMethod().Name, e.ToString()); //Debug only

            if (propertieChanged) {
                MessageBox.Show("Program properties were changed.\nPlease go back to 'Properties' tab and press on 'Applay' button if you want to applay a new changes.",
                    "WARNING",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Play sample text event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlaySample_Click(object sender, EventArgs e)
        {
            WriteDebug(sender, System.Reflection.MethodBase.GetCurrentMethod().Name, propertieChanged.ToString()); //Debug only
            PlayText(sender, true);
        }

        //End of class
    }
}
