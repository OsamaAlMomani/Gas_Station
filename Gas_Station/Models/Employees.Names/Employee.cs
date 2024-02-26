using System.ComponentModel.DataAnnotations;

namespace Gas_Station.Models.Employees.Names
{
    public class Employee
    {
        public int employeeId {  get; set; }
        public string name { get; set; }

        [DataType(DataType.Date)]
        public DateOnly DateOfJoining { get; set; }

        public float Salary { get; set; }

    }
}
