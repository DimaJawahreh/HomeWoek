using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Entity
{
    [Table("Employees")]
  public  class Employee
    {
        public int id { set; get; }
        [Display(Name = "Name")]
        [Required]


        public string name { set; get; }
        [RegularExpression(@"07(7|8|9)\d{7}")]
        [Display(Name = "Phone")]

        public string phone { set; get; }
        [EmailAddress]
        [Display(Name = "Email")]
        [Required]


        public string email { set; get; }
        [Display(Name ="Gender")]
        [Required]

        public string gender { set; get; }
        [ForeignKey("Department")]
        public int dept_id { set; get; }
        public Department Department { set; get; }
    }
}
