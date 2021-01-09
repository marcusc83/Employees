using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Model;

namespace Employees.Validators
{
    public class EmployerInfoValidator
    { 
        bool isValid;
        public bool checkEmpInfo(MyEmployees emp)
        {
           if(emp.firstName == null || emp.lastName == null || emp.streetAddress == null || emp.city == null ||
               emp.state == null || emp.zipCode == null || emp.phoneNumber == null || emp.phoneNumber == null ||
               emp.emailAddress == null)
            {
                isValid = false;
            }
           else
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
