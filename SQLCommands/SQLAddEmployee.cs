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
    class SQLAddEmployee
    {
        public void addEmployee(MyEmployees emp)
        {
            string addCommand = string.Format("Insert into MyEmployees (firstName, lastName, streetAddress, city, state, zipcode, phoneNumber, emailAddress)" +
                "Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", emp.firstName, emp.lastName, emp.streetAddress, emp.city,
                emp.state, emp.zipCode, emp.phoneNumber, emp.emailAddress);

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            conn.Close();
        }


    }
}
