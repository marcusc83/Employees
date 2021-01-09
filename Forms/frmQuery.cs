using System;
using System.Windows.Forms;
using Employees.SQLCommands;


namespace Employees
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            SQLJoinFullDatabase join = new SQLJoinFullDatabase();
            join.fillDataView(dataGridView1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDefaultDatabase_Click(object sender, EventArgs e)
        {
            SQLJoinFullDatabase join = new SQLJoinFullDatabase();
            join.fillDataView(dataGridView1);
            lblDatabseTitle.Text = "Current Database";
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            int num = grbSelectionCriteria.Controls.Count;
            SQLCustomQuery query = new SQLCustomQuery();
            query.runQuery(grbSelectionCriteria, dataGridView1);
        }
    }
}
