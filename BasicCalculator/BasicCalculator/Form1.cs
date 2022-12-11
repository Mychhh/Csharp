using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            txtBox_Results.Text = "Total " + Environment.NewLine + Environment.NewLine +  "0";
        }

        private void btn_Compute_Click(object sender, EventArgs e)
        {
            float number1, number2;

            if (!float.TryParse(txtBox_number1.Text, out number1))
            {
                MessageBox.Show("First number Invalid");
                return;
            }
            else if (!float.TryParse(txtBox_number2.Text, out number2))
            {
                MessageBox.Show("Second number Invalid");
                return;
            }

            string oper = comboBox1.Text;

            switch (oper)
            {
                case "+":
                    BasicComputation.BasicCompute add = new BasicComputation.BasicCompute();
                    txtBox_Results.Text = "Total" + Environment.NewLine + Environment.NewLine +  Convert.ToString(add.Addition(Convert.ToInt16(txtBox_number1.Text), Convert.ToInt16(txtBox_number2.Text)));
                    break;
                case "-":
                    BasicComputation.BasicCompute subtract = new BasicComputation.BasicCompute();
                    txtBox_Results.Text = "Total" + Environment.NewLine + Environment.NewLine +  Convert.ToString(subtract.Subtraction(Convert.ToInt16(txtBox_number1.Text), Convert.ToInt16(txtBox_number2.Text)));
                    break;
                case "*":
                    BasicComputation.BasicCompute multiply = new BasicComputation.BasicCompute();
                    txtBox_Results.Text = "Total" + Environment.NewLine + Environment.NewLine +  Convert.ToString(multiply.Multiplication(Convert.ToInt16(txtBox_number1.Text), Convert.ToInt16(txtBox_number2.Text)));
                    break;
                case "/":
                    if(number2 == 0)
                    {
                        MessageBox.Show("Cannot be divided by Zero");
                    }
                    else
                    {
                        BasicComputation.BasicCompute divide = new BasicComputation.BasicCompute();
                        txtBox_Results.Text = "Total" + Environment.NewLine + Environment.NewLine + Convert.ToString(divide.Division(Convert.ToInt16(txtBox_number1.Text), Convert.ToInt16(txtBox_number2.Text)));
                    }
                    break;
                default:
                    txtBox_Results.Text = "Invalid Operator";
                    break;


            }

        }

    }
}









