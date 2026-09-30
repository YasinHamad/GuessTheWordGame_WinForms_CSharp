using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheWordGame_WinForms_CSharp
{
    public partial class PlayingForm: Form
    {
        private class clsLetters
        {
            List<Label> Letters;
            Color Correct;
            Color Wrong;
            Color NotItsPlace;
            Color White;
            Color Black;

            public clsLetters(List<Label> labels)
            {
                Letters = labels;
                Globals.Colors.TryGetValue("DarkGreen", out Correct);
                Globals.Colors.TryGetValue("Red", out Wrong);
                Globals.Colors.TryGetValue("Orange", out NotItsPlace);
                White = Color.White;
                Black = Color.Black;
            }

            private Label GetLabel(string letter)
            {
                foreach(Label label in Letters)
                {
                    if (label.Text.ToLower() == letter) return label;
                }
                return null;
            }

            public void ColorLetterAsCorrect(string letter)
            {
                Label label = GetLabel(letter);
                label.BackColor = this.Correct;
                label.ForeColor = this.White;
            }
            public void ColorLetterAsWrong(string letter)
            {
                Label label = GetLabel(letter);
                label.BackColor = this.Wrong;
                label.ForeColor = this.White;
            }
            public void ColorLetterAsNotInItsPlace(string letter)
            {
                Label label = GetLabel(letter);
                label.BackColor = this.NotItsPlace;
                label.ForeColor = this.White;
            }

            public void ResetLetters()
            {
                foreach(Label label in Letters)
                {
                    label.ForeColor = Black;
                    label.BackColor = Color.Transparent;
                }
            }
        }
        Form GameSetupForm;
        Form Form1;
        clsLetters Letters;
        bool IsCorrectAttempsUpgradable;
        public PlayingForm(Form GameSetupForm, Form form1)
        {
            InitializeComponent();
            this.GameSetupForm = GameSetupForm;
            this.Form1 = form1;
            List<Label> labels = new List<Label>()
            {
                label6, label7, label8, label9, label10, label11,
                label12, label13, label14, label15, label16, label17,
                label18, label19, label20, label21, label22, label23,
                label24, label25, label26, label27, label28, label29,
                label30, label31
            };
            Letters = new clsLetters(labels);
            this.IsCorrectAttempsUpgradable = true;
        }

        private void SetColors()
        {
            Color DarkBlue = Color.White;
            Color MainBlue = Color.White;
            Color LightBlue = Color.White;
            Color Red = Color.White;
            Color Orange = Color.White;
            Color DarkGreen = Color.White;

            Globals.Colors.TryGetValue("DarkBlue", out DarkBlue);
            Globals.Colors.TryGetValue("MainBlue", out MainBlue);
            Globals.Colors.TryGetValue("LightBlue", out LightBlue);
            Globals.Colors.TryGetValue("Red", out Red);
            Globals.Colors.TryGetValue("Orange", out Orange);
            Globals.Colors.TryGetValue("DarkGreen", out DarkGreen);


            this.BackColor = LightBlue;
            labTitle.ForeColor = DarkBlue;
            labWord.ForeColor = MainBlue;
            labWordTitle.ForeColor = DarkBlue;
            labLettersTitle.ForeColor = DarkBlue;

            labCategory.ForeColor = DarkBlue;
            labCategoryRes.ForeColor = DarkBlue;

            labCorrect.ForeColor = DarkBlue;
            labWrong.ForeColor = DarkBlue;
            labAttempts.ForeColor = DarkBlue;

            btnNewWord.BackColor = MainBlue;
            btnGiveUp.BackColor = Red;

            labCorrect.ForeColor = MainBlue;
            labWrong.ForeColor = MainBlue;
            labAttempts.ForeColor = MainBlue;

            labCorrectRes.ForeColor = MainBlue;
            labWrongRes.ForeColor = MainBlue;
            labAttemptsRes.ForeColor = MainBlue;

            btnGuess.BackColor = MainBlue;

            labHelpCorrect.BackColor = DarkGreen;
            labHelpWrong.BackColor = Red;
            labHelpNotinItsPlace.BackColor = Orange;

            labHelpCorrectText.ForeColor = MainBlue;
            labHelpNotinItsPlaceText.ForeColor = MainBlue;
            labHelpWrongText.ForeColor = MainBlue;
        }

        private void PlayingForm_Load(object sender, EventArgs e)
        {

        }

        private void PlayingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.GameSetupForm.Close();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Form1.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            IsCorrectAttempsUpgradable = true;
            Color White = Color.White;
            Globals.Colors.TryGetValue("LightBlue", out White);
            string OldWord = Globals.Word;
            while(OldWord == Globals.Word)
            {
                Globals.Word = Globals.GetRandomWord(GetCategoryClass(), Globals.Difficulty);
            }
            testword.Text = Globals.Word;
            tbWord.Clear();
            Letters.ResetLetters();
            string word = "";
            for(int i = 0; i<(int)Globals.Difficulty; i++)
            {
                word += "_";
            }
            labWord.Text = this.Customize_Word(word);
        }

        private string Customize_Word(string word)
        {
            string Result = "";
            for(int i = 0; i<= word.Length - 1; i++)
            {
                Result += word[i];
                if(i != word.Length - 1) Result += " ";
            }
            return Result;
        }

        private void PlayingForm_Activated(object sender, EventArgs e)
        {
            if (!Globals.RefreshPlayingForm) return;
            SetColors();
            //string word = Globals.GetRandomWord(new Globals.Animal(), Globals.Difficulty);
            string word = "";
            for(int i = 0; i<(int)Globals.Difficulty; i++)
            {
                word += "_";
            }
            labWord.Text = this.Customize_Word(word);
            tbWord.MaxLength = (int)Globals.Difficulty;
            tbWord.Clear();
            labCategoryRes.Text = Globals.Category.ToString();
            labAttemptsRes.Text = Globals.NumberOfAttempts.ToString();
            labWrongRes.Text = "0";
            labCorrectRes.Text = "0";

            Globals.RefreshPlayingForm = false;
            Letters.ResetLetters();

            Globals.Word = Globals.GetRandomWord(GetCategoryClass(), Globals.Difficulty);
            testword.Text = Globals.Word;
        }
        private Globals.Choosable GetCategoryClass()
        {
            switch(Globals.Category)
            {
                case Globals.enCategory.Animals: return new Globals.Animal();
                case Globals.enCategory.Countries: return new Globals.Country();
                case Globals.enCategory.Technology: return new Globals.Technology();
                default: return new Globals.Food();
            }
        }

        private void PlayingForm_Shown(object sender, EventArgs e)
        {
        }
        
        private bool CompareResults(string MainWord, string UserWord)
        {
            Letters.ResetLetters();
            for(int i = 0; i<UserWord.Length; i++)
            {
                if (UserWord[i] == MainWord[i]) Letters.ColorLetterAsCorrect(UserWord[i].ToString());
                else if (MainWord.Contains(UserWord[i].ToString())) Letters.ColorLetterAsNotInItsPlace(UserWord[i].ToString());
                else Letters.ColorLetterAsWrong(UserWord[i].ToString());
            }
            labWord.Text = Customize_Word(UserWord);
            if (MainWord == UserWord) return true;
            else return false;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (!IsCorrectAttempsUpgradable) return;
            Color MiddleGreen = Color.White;
            Color LightRed = Color.White;
            Globals.Colors.TryGetValue("MiddleGreen", out MiddleGreen);
            Globals.Colors.TryGetValue("LightRed", out LightRed);

            if(CompareResults(Globals.Word.ToLower(), tbWord.Text.Trim().ToLower()))
            {
                IsCorrectAttempsUpgradable = false;
                this.BackColor = MiddleGreen;
                int CorrectAttempts = 0;
                int.TryParse(labCorrectRes.Text, out CorrectAttempts);
                CorrectAttempts++;
                labCorrectRes.Text = CorrectAttempts.ToString();
            }
            else
            {
                this.BackColor = LightRed;

                int NumberOfAttempts = 0;
                int.TryParse(labAttemptsRes.Text, out NumberOfAttempts);
                NumberOfAttempts--;
                labAttemptsRes.Text = NumberOfAttempts.ToString();

                int NumberOfFailures = 0;
                //MessageBox.Show(NumberOfAttempts.ToString());
                //MessageBox.Show(NumberOfFailures.ToString());
                int.TryParse(labWrongRes.Text, out NumberOfFailures);
                NumberOfFailures++;
                labWrongRes.Text = NumberOfFailures.ToString();

                if(NumberOfAttempts == 0)
                {
                    if(MessageBox.Show
                    (
                        "You lost!" + Environment.NewLine + "The word is " + Globals.Word,
                        "Results",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                     ) == DialogResult.OK)
                    {
                        Globals.RefreshPlayingForm = true;
                        GameSetupForm.Show();
                        this.Hide();
                    }
                }
            }

            
        }
    }
}
