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
        private bool isDebug; //This flag specifies debug mode, meaning logs will be written into Output console
        private SpeechSynthesizer speechSynthesizer; //Provides access to the functionality of an installed a speech synthesis engine.

        public SpeachLibraryTestForm()
        {
            try
            {
                speechSynthesizer = new SpeechSynthesizer();
                isDebug = true;
                InitializeComponent();
            }
            catch (Exception ex){
                //Shows error message
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Display SpeechSynthesizer Properties: gender, age
        /// </summary>
        private void DisplaySpeechSynthesizerProperties() {
            //VoiceGender.
            String gender = speechSynthesizer.Voice.Gender.ToString();
            String age = speechSynthesizer.Voice.Age.ToString();
            System.Diagnostics.Debug.Write($"Speech Synthesizer properties:\n gender: {gender}, age: {age}");
        }

        /// <summary>
        /// Close button event handler - closes the window 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            WriteDebug(sender, System.Reflection.MethodBase.GetCurrentMethod().Name);
            this.Close();
        }

        /// <summary>
        /// Method that writes the log into Output console in case isDebug flag is TRUE.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="message"></param>
        private void WriteDebug(object sender, string message) {
            //Debug only:
            if (isDebug) {
                System.Diagnostics.Debug.Print($"DEBUG: {sender.GetType().Name} => {message}");
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
            WriteDebug(sender, System.Reflection.MethodBase.GetCurrentMethod().Name);

            String phrase = GetUserInput(); //get the frase user wants to play

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
            WriteDebug(sender, System.Reflection.MethodBase.GetCurrentMethod().Name); //Debug only
            textBoxUserInput.Text = "";
        }

        //End of class
    }
}
