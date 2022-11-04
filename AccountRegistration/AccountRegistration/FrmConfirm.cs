using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AccountRegistration.StudentInfoClass;

namespace AccountRegistration
{
    public partial class FrmConfirm : Form
    {

        private  DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private  DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        //public delegate long DelegateNumber(long number);
        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_GetPrint_Student_No_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lbl_GetPrint_Student_No.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            lbl_GetPrint_Program.Text = DelProgram(StudentInfoClass.Program).ToString();
            lbl_GetPrint_Lastname.Text = DelLastName(StudentInfoClass.LastName).ToString();
            lbl_GetPrint_Firstname.Text = DelFirstName(StudentInfoClass.FirstName).ToString();
            lbl_GetPrint_Middlename.Text = DelMiddleName(StudentInfoClass.MiddleName).ToString();
            lbl_GetPrint_Age.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lbl_GetPrint_ContactNo.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            lbl_GetPrint_Address.Text = DelAddress(StudentInfoClass.Address).ToString();
        }
    }
}
