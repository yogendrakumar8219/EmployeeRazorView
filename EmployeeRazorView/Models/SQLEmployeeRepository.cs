using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRazorView.Models
{
    public class SQLEmployeeRepository:IEmployeeRepository
    {
        private readonly AppDbContext context;
        public SQLEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Employee Add(Employee emp)
        {
            context.Employees.Add(emp);
            context.SaveChanges();
            return emp;
        }
        public Employee Delete(int EmployeeId)
        {
            Employee emp = context.Employees.Find(EmployeeId);
            if(emp!=null)
            {
                context.Employees.Remove(emp);
                context.SaveChanges();
            }
            return emp;
        }
        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees;
        }
        public Employee GetEmployee(int EmployeeId)
        {
            return context.Employees.Find(EmployeeId);
        }
        public Employee Update(Employee empChanges)
        {
            var emp = context.Employees.Attach(empChanges);
            emp.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return empChanges;
        }
    }
}
