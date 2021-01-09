using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Employees.Validators;

namespace Employees
{
    public partial class frmAddEmployee : Form
    {
        
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Model.MyEmployees emp = new Model.MyEmployees();

                emp.firstName = this.txtFirstName.Text.Trim();
                emp.lastName = this.txtLastName.Text.Trim();
                emp.streetAddress = this.txtStreetAddress.Text.Trim();
                emp.city = this.txtCity.Text.Trim();
                emp.state = this.cmbStates.Text;
                emp.zipCode = this.txtZipCode.Text.Trim();
                emp.phoneNumber = this.txtPhoneNumber.Text.Trim();
                emp.emailAddress = this.txtEmailAddress.Text.Trim();
                EmployerInfoValidator validator = new EmployerInfoValidator();
                bool infoValid = validator.checkEmpInfo(emp);

                if (infoValid == true)
                {
                    SQLCommands.SQLAddEmployee cmdAddEmp = new SQLCommands.SQLAddEmployee();
                    cmdAddEmp.addEmployee(emp);
                    if (MessageBox.Show("Would you like to add another employee?", "Add another Emplolyee", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        frmAddEmployee form = new frmAddEmployee();
                        form.MdiParent = ActiveForm;
                        form.Show();
                        this.Close();
                    }
                    else this.Close();
                }
                else
                {
                    MessageBox.Show("Make sure all the boxes are filled in", "Info Missing Error");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Employee Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                string[] states = File.ReadAllLines("D:/Employees/TextFiles/States.txt");
                if(states.Length == 0)
                {
                    MessageBox.Show("No States to Show", "Getting States Error");
                }
                else
                {
                    Array.Sort(states);
                    for(int i = 0; i < states.Length; i++)
                    {
                        cmbStates.Items.Add(states[i]);
                    }                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading State Error");
            }
        }
    }
}
