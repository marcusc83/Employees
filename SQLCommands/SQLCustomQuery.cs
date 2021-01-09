using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employees.SQLCommands
{
    public class SQLCustomQuery
    {
        public void runQuery(GroupBox group, DataGridView dataGridView)
        {
            string selectionCriteria = "";

            foreach(Control c in group.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if(cb.Checked == true)
                    {
                        selectionCriteria = string.Concat(selectionCriteria, " ", cb.Text,  ",") ;
                    }
                }
            }
            int lastCHar = selectionCriteria.Length;
            selectionCriteria = selectionCriteria.Remove(lastCHar - 1);
         
            string fillStatement =string.Format( "select{0} from MyEmployees as me " +
                "left join Departments as dp on me.empId = dp.MyEmployeesEmpId " +
                "left join Salaries as s on s.MyEmployeesEmpId = dp.MyEmployeesEmpId", selectionCriteria);
            string dbConn = "Data Source=DESKTOP-OB29V6P;Initial Catalog=Employees.EmployeesDB;Integrated Security=True";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(fillStatement, dbConn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "MyEmployees");
                dataGridView.DataSource = ds.Tables["MyEmployees"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading DataView Error");
            }

        }
    }
}
