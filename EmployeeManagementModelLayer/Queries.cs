using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementModelLayer
{
   public class Queries
    {
        public static string addEmployeeQuery = "insert into CharanSystem.Employee(employeeid,employeename,phonenumber,address,department,gender,basicpay,deductions,taxablepay,tax,netpay,city,country)  VALUES (:employeeid,:employeename,:phonenumber,:address,:department,:gender,:basicpay,:deductions,:taxablepay,:tax,:netpay,:city,:country)";
        public static string deleteEmployeeQuery = "delete from CharanSystem.Employee where employeeid=:id";
        public static string updateEmployeeQuery = "update CharanSystem.Employee SET employeename=:employeename,phonenumber=:phonenumber,address=:address,department=:department,gender=:gender,basicpay=:basicpay,deductions=:deductions,taxablepay=:taxablepay,tax=:tax,netpay=:netpay,city=:city,country=:country where employeeid=:employeeid";
        public static string getSpecifiedEmployeeQuery = "select * from Employee WHERE employeeid=:id ";
    }
}
