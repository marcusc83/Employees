using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employees.SQLCommands
{
    public class SQLJoinFullDatabase
    {
        public void fillDataView(DataGridView dataGrid)
        {
            string fillStatement = "Select empId, firstName, lastName, streetAddress," +
                "city, state, zipCode,phoneNumber,emailAddress,department, salary from MyEmployees as me " +
                "left join Departments as dp on me.empId = dp.MyEmployeesEmpId " +
                "left join Salaries as s on s.MyEmployeesEmpId = dp.MyEmployeesEmpId";
            string dbConn = "Data Source=DESKTOP-OB29V6P;Initial Catalog=Employees.EmployeesDB;Integrated Security=True";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(fillStatement, dbConn);
                DataSet ds = new DataSet();
                adapter.Fill(ds,"MyEmployees");
                dataGrid.DataSource = ds.Tables["MyEmployees"].DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading DataView Error");
            }
        }
    }
}
