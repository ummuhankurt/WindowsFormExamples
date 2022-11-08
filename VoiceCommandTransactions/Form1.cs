using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using SpeechLib;

namespace VoiceCommandTransactions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpVoice spVoice = new SpVoice();
        private void button1_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine speechRecognitionEngine = new SpeechRecognitionEngine();
            Grammar grammar = new DictationGrammar();
            speechRecognitionEngine.LoadGrammar(grammar);
            try
            {
                button1.Text = "Konuşun";
                speechRecognitionEngine.SetInputToDefaultAudioDevice(); // Ses giriş cihazını ayarla.
                RecognitionResult recognitionResult = speechRecognitionEngine.Recognize(); //konuşulan ifadeyi tanı.
                button1.Text = recognitionResult.Text;
                spVoice.Speak(button1.Text);
            }
            catch (Exception)
            {

                button1.Text = "Hata";
            }
        }

        private void button1_TextChanged(object sender, EventArgs e)
        {
            if(button1.Text == "What is your like do")
            {
                label1.Text = "I like coding, and theatre. I like play computer game";
                spVoice.Speak(label1.Text);
            }
            if (button1.Text == "Water")
            {
                label1.Text = "Su";
            }
            if (button1.Text == "Paint")
            {
                System.Diagnostics.Process.Start("Mspaint.exe");
            }
        }
    }
}
