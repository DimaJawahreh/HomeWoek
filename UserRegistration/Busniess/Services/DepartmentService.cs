using DataAccess.Entity;
using DataAccess.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busniess.Services
{
  public  class DepartmentService: IDepartmentService
    {
        public void Insert(Department department)
        {
            IGenericService<Department> generic = new GenericService<Department>();
            generic.Insert(department);
        }
        public List<Department> GetDepartment()
        {
            IGenericService<Department> generic = new GenericService<Department>();
            List<Department> departments = generic.GetTs();
            return departments;
        }
        public Department Edit(int id)
        {
            IGenericService<Department> generic = new GenericService<Department>();
                return generic.Edit(id);
        }
        public void update(Department department)
        {
            IGenericService<Department> generic = new GenericService<Department>();
            generic.Update(department);

        }
        public void Delete(int id)
        {
            IGenericService<Department> generic = new GenericService<Department>();
            generic.DeleteById(id);

        }
    }
}
