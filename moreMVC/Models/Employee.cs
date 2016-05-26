using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace moreMVC.Models
{
    public class Employee
    {
       [Key]
            public int EmployeeId { get; set; }
            //Foreign Key for Departments
            public int DeptId { get; set; }
            public Department Department { get; set; }

        [Display(Name = "Employee A")]
        public string EmployeeA { get; set; }
        [Display(Name = "Employee B")]
        public string EmployeeB { get; set; }
        [Display(Name = "Employee C")]
        public string EmployeeC { get; set; }
        [Display(Name = "Employee D")]
        public string EmployeeD { get; set; }
        [Display(Name = "Employee E")]
        public string EmployeeE { get; set; }
        }
    }
