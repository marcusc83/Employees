using Employees.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employees.SQLCommands
{
    class SQLAddSalary
    {
        public void addEmployee(Salaries sal)
        {
            string addCommand = string.Format("Insert into Salaries (salary)" +
                "Values ('{0}')", sal.salary);
               

            string connString = "Data Source=DESKTOP-OB29V6P;Initial Catalog=Employees.EmployeesDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand addEmp = new SqlCommand(addCommand, conn);
            SqlDataReader myReader;
            try
            {
                conn.Open();
                myReader = addEmp.ExecuteReader();
                while (myReader.Read()) ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            conn.Close();
        }
    }
}
