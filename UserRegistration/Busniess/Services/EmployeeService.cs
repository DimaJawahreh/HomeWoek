using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Busniess.Services
{
   public class EmployeeService: IEmployeeService
    {
        UserContext context;
        public EmployeeService(UserContext userContext)
        {
            context = userContext;
        }
        public void Insert(Employee employee)
        {
            IGenericService<Employee> generic = new GenericService<Employee>();
            generic.Insert(employee);
        }
        public List<Employee> GetEmployee()
        {
            List<Employee> departments = context.employees.Include("Department").ToList();
            return departments;
        }
        public Employee Edit(int id)
        {
            IGenericService<Employee> generic = new GenericService<Employee>();
            return generic.Edit(id);
        }
        public void update(Employee employee)
        {
            IGenericService<Employee> generic = new GenericService<Employee>();
            generic.Update(employee);

        }
        public void Delete(int id)
        {
            IGenericService<Employee> generic = new GenericService<Employee>();
            generic.DeleteById(id);

        }
    }
}

