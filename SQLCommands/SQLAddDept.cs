using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employees.SQLCommands
{
    class SQLAddDept
    {
        int id;
        public void addDepartment(string dept, string first, string last)
        {
            try
            {
                string getEmpId = string.Format("select empId from MyEmployees where firstname = '{0}' and lastName = '{1}'", first, last);
                
                string connString = "Data Source=DESKTOP-OB29V6P;Initial Catalog=Employees.EmployeesDB;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                
                SqlCommand getID = new SqlCommand(getEmpId, conn);
               
                conn.Open();
                SqlDataReader myReader;

                try
                {
                    using (myReader = getID.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            string str = myReader["empId"].ToString();
                            id = Convert.ToInt32(str);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Getting ID Error");
                }
                try
                {
                    string addCommand = string.Format("Insert into Departments (department, MyEmployeesEmpId)" +
                    "Values ('{0}','{1}')", dept, id);
                    SqlCommand addDept = new SqlCommand(addCommand, conn);

                    myReader = addDept.ExecuteReader();
                    while (myReader.Read()) ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Error");
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Opening Database Error");
            }
        }
    }
}

