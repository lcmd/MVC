using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace moreMVC.Models
{
    public class Department
    {
        [Key]
     public int DeptId { get; set; }
        [Display(Name = "Department Name")]
        public string DeptName { get; set; }

    }
}