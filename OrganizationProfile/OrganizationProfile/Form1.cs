using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class FrmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {
                "BS  Information  Technology",
                "BS  Computer  Science", "BS  Information  Systems", "BS  in  Accountancy",
                "BS  in  Hospitality  Management", "BS  in  Tourism  Management"
            };

            for (int i = 0; i < 6; i++)
            {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
            }

            string[] ListOfGender = new string[]
            {
                "Male",
                "Female"
            };

            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(ListOfGender[i].ToString());
            }
        }


        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {   
                "BS  Information  Technology",
                "BS  Computer  Science", "BS  Information  Systems", "BS  in  Accountancy",
                "BS  in  Hospitality  Management", "BS  in  Tourism  Management" 
            };
            
            for (int i = 0; i < 6; i++)
                        {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
            }

            string[] ListOfGender = new string[]
            {
                "Male",
                "Female"
            };

            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(ListOfGender[i].ToString());
            }
        }

        /////return methods 
        public long StudentNumber(string studNum)
        {

            try
            {
                _StudentNo = long.Parse(studNum);

                if (studNum == "")
                {
                    throw new ArgumentNullException(MessageBox.Show("Dont leave the student number empty ").ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("input 11 index or ");
            }

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            try 
            {
                if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
                {
                    _ContactNo = long.Parse(Contact);
                }
                else if(Contact == "")
                {
                    throw new ArgumentNullException(MessageBox.Show("Dont leave the Contact number empty").ToString());
                }
                else
                {
                    throw new IndexOutOfRangeException(MessageBox.Show("index out of range contact number").ToString());
                }
            }
            catch(Exception e) {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("input 11 index only ");
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {

            try
            {
                if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
                {
                    _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
                }
                else
                {
                    throw new ArgumentNullException(MessageBox.Show("lastname, firstname, or middle initial textbox is empty").ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("lastname, firstname, or middle initial textbox empty");
            }
            return _FullName;
        
        }

        public int Age(string age)
        {
            
            try
            {
                if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
                {
                    _Age = Int32.Parse(age);
                }
                else if (age == "") 
                {
                    throw new ArgumentNullException(MessageBox.Show("Dont leave the age empty").ToString());
                }
                else
                {
                    throw new OverflowException(MessageBox.Show("invalid input").ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Enter Integer only");
            }
            return _Age;

        }

        public FrmRegistration()
        {
            InitializeComponent();
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            StudentInfoClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
            StudentInfoClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
            StudentInfoClass.SetProgram = cbProgram.Text;
            StudentInfoClass.SetGender = cbGender.Text;
            StudentInfoClass.SetContactNo = ContactNo(txtContactNo.Text);
            StudentInfoClass.SetAge = Age(txtAge.Text);
            StudentInfoClass.SetBirthDay = dateTimePickerBirthday.Value.ToString("yyyy-MM-dd");

            frmConfirmation frm = new frmConfirmation();
            frm.Show();
        }
    }
}
public class StudentInfoClass {
    public static long SetStudentNo = 0;
    public static long SetContactNo = 0;
    public static int SetAge = 0;
    public static string SetProgram = " ";
    public static string SetGender = " ";
    public static string SetFullName = " ";
    public static string SetBirthDay = " ";
}
