using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _07_Task_Performance_1___ARG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LBL_Score.Text = "Score " + 5.ToString();

            StringBuilder chad     = new StringBuilder("Chad");
            StringBuilder Csharp   = new StringBuilder("C#");
            StringBuilder Python   = new StringBuilder("Python");
            StringBuilder BBF      = new StringBuilder("BBF");
            StringBuilder GOMBURZA = new StringBuilder("GOMBURZA");

            ArrayList wordToGuess  = new ArrayList() {chad, Csharp, Python, BBF, GOMBURZA};

            LBL_WordToGuess.Text = chad.ToString();

        }

        private void PBX_PictureToGuess_Click(object sender, EventArgs e)
        {

        }

        private void LBL_WordToGuess_Click(object sender, EventArgs e)
        {
            
        }

        private void LBL_Score_Click(object sender, EventArgs e)
        {

        }
    }
}
