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
        /// <summary>
        ///  Adding the details of employee
        /// </summary>
        /// <param name="employee">The model class employee</param>
        /// <returns>The async result</returns>
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            try
            {
                var item = this.employeeManager.AddEmployee(employee);
                if (item != null)
                {
                    return this.Ok(new { Status=true,Message="Employee added successfully",Data=item});
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = "Employee added unsuccessfully", Data = item });
                }
            }
            catch   (Exception e)
            {
                return this.NotFound(new { Status = false, Message = e.Message});
            }
            
            
        }
        /// <summary>
        /// Deleting details of a particular employee details
        /// </summary>
        /// <param name="id">The model class employee id</param>
        /// <returns>The id</returns>
        [HttpDelete]
        [Route("{empId}")]
        public IActionResult DeleteEmployee(int empId)
        {
            try
            {
                var result = this.employeeManager.DeleteEmployee(empId);
                if (result == true)
                {
                    return this.Ok(new { Status = true, Message = "Employee deleted successfully", Data = result});
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = "Employee deleted unsuccessfully", Data = result});
                }
            }
            catch (Exception e)
            {
                return this.NotFound(new { Status = false, Message = e.Message });
            }

        }
        /// <summary>
        /// Updating the of employee
        /// </summary>
        /// <param name="employeeChanges">The model class employeeChanges</param>
        /// <returns>Th async result</returns>
        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {   try
            {
                var result = this.employeeManager.UpdateEmployee(employee);
                if (result == true)
                {
                    return this.Ok(new { Status = true, Message = "Employee updated successfully", Data = result});
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = "Employee added unsuccessfully", Data = result });
                }
            }
            catch(Exception e)
            {
                return this.NotFound(new { Status = false, Message = e.Message });
            }
        }
        /// <summary>
        ///  Getting the details of employee
        /// </summary>
        /// <param name="id">The model class employee id</param>
        /// <returns>The employee id</returns>
        [HttpGet]
        [Route("{empId}")]   
         public IActionResult GetEmployee(int empId)
        {
            try
            {
               var result=this.employeeManager.GetEmployee(empId);
                if (!result.Equals(null))
                {
                    return this.Ok(new { Status = true, Message = "Employee updated successfully", Data = result });
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = "Employee added unsuccessfully", Data = result });
                }
            }
            catch (Exception e)
            {
                return this.NotFound(new { Status = false, Message = e.Message });
            }

        }
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeManager.DisplayAllEmployees().AsEnumerable(); 
        }
    }
}