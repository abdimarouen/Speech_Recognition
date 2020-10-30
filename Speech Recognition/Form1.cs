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
using System.Speech.Synthesis;
using System.IO;
using System.Globalization;

namespace Speech_Recognition
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine(new CultureInfo("en-US"));
        SpeechSynthesizer Sarah = new SpeechSynthesizer();
        SpeechRecognitionEngine startlistening = new SpeechRecognitionEngine(new CultureInfo("en-US"));

        Random rnd = new Random();
        int RecTimeOut = 0;
        DateTime TimeNow = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var voice in Sarah.GetInstalledVoices())
            {
                voice_list.Items.Add(voice.VoiceInfo.Name);
            }
            
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands.txt")))));
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecognized);
            _recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(_recognizer_SpeechRecognized);
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);

            startlistening.SetInputToDefaultAudioDevice();
            startlistening.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands.txt")))));
            startlistening.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(startlistening_SpeechRecognized);
        }
        
        private void Default_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            int ranNum;
            string speech = e.Result.Text;
            if (speech == "Hello")
            {
                Sarah.SpeakAsync("Hi!");
            }
            if (speech == "How are you")
            {
                Sarah.SpeakAsync("good. and you?");
            }
            if (speech == "What time is it")
            {
                Sarah.SpeakAsync(DateTime.Now.ToString("h mm tt"));
            }
            if (speech == "Stop talking")
            {
                Sarah.SpeakAsyncCancelAll();
                ranNum = rnd.Next(1, 2);
                if(ranNum == 1)
                {
                    Sarah.SpeakAsync("i wil stop talking");
                }
                if(ranNum == 2)
                {
                    Sarah.SpeakAsync("Sorry i will be quiet");
                }
            }
            if (speech == "Stop listening")
            {
                Sarah.SpeakAsync("if you need me just ask");
                _recognizer.RecognizeAsyncCancel();
                startlistening.RecognizeAsync(RecognizeMode.Multiple);
            }
            if (speech == "Show commands")
            {
                string[] commands = (File.ReadAllLines(@"DefaultCommands.txt"));
                LstCommands.Items.Clear();
                LstCommands.SelectionMode = SelectionMode.None;
                foreach (string command in commands)
                {
                    LstCommands.Items.Add(command);
                }
            }
            if (speech == "Hide commands")
            {
                LstCommands.Items.Clear();
            }
        }

        private void _recognizer_SpeechRecognized(object sender, SpeechDetectedEventArgs e)
        {
            RecTimeOut = 0;
        }

        private void startlistening_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;

            if (speech == "Wake up")
            {
                startlistening.RecognizeAsyncCancel();
                Sarah.SpeakAsync("Yes, I'm back");
                _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        private void TimerSpeak_Tick(object sender, EventArgs e)
        {
            if (RecTimeOut == 10)
            {
                _recognizer.RecognizeAsyncCancel();
            }
            else if(RecTimeOut == 11)
            {
                TimerSpeak.Stop();
                startlistening.RecognizeAsync(RecognizeMode.Multiple);
                RecTimeOut = 0;
            }
        }

        private void select_voice_Click(object sender, EventArgs e)
        {
            Sarah.SelectVoice(voice_list.Text);
        }
    }
}
