using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentRegistrationApplication
{
    public partial class StudentRegistrationApplication : Form
    {
        private string[] program =
        {
            "BS in Information Technology",
            "BS in Computer Science",
            "BS in Information Systems",
            "BS in Business Administration",
            "BS in Accountancy",
            "BS in Accounting Information System",
            "BS in Management Accounting",
            "BS in Retail Technology and Consumer Science",
            "BS in Hospitality Management",
            "BS in Culinary Management",
            "BS in Tourism Management",
            "BS in Computer Engineering",
            "BS in Marine Transportation",
            "BS in Marine Engineering",
            "BS in Naval Architecture and Marine Engineering",
            "BS in Criminology",
            "BA in Communication",
            "BA in Psychology",
            "Bachelor of Multimedia Arts"
        };

        public StudentRegistrationApplication()
        {
            InitializeComponent();
            DateFields();
            ProgramList();
        }

        private void DateFields()
        {
            for (int i = 1; i <= 31; i++)
            {
                Day.Items.Add(i.ToString());
            }
            string[] months =
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };
            foreach (string month in months)
            {
                Month.Items.Add(month.ToString());
            }

            for (int i = 2024; i >= 1; i--)
            {
                Year.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 2024; i++)
            {
                Year.Items.Add(i.ToString() + " BC");
            }
        }

        private void ProgramList()
        {
            foreach(string programs in program)
            {
                Program.Items.Add(programs.ToString());
            }
        }

        private void DisplayStudentInfo(string firstName, string middleName, string lastName)
        {
            MessageBox.Show("Student name: " + firstName + " " + middleName + " " + lastName, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayStudentInfo(string firstName, string middleName, string lastName, string gender)
        {
            MessageBox.Show("Student name: " + firstName + " " + middleName + " " + lastName + "\nGender: " + gender, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayStudentInfo(string firstName, string middleName, string lastName, string gender, string day, string month, string year, string program)
        {
            MessageBox.Show("Student name: " + firstName + " " + middleName + " " + lastName + "\nGender: " + gender + "\nDate of Birth: " + day + " " + month + " " + year + "\nProgram: " + program, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void registerStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lastNameText.Text) ||
                string.IsNullOrWhiteSpace(firstNameText.Text) ||
                string.IsNullOrWhiteSpace(middleNameText.Text) ||
                Day.SelectedItem == null ||
                Month.SelectedItem == null ||
                Year.SelectedItem == null ||
                Program.SelectedItem == null ||
                (!Male.Checked && !Female.Checked && !preferNotToSay.Checked))
            {
                MessageBox.Show("Please fill out all the fields before registering.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string lname = lastNameText.Text;
            string fname = firstNameText.Text;
            string mname = middleNameText.Text;
            string gender = Male.Checked ? "Male" : Female.Checked ? "Female" : preferNotToSay.Checked ? "Preferred Not to Say" : "";
            string day = Day.SelectedItem?.ToString();
            string month = Month.SelectedItem?.ToString();
            string year = Year.SelectedItem?.ToString();
            string program = Program.SelectedItem?.ToString();

            DisplayStudentInfo(fname, mname, lname);
            DisplayStudentInfo(fname, mname, lname, gender);
            DisplayStudentInfo(fname, mname, lname, gender, day, month, year, program);

            ClearInputFields();
        }

        private void ClearInputFields()
        {
            lastNameText.Clear();
            firstNameText.Clear();
            middleNameText.Clear();

            Day.SelectedIndex = -1;
            Month.SelectedIndex = -1;
            Year.SelectedIndex = -1;
            Program.SelectedIndex = -1;

            Male.Checked = false;
            Female.Checked = false;
            preferNotToSay.Checked = false;
        }
    }
}