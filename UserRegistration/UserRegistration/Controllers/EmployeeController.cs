using Busniess.Services;
using DataAccess.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserRegistration.Models;

namespace UserRegistration.Controllers
{
    public class EmployeeController : Controller
    {
        IDepartmentService departmentService;
        IEmployeeService employeeService;
        public EmployeeController(IDepartmentService _departmentService, IEmployeeService _employeeService)
        {
            departmentService = _departmentService;
            employeeService = _employeeService;
        }
        public IActionResult Index()
        {
            VMEmployee vm = new VMEmployee();
            vm.lidept = departmentService.GetDepartment();
            ViewData["Edit"] = false;

            return View("NewEmployee",vm);
        }
        public IActionResult EmpList()
        {
            List<Employee> employees = employeeService.GetEmployee();
            return View(employees);
        }
        public IActionResult Insert(VMEmployee vm)

        {
            employeeService.Insert(vm.employee);
            ViewData["Edit"] = false;


            vm.lidept = departmentService.GetDepartment();
            return View("NewEmployee", vm);
        }
        public IActionResult Edit(int id)
        {
            VMEmployee vm = new VMEmployee();
            vm.employee = employeeService.Edit(id);
            vm.lidept = departmentService.GetDepartment();
            ViewData["Edit"] = true;
            return View("NewEmployee", vm);
        }
        public IActionResult Update(VMEmployee vm)
        {
            employeeService.update(vm.employee);

            return RedirectToAction("EmpList");
        }
        public IActionResult delete(int id)
        {
            employeeService.Delete(id);

            return RedirectToAction("EmpList");
        }
    }
}
