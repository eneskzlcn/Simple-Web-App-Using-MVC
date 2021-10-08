using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMVC.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> employees = new List<Employee>

        {
            new Employee{employeeId=1,firstName="Ahmet",lastName = "Ak"},
            new Employee{employeeId=2,firstName="Mehmet",lastName = "Ak"},
            new Employee{employeeId=3,firstName="Ayşe",lastName = "Ak"}
        };

        public Employee GetEmployeeById(int id)
        {
            var employee = employees.FirstOrDefault(e => e.employeeId == id);
            return employee;

        }

        public List<Employee> GetEmployees()
        {
            return employees;

        }
    }
}
