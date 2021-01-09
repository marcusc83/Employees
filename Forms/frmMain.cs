using Employees.Forms;
using System;
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

        private void addSalaryFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSalary form = new frmAddSalary();
            form.MdiParent = this;
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void iconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void ToolStripMenuItemNewQueryForm_Click(object sender, EventArgs e)
        {
            QueryForm form = new QueryForm();
            form.MdiParent = this;
            form.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            QueryForm form = new QueryForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
