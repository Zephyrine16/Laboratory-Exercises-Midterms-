using StudentInfoApplication.StudentNamespace;
using System;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    namespace StudentNamespace
    {
        public class StudentInfo
        {
            private long id;
            private string Fname;
            private string Lname;

            public long Id
            {
                get
                {
                    return id;
                }
                set
                {
                    id = value;
                }
            }

            public string fname
            {
                get
                {
                    return Fname;
                }
                set
                {
                    Fname = value;
                }
            }

            public string lname
            {
                get
                {
                    return Lname;
                }
                set
                {
                    Lname = value;
                }
            }

            public StudentInfo(string Fname, string Lname, long id)
            {
                this.Id = id;
                this.fname = Fname;
                this.lname = Lname;
            }

            public StudentInfo(long Id, string Fname, string Lname)
            {
                this.Id = Id;
                this.fname = Fname;
                this.lname = Lname;
            }
        }
    }

    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(studentIDText.Text) ||
               string.IsNullOrWhiteSpace(firstNameText.Text) ||
               string.IsNullOrWhiteSpace(lastNameText.Text))
            {
                MessageBox.Show("Please fill out all the fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long id;
            if(!long.TryParse(studentIDText.Text, out id))
            {
                MessageBox.Show("Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fname = firstNameText.Text;
            string lname = lastNameText.Text;

            StudentInfo student = new StudentInfo(fname, lname, id);

            studentIDListBox.Items.Add(student.Id.ToString());
            firstNameListBox.Items.Add(student.fname);
            lastNameListBox.Items.Add(student.lname);

            ClearInputFields();
        }

        private void ClearInputFields()
        {
            studentIDText.Clear();
            firstNameText.Clear();
            lastNameText.Clear();
        }
    }
}