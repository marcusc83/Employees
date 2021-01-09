using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Employees.Model;
using Employees.SQLCommands;

namespace Employees.Forms
{
    public partial class frmAddDeptartment : Form
    {
        public frmAddDeptartment()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fromAddDeptartment_Load(object sender, EventArgs e)
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
                        cmbEmpName.Items.Add(empNames[i]);                     
                    }
                    string[] lines = File.ReadAllLines("D:/Employees/TextFiles/DepartmentNames.txt");
                    Array.Sort(lines);
                    foreach (string line in lines)
                    {
                        cmbDepartment.Items.Add(line);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading Employee Names Error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] name = cmbEmpName.Text.Split(' ');

            string first = name[0];
            string last = name[1];

            string dept = cmbDepartment.Text;

            SQLAddDept addDept = new SQLAddDept();
            addDept.addDepartment(dept, first, last);


        }
    }
}
