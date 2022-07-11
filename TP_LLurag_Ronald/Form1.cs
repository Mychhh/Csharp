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

namespace TP_LLurag_Ronald
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int score = 5;
            int WordToGuessNum = 0;

            ArrayList wordToGuess = new ArrayList() { "Java", "Python", "C#", "Git", "Hotdog" };

            StringBuilder java = new StringBuilder(wordToGuess[0].ToString());
            StringBuilder python = new StringBuilder(wordToGuess[0].ToString());
            StringBuilder Csharp = new StringBuilder(wordToGuess[0].ToString());
            StringBuilder git = new StringBuilder(wordToGuess[0].ToString());
            StringBuilder hotdog = new StringBuilder(wordToGuess[0].ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

