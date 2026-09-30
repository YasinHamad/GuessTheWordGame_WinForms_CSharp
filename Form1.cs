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
    public partial class Form1: Form
    {
        Form GameSetup;
        public Form1()
        {
            InitializeComponent();
            GameSetup = new GameSetup(this);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            GameSetup.Show();
            if (this.WindowState == FormWindowState.Maximized)
            {
                GameSetup.WindowState = FormWindowState.Maximized;
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color color = Color.White;
            Globals.Colors.TryGetValue("DarkGreen", out color);
            btnPlay.BackColor = color;

            Globals.Colors.TryGetValue("Red", out color);
            btnExit.BackColor = color;

            Globals.Colors.TryGetValue("DarkBlue", out color);
            labTitle.ForeColor = color;

            Globals.Colors.TryGetValue("MainBlue", out color);
            labSubTitle.ForeColor = color;
        }
    }
}
