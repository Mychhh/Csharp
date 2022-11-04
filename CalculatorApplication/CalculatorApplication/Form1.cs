using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{ 
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            CalculatorClass cal = new CalculatorClass();
            double num1, num2;
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);

            if (cbOperator.SelectedIndex == 0)
            {
                cal.CalculateEvent += new Formula<double>(cal.GetSum);
                lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                
            }
            else if (cbOperator.SelectedIndex == 1)
            {
                cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetProduct);

            }
            else if (cbOperator.SelectedIndex == 2) {
                cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                lblDisplayTotal.Text=cal.GetDifference(num1,num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
            }
            else if(cbOperator.SelectedIndex == 3){
                cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
            }
        }

        private void lblDisplayTotal_Click(object sender, EventArgs e)
        {

        }

        private void FrmCalcualator_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxInput2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
public delegate F Formula<F>(F arg1,F arg2);
class CalculatorClass
{
    public Formula<double> formula;
   public double GetSum(double sum1,double sum2)
    {
        return sum1+sum2;
     
    }
    public double GetDifference(double difference1,double difference2)
    {
        return difference1-difference2;
    }
 
    public event Formula<double> CalculateEvent
    {
        add
        {
                Console.WriteLine("Add the Delegate");
        }
        remove { 
            Console.WriteLine("Remove the Delegate");
        }
    }
    public double GetProduct(double product1,double product2)
    {
        return product1*product2;
      
    }
    public double GetQuotient(double quotient1, double quotient2)
    {
        return quotient1/quotient2;
    
    }
}