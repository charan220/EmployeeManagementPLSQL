﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagementModelLayer
{
   public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
