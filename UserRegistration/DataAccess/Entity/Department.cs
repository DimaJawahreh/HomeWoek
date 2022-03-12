using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Entity
{
    [Table("Departments")]
   public class Department
    {
        public int id { set; get; }
        [Required]
        public string Name { set; get; }
        public List<Employee> Employees { set; get; }
    }
}
