using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AccountRegistration
{

    public partial class StudentInfoClass : Form
    {

        //Delegates
        public delegate long DelegateNumber(long number);
        public delegate String DelegateText(String text);

        public static String FirstName = "", LastName = "", MiddleName = "";
        public static String Address = "", Program = "";
        public static long Age = 0, ContactNo = 0, StudentNo = 0;

        public StudentInfoClass()
        {
            InitializeComponent();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = txtbx_Firstname.Text.ToString();
            StudentInfoClass.LastName = txtbx_Lastname.Text.ToString();
            StudentInfoClass.MiddleName = txtbx_Middlename.Text.ToString();
            StudentInfoClass.Address = txtbx_Address.Text.ToString();
            StudentInfoClass.Program = cmbBox_Program.Text.ToString();
            StudentInfoClass.StudentNo = Convert.ToInt32(txtbx_Student_No.Text);
            StudentInfoClass.Age = Convert.ToInt32(txtbx_Age.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(txtbx_Contact_No.Text);                                            

            FrmConfirm Confirm = new FrmConfirm();

            Confirm.Show();

            Visible = false;
        }

        void cmbBox_Program_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void StudentInfoClass_Load(object sender, EventArgs e)
        {

        }

        public static String GetFirstName(String FirstName)
        {
            // code to be executed
            //StudentInfoClass.FirstName = txtbx_Middlename.Text.ToString();
            return FirstName;
        }

        public static String GetLastName(String LastName)
        {
            // code to be executed
            //StudentInfoClass.LastName = txtbx_Lastname.Text.ToString();
            return LastName;
        }

        public static String GetMiddleName(String MiddleName)
        {
            // code to be executed
            //StudentInfoClass.MiddleName = txtbx_Middlename.Text.ToString();
            return MiddleName;
        }

        public static String GetAddress(String Address)
        {
            // code to be executed
            //StudentInfoClass.Address = txtbx_Address.Text.ToString();
            return Address;
        }

        public static String GetProgram(String Program)
        {
            // code to be executed
            //StudentInfoClass.Program = cmbBox_Program.Text.ToString();
            return Program;
        }

        public static long GetAge(long Age)
        {
            // code to be executed
            //StudentInfoClass.Age = cmbBox_Program.Text.LongCount();
            return Age;
        }

        public static long GetContactNo(long ContactNo)
        {
            // code to be executed
            //StudentInfoClass.ContactNo = txtbx_Contact_No.Text.LongCount();
            return ContactNo;
        }

        public static long GetStudentNo(long StudentNo)
        {
            // code to be executed
            //StudentInfoClass.StudentNo = cmbBox_Program.Text.LongCount();
            return StudentNo;
        }
    }
}
