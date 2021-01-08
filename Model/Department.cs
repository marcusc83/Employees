using System.ComponentModel.DataAnnotations.Schema;

namespace Employees.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string department { get; set; }
        public int? MyEmployeesEmpId { get; set; }
        public virtual MyEmployees Employee { get; set; }
       
    }
}
