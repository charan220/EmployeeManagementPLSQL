using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using EmployeeManagementModelLayer;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace EmployeeMangementRepositoryLayer.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IConfiguration configuration;
        public EmployeeRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public object AddEmployee(Employee employee)
                    {
            var commandText = Queries.addEmployeeQuery;

            using (var _db = new OracleConnection(configuration.GetConnectionString("UserDbConnection")))
            using (OracleCommand cmd = new OracleCommand(commandText, _db))
            {
                cmd.Connection = _db;
                cmd.Parameters.Add("employeeid", employee.EmployeeID);
                cmd.Parameters.Add("employeename", employee.EmployeeName);
                cmd.Parameters.Add("phonenumber", employee.PhoneNumber);
                cmd.Parameters.Add("address", employee.Address);
                cmd.Parameters.Add("department", employee.Department);
                cmd.Parameters.Add("gender", employee.Gender);
                cmd.Parameters.Add("basicpay", employee.BasicPay);
                cmd.Parameters.Add("deductions", employee.Deductions);
                cmd.Parameters.Add("taxablepay", employee.TaxablePay);
                cmd.Parameters.Add("tax", employee.Tax);
                cmd.Parameters.Add("netpay", employee.NetPay);
                cmd.Parameters.Add("city", employee.City);
                cmd.Parameters.Add("country", employee.Country);
                _db.Open();
                cmd.ExecuteNonQuery();
                _db.Close();
                return employee.EmployeeID + "=employee ID is sucessfull added";
            }

        }               

        public bool DeleteEmployee(int id)
        {
            try
            {
                var commandText = Queries.deleteEmployeeQuery;
                using (var _db = new OracleConnection(configuration.GetConnectionString("UserDbConnection")))
                using (OracleCommand cmd = new OracleCommand(commandText, _db))
                {
                    cmd.Connection = _db;
                    cmd.Parameters.Add("employeeid", id);

                    _db.Open();
                    int value = cmd.ExecuteNonQuery();
                    _db.Close();
                    if (value >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }



        }

        public IEnumerable<Employee> DisplayAllEmployees()
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(Employee employee)
        {
            try
            {
                var commandText = Queries.updateEmployeeQuery;
                using (var _db = new OracleConnection(configuration.GetConnectionString("UserDbConnection")))
                using (OracleCommand cmd = new OracleCommand(commandText, _db))
                {
                    cmd.Connection = _db;
                    cmd.Parameters.Add("employeeid", employee.EmployeeID);
                    cmd.Parameters.Add("employeename", employee.EmployeeName);
                    cmd.Parameters.Add("phonenumber", employee.PhoneNumber);
                    cmd.Parameters.Add("address", employee.Address);
                    cmd.Parameters.Add("department", employee.Department);
                    cmd.Parameters.Add("gender", employee.Gender);
                    cmd.Parameters.Add("basicpay", employee.BasicPay);
                    cmd.Parameters.Add("deductions", employee.Deductions);
                    cmd.Parameters.Add("taxablepay", employee.TaxablePay);
                    cmd.Parameters.Add("tax", employee.Tax);
                    cmd.Parameters.Add("netpay", employee.NetPay);
                    cmd.Parameters.Add("city", employee.City);
                    cmd.Parameters.Add("country", employee.Country);
                   
                    _db.Open();
                    int value = cmd.ExecuteNonQuery();
                    _db.Close();
                    if (value >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


        }
    }
}
