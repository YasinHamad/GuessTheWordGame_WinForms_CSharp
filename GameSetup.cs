using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheWordGame_WinForms_CSharp
{
    public partial class GameSetup: Form
    {
        Form form1;
        Form PlayingForm;
        public GameSetup(Form form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.PlayingForm = new PlayingForm(this, form1);
        }
        private Globals.Level GetDifficulty()
        {
            if (rbEasy.Checked) return Globals.Level.Easy;
            else if (rbMeduim.Checked) return Globals.Level.Medium;
            return Globals.Level.Hard;
        }
        private Globals.enCategory GetCategory()
        {
            return (Globals.enCategory)cbCategories.SelectedIndex;
        }

        private void GameSetup_Load(object sender, EventArgs e)
        {
            Color DarkBlue = Color.White;
            Color MainBlue = Color.White;
            Color LightBlue = Color.White;

            Globals.Colors.TryGetValue("DarkBlue", out DarkBlue);
            Globals.Colors.TryGetValue("MainBlue", out MainBlue);
            Globals.Colors.TryGetValue("LightBlue", out LightBlue);

            labCategory.ForeColor = DarkBlue;
            labDifficulty.ForeColor = DarkBlue;
            labNumberOfAttempts.ForeColor = DarkBlue;
            labTitle.ForeColor = DarkBlue;

            labSubtitle.ForeColor = MainBlue;
            numNumberOfAttempts.ForeColor = MainBlue;
            rbEasy.ForeColor = MainBlue;
            rbMeduim.ForeColor = MainBlue;
            rbHard.ForeColor = MainBlue;
            cbCategories.ForeColor = MainBlue;
            btnBack.BackColor = MainBlue;
            btnStartGame.BackColor = MainBlue;

            this.BackColor = LightBlue;

            cbCategories.SelectedIndex = 0;
        }

        private void GameSetup_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            form1.Show();
            if(this.WindowState == FormWindowState.Maximized)
            {
                form1.WindowState = FormWindowState.Maximized;
            }
            this.Hide();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Globals.Difficulty = GetDifficulty();
            Globals.Category = GetCategory();
            Globals.NumberOfAttempts = (int)numNumberOfAttempts.Value;
            Globals.RefreshPlayingForm = true;
            PlayingForm.Show();
            if(this.WindowState == FormWindowState.Maximized)
            {
                PlayingForm.WindowState = FormWindowState.Maximized;
            }
            this.Hide();
        }
    }
}
