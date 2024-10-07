using System.Data;

namespace EmployeeApplication__1_
{
    public class Employee
    {
        private long employeeID;
        private string firstName;
        private string lastName;
        private string position;

        public long EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public Employee()
        { }

        public Employee(long employeeID, string firstName, string lastName, string position)
        {
            this.employeeID = employeeID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }
    }
    public partial class EmployeeApplication : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public EmployeeApplication()
        {
            InitializeComponent();

            positionList.Items.Add("Chief Executive Officer");
            positionList.Items.Add("Chief Operating Officer");
            positionList.Items.Add("Chief Financial Officer");
            positionList.Items.Add("Chief Technology Officer");
            positionList.Items.Add("Chief Marketing Officer");
            positionList.Items.Add("Chief Human Resources Officer");
            positionList.Items.Add("Chief Information Officer");
            positionList.Items.Add("Chief Product Officer");
            positionList.Items.Add("General Manager");
            positionList.Items.Add("Operations Manager");
            positionList.Items.Add("Finance Manager");
            positionList.Items.Add("Human Resources Manager");
            positionList.Items.Add("Sales Manager");
            positionList.Items.Add("Marketing Manager");
            positionList.Items.Add("Product Operations Manager");
            positionList.Items.Add("Product Manager");
            positionList.Items.Add("Technical Project Manager");
            positionList.Items.Add("Project Manager");
            positionList.Items.Add("IT Manager");
            positionList.Items.Add("Supply Chain Manager");
            positionList.Items.Add("Product Owner");
            positionList.Items.Add("Scrum Master");
            positionList.Items.Add("Technical Program Manager");
            positionList.Items.Add("UI/UX Designer");
            positionList.Items.Add("Full - Stack Developer");
            positionList.Items.Add("Front - End Developer");
            positionList.Items.Add("Back - End Developer");
            positionList.Items.Add("Mobile App Developer");
            positionList.Items.Add("Software Engineer");
            positionList.Items.Add("DevOps Engineer");
            positionList.Items.Add("Quality Assurance Engineer");
            positionList.Items.Add("Game Developer");
            positionList.Items.Add("Firmware Engineer");
            positionList.Items.Add("Embedded Systems Engineer");
            positionList.Items.Add("Data Scientist");
            positionList.Items.Add("Data Analyst");
            positionList.Items.Add("Data Engineer");
            positionList.Items.Add("Machine Learning Engineer");
            positionList.Items.Add("Artificial Intelligence (AI) Engineer");
            positionList.Items.Add("Business Intelligence (BI) Analyst");
            positionList.Items.Add("Systems Administrator");
            positionList.Items.Add("Network Engineer");
            positionList.Items.Add("Cloud Architect");
            positionList.Items.Add("Cybersecurity Specialist");
            positionList.Items.Add("IT Support Specialist");
            positionList.Items.Add("Database Administrator");
            positionList.Items.Add("Site Reliability Engineer (SRE)");
            positionList.Items.Add("Research Scientist");
            positionList.Items.Add("Innovative Manager");
            positionList.Items.Add("R&D Engineer");
            positionList.Items.Add("Sales Engineer");
            positionList.Items.Add("Account Manager");
            positionList.Items.Add("Customer Success Manager");
            positionList.Items.Add("Marketing Manager");
            positionList.Items.Add("Growth Hacker");
            positionList.Items.Add("SEO Specialist");
            positionList.Items.Add("Content Manager");
            positionList.Items.Add("Technical Support Specialist");
            positionList.Items.Add("Customer Support Representative");
            positionList.Items.Add("Customer Onboarding Specialist");
            positionList.Items.Add("Help Desk Technician");
            positionList.Items.Add("UX Researcher");
            positionList.Items.Add("Interaction Designer");
            positionList.Items.Add("Visual Designer");
            positionList.Items.Add("Graphic Designer");
            positionList.Items.Add("Legal Counsel");
            positionList.Items.Add("Compliance Officer");
            positionList.Items.Add("Intellectual Property Specialist");
            positionList.Items.Add("Technical Recruiter");
            positionList.Items.Add("HR Business Partner");
            positionList.Items.Add("People Operations Manager");
            positionList.Items.Add("Financial Analyst");
            positionList.Items.Add("Payroll Specialist");
            positionList.Items.Add("Office Manager");
            positionList.Items.Add("Blockchain Developer");
            positionList.Items.Add("Quantum Computing Researcher");
            positionList.Items.Add("Augmented Reality (AR)/Virtual Reality (VR) Developer");
            positionList.Items.Add("Robotics Engineer");
            positionList.Items.Add("IoT Developer");
        }

        private void ClearInputFields()
        {
            employeeIDText.Clear();
            firstNameText.Clear();
            lastNameText.Clear();
            positionList.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("First Name", Type.GetType("System.String"));
            table.Columns.Add("Last Name", Type.GetType("System.String"));
            table.Columns.Add("Position", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(employeeIDText.Text) ||
               string.IsNullOrWhiteSpace(firstNameText.Text) ||
               string.IsNullOrWhiteSpace(lastNameText.Text) ||
               string.IsNullOrWhiteSpace(positionList.Text))
            {
                MessageBox.Show("Please fill out all the fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(firstNameText.Text.Any(char.IsDigit))
            {
                MessageBox.Show("First Name should not contain numbers. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameText.Clear();
                return;
            }
            else if(lastNameText.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Last Name should not contain numbers. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameText.Clear();
                return;
            }
            else
            {
                long employeeID;
                if(long.TryParse(employeeIDText.Text, out employeeID))
                {
                    Employee newEmployee = new Employee(employeeID, firstNameText.Text, lastNameText.Text, positionList.Text);
                    table.Rows.Add(employeeIDText.Text, firstNameText.Text, lastNameText.Text, positionList.Text);
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    employeeIDText.Clear();
                    return;
                }
            }
            ClearInputFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            employeeIDText.Text = row.Cells[0].Value.ToString();
            firstNameText.Text = row.Cells[1].Value.ToString();
            lastNameText.Text = row.Cells[2].Value.ToString();
            positionList.Text = row.Cells[3].Value.ToString();
        }
    }
}