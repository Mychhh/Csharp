using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingSystem
{
    public partial class CashierWindowQueue : Form
    {
        public CashierWindowQueue()
        {
            InitializeComponent();

            //timer for queue
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(theTimer);
            timer.Start();

        }

        //show queue
        private void theTimer(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        //add queue
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        //removes the queue
        private void btnNext_Click(object sender, EventArgs e)
        {
            CashierClass.CashierQueue.Dequeue();
        }

        public void DisplayCashierQueue(IEnumerable<string> CashierList) 
        {
            listCashierQueue.Items.Clear();
            foreach(Object obj in CashierList) 
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

    }
}
