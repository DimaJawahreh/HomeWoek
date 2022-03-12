using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busniess.Services
{
    public interface IEmployeeService
    {
        void Insert(Employee employee);
        List<Employee> GetEmployee();
        Employee Edit(int id);
        void update(Employee employee);
        void Delete(int id);
    }
}
