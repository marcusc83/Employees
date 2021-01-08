using Employees.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class frmMain : Form
    {
        public int empID = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee form = new frmAddEmployee();
            form.MdiParent = this;
            form.Show();
        }

        private void addDepartmentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddDeptartment form = new frmAddDeptartment();
            form.MdiParent = this;
            form.Show();
        }
    }
}
