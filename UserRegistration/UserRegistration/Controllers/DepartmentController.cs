using Busniess.Services;
using DataAccess.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistration.Controllers
{
    public class DepartmentController : Controller
    {
        IDepartmentService departmentService;
        public DepartmentController(IDepartmentService department)
        {
            departmentService = department;
        }
        public IActionResult Index()
        {
            ViewData["Edit"] = false;

            return View("NewDept");
        }

        public IActionResult DeptList()
        {
          List<Department> departments=  departmentService.GetDepartment();
            return View(departments);
        }
        public IActionResult Insert(Department department)
        {
            departmentService.Insert(department);
            return View("NewDept");
        }
        public IActionResult Edit(int id)
        {
            Department department = departmentService.Edit(id);
            ViewData["Edit"] = true;
            return View("NewDept",department);
        }  
        public IActionResult Update(Department department)
        {
            departmentService.update(department);
            List<Department> departments = departmentService.GetDepartment();

            return View("DeptList", departments);
        }
        public IActionResult Delete(int id)
        {
             departmentService.Delete(id);
            List<Department> departments = departmentService.GetDepartment();


            return View("DeptList", departments);
        }



    }
}
