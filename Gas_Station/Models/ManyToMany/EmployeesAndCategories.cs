using Gas_Station.Models.Categories.Names;
using Gas_Station.Models.Employees.Names;

namespace Gas_Station.Models.ManyToMany
{
    public class EmployeesAndCategories
    {
        public Guid RelationId { get; set; }    
        public Stations station { get; set; }
        public Employee employee { get; set; }
    }
}
