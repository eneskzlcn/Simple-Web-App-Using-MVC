using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMVC.Models
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();

        Employee GetEmployeeById(int id);
    }
}
