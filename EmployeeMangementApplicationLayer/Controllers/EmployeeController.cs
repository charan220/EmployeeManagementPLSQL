using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementManagerLayer.Interface;
using EmployeeManagementModelLayer;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMangementApplicationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        public IEmployeeManager employeeManager;
        public EmployeeController(IEmployeeManager employeeManager)
        {
            this.employeeManager = employeeManager;
        }

        [HttpPost]
        public IActionResult AddEmployeeDetails(Employee employee)
        {
            var item = this.employeeManager.AddEmployee(employee);
            return this.Ok(item);
        }
        [HttpDelete]
        public void DeleteEmployee(int id)
        {
            this.employeeManager.DeleteEmployee(id);
        }
        [HttpPut]
        public void UpdateEmployee(Employee employee)
        {
            this.employeeManager.UpdateEmployee(employee);
        }
        [HttpGet]
        public IEnumerable<Employee> DisplayAll()
        {
            return employeeManager.DisplayAllEmployees().AsEnumerable(); 
        }
    }
}