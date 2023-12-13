using lab2.Data;
using lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class EmployeeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            using var context = new EmployeeContext();
            ViewBag.Layout = "_Lab2Layout";
            var employees = context.Employees.ToList();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            using var context = new EmployeeContext();
            ViewBag.Layout = "_Lab2Layout";
            var employee = context.Employees.Find(id);

            if (employee == null)
            {
                return View("Index");
            }

            return View(employee);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using var context = new EmployeeContext();
            ViewBag.Layout = "_Lab2Layout";
            var employee = context.Employees.Find(id);

            if (employee == null)
            {
                return View("Index");
            }

            return View("Edit", employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee updatedEmployee)
        {
            using var context = new EmployeeContext();
            if (ModelState.IsValid)
            {
                context.Employees.Update(updatedEmployee);
                context.SaveChanges();
                return RedirectToAction("Details", new { id = updatedEmployee.Id });
            }

            ViewBag.Layout = "_Lab2Layout";
            return View("Edit", updatedEmployee);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Layout = "_Lab2Layout";
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Employee newEmployee)
        {
            using var context = new EmployeeContext();
            if (ModelState.IsValid)
            {
                context.Employees.Add(newEmployee);
                context.SaveChanges();
                return RedirectToAction("Details", new { id = newEmployee.Id });
            }

            ViewBag.Layout = "_Lab2Layout";
            return View("Create", newEmployee);
        }

        [HttpGet("/Edit/Employee/{id?}")]
        public IActionResult Update(int id)
        {
            using var context = new EmployeeContext();
            ViewBag.Layout = "_Lab2Layout";
            var employee = context.Employees.Find(id);

            if (employee == null)
            {
                return View("Index");
            }

            return View("Update", employee);
        }

        [HttpPost]
        public IActionResult Update(Employee updatedEmployee)
        {
            using var context = new EmployeeContext();
            if (ModelState.IsValid)
            {
                context.Employees.Update(updatedEmployee);
                context.SaveChanges();
                return RedirectToAction("Details", new { id = updatedEmployee.Id });
            }

            ViewBag.Layout = "_Lab2Layout";
            return View("Update", updatedEmployee);
        }
    }
}
