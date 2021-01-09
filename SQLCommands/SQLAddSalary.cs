using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employees.SQLCommands
{
    class SQLAddSalary
    {
        public void addSalary(string salary, string first, string last)
        {
           
            try
            {
                int id = 0;
                string getID = string.Format("select empId from MyEmployees where firstName = '{0}' and lastName ='{1}'", first, last);
                string connString = "Data Source=DESKTOP-OB29V6P;Initial Catalog=Employees.EmployeesDB;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand getEmpID = new SqlCommand(getID, conn);
                SqlDataReader myReader;
                conn.Open();
                try
                {
                   using(myReader = getEmpID.ExecuteReader())
                    {
                        while(myReader.Read())
                        {
                            string str = myReader["empId"].ToString();
                            id = Convert.ToInt32(str);
                        }
                    }               
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Getting EmpId Error");
                }

                string addCommand = string.Format("Insert into Salaries (salary,MyEmployeesEmpId)" +
                    "Values ('{0}','{1}')", salary, id);
                SqlCommand addSal = new SqlCommand(addCommand, conn);
                try
                {
                    myReader = addSal.ExecuteReader();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Setting Salary Error");
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error");
            }
           
        }
    }
}
