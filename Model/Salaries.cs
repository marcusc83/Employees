using System.ComponentModel.DataAnnotations.Schema;

namespace Employees.Model
{
    public class Salaries
    {
        public int Id { get; set; }
        public double salary { get; set; }
        public int? MyEmployeesEmpId { get; set; }
        public virtual MyEmployees Employee { get; set; }
    }
}
