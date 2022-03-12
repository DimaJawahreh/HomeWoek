using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistration.Models
{
    public class VMEmployee
    {

        public Employee employee { set; get; }
        public List<Department> lidept { set; get; }
    }
}
