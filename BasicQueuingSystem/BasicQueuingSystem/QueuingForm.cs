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
    public partial class QueuingForm : Form
    {
        //Declaring variable for CashierClass
        private CashierClass cashier;
        private CustomerViewcs customer;

        public QueuingForm()
        {
            InitializeComponent();

            //Initialized cashier variable
            cashier = new CashierClass();

            CashierWindowQueue cashierWindowQueueForm = new CashierWindowQueue();
            cashierWindowQueueForm.Show();

            customer = new CustomerViewcs();


        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
           
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

            CustomerViewcs customerView = new CustomerViewcs();

            CustomerViewcs.getNumberInServing = CashierClass.CashierQueue.Peek().ToString();
            customerView.Show();
        }
    }
}
