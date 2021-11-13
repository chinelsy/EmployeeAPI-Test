using EmployeesApp.Contracts;
using EmployeesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApp.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _context;

        public EmployeeRepository(EmployeeContext context)
        {
            _context = context;
        }
        public void CreateEmployee(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployee(Guid id)
        {
            return _context.Employees.SingleOrDefault(e => e.Id.Equals(id));
        }
    }
}
