using EmployeeManagementModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeMangementRepositoryLayer
{
   public interface IEmployeeRepository   
    {
        object AddEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);
       bool DeleteEmployee(int id);
        IEnumerable<Employee> DisplayAllEmployees();
    }
}
