using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRazorView.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int EmployeeId);
        IEnumerable<Employee> GetAllEmployee();
        Employee Add(Employee emp);
        Employee Update(Employee emp);
        Employee Delete(int EmployeeId);
    }
}
