using System;
using System.Windows.Forms;

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
                emp.state = this.txtState.Text.Trim();
                emp.zipCode = this.txtZipCode.Text.Trim();
                emp.phoneNumber = this.txtPhoneNumber.Text.Trim();
                emp.emailAddress = this.txtEmailAddress.Text.Trim();

                SQLCommands.SQLAddEmployee cmdAddEmp = new SQLCommands.SQLAddEmployee();
                cmdAddEmp.addEmployee(emp);
                if (MessageBox.Show("Would you like to add another employee?", "Add another Emplolyee", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    frmAddEmployee form = new frmAddEmployee();
                    form.MdiParent = frmMain.ActiveForm;
                    form.Show();
                    this.Close();
                }
                else this.Close();
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
    }
}
