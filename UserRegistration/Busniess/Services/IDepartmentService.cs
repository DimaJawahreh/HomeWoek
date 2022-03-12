using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busniess.Services
{
  public  interface IDepartmentService
    {
        void Insert(Department department);
        List<Department> GetDepartment();
        Department Edit(int id);
        void update(Department department);
        void Delete(int id);
    }
}
