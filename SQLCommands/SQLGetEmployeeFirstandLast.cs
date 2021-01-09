using Employees.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees.SQLCommands
{
    class SQLGetEmployeeFirstandLast
    {
        public List<string> getEmployeeNames()
        {
            List<string> emps = new List<string>();

            string getCommand = "select firstName, lastName from MyEmployees";


            string connString = "Data Source=DESKTOP-OB29V6P;Initial Catalog=Employees.EmployeesDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand getEmp = new SqlCommand(getCommand, conn);
            SqlDataReader myReader;

            try
            {
                string first;
                string last;
                string name;
                conn.Open();
                using (myReader = getEmp.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        
                        first = myReader["firstName"].ToString();
                        last = myReader["lastName"].ToString();
                        name = first.Trim() + " " + last.Trim();
                        emps.Add(name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            conn.Close();
            return emps;
        }
    }
}
