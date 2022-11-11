using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FrmBasicThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void MyThreads()
        {
            label1.Text = "- Thread Starts -";

            Console.WriteLine("- Thread Starts -");

            MyThreadClass ThreadCLass = new MyThreadClass();

            Thread threadA = new Thread(new ThreadStart(ThreadCLass.thread1));
            Thread threadB = new Thread(new ThreadStart(ThreadCLass.thread2));
            Thread threadC = new Thread(new ThreadStart(ThreadCLass.thread1));
            Thread threadD = new Thread(new ThreadStart(ThreadCLass.thread2));

            threadA.Priority = ThreadPriority.Highest;
            threadA.Name = "Thread A Process";

            threadB.Priority = ThreadPriority.Normal ;
            threadB.Name = "Thread B Process";

            threadC.Priority = ThreadPriority.AboveNormal;
            threadC.Name = "Thread C Process";

            threadD.Priority = ThreadPriority.BelowNormal;
            threadD.Name = "Thread D Process";

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join(); 
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("- Ends of Thread - ");

            label1.Text = "- Ends of Thread -";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyThreads();
        }
    }
}
