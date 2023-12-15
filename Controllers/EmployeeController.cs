using lab2.Data;
using lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    [TypeFilter(typeof(CustomFilter))]
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
        [ValidateAntiForgeryToken]
        [TypeFilter(typeof(CustomFilter))]
        public IActionResult Edit([Bind("Name", "Surname", "Position", "BirthDate", "CompanyId", "Image", "SalaryInfo")] Employee updatedEmployee)
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
        [ValidateAntiForgeryToken]
        [TypeFilter(typeof(CustomFilter))]
        public IActionResult Create([Bind("Name", "Surname", "Position", "BirthDate", "CompanyId", "Image", "SalaryInfo")] Employee newEmployee)
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
        [ValidateAntiForgeryToken]
        [TypeFilter(typeof(CustomFilter))]
        public IActionResult Update([Bind("Name", "Surname", "Position", "BirthDate", "CompanyId", "Image", "SalaryInfo")] Employee updatedEmployee)
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
        [HttpGet]
        public IActionResult SalaryDetails()
        {
            using var context = new EmployeeContext();
            var employeeSalaryList = (from e in context.Employees
                                      join c in context.Companies on e.CompanyId equals c.Id
                                      where e.SalaryInfo != null
                                      select new EmployeeSalaryDto
                                      {
                                          Id = e.Id,
                                          FullName = $"{e.Name} {e.Surname}",
                                          CompanyName = c.Name,
                                          NetSalary = e.SalaryInfo.Net,
                                          GrossSalary = e.SalaryInfo.Gross
                                      }).ToList();



            ViewBag.Layout = "_Lab2Layout";
            return View("SalaryDetails", employeeSalaryList);
        }
    }
}
