using EmployeeManagementManagerLayer.Interface;
using EmployeeManagementModelLayer;
using EmployeeMangementRepositoryLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementManagerLayer.Manager
{
    public class EmployeeManger : IEmployeeManager
    {
         IEmployeeRepository employeeRepository;

        public EmployeeManger(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public  object AddEmployee(Employee employee)
        {
            return this.employeeRepository.AddEmployee(employee);

        }

        public bool DeleteEmployee(int id)
        {
            return this.employeeRepository.DeleteEmployee(id);
        }

        public IEnumerable<Employee> DisplayAllEmployees()
        {
            return this.employeeRepository.DisplayAllEmployees();
        }

        public object GetEmployee(int id)
        {
            return this.employeeRepository.GetEmployee(id);
        }

        public bool UpdateEmployee(Employee employee)
        {
            return this.employeeRepository.UpdateEmployee(employee);
        }
    }
}
