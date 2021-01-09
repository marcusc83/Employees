using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Employees.SQLCommands;

namespace Employees.Forms
{
    public partial class frmAddSalary : Form
    {
        public frmAddSalary()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddSalary_Load(object sender, EventArgs e)
        {
            try
            {
                SQLGetEmployeeFirstandLast getNames = new SQLGetEmployeeFirstandLast();
                List<string> empNames = new List<string>();
                empNames = getNames.getEmployeeNames();
                if (empNames.Count == 0)
                {
                    MessageBox.Show("There are no Names in the Database\nTry Adding Some...", "Nothing in DB");
                }
                else
                {
                    empNames.Sort();
                    for (int i = 0; i < empNames.Count(); i++)
                    {
                        cmbEmployee.Items.Add(empNames[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading Employee Names Error");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SQLAddSalary AddSalary = new SQLAddSalary();
        
            try
            {
                string[] name = cmbEmployee.Text.Split(' ');

                string first = name[0];
                string last = name[1];
                AddSalary.addSalary(txtSalary.Text, first, last);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Setting Salary Error");
            }
        }
    }
}
