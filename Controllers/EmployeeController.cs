using lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace lab2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly List<Employee> employees = new()
        {
            new()
            {
                Id = 0,
                Name = "Martin",
                Surname = "Simpson",
                BirthDate = new DateTime(1992, 12, 3),
                Position = "Marketing Expert",
                Image = "/images/Martin.jpg"
            },
            new()
            {
                Id = 1,
                Name = "Jacob",
                Surname = "Hawk",
                BirthDate = new DateTime(1995, 10, 2),
                Position = "Manager",
                Image = "/images/Jacob.jpg"
            },
            new ()
            {
                Id = 2,
                Name = "Elizabeth",
                Surname = "Geil",
                BirthDate = new DateTime(2000, 1, 7),
                Position = "Software Engineer",
                Image = "/images/Elizabeth.jpg"
            },
            new()
            {
                Id = 3,
                Name = "Kate",
                Surname = "Metain",
                BirthDate = new DateTime(1997, 2, 13),
                Position = "Admin",
                Image="/images/Kate.jpg"
            },
            new ()
            {
                Id = 4,
                Name = "Michael",
                Surname = "Cook",
                BirthDate = new DateTime (1990, 12, 25),
                Position = "Marketing expert",
                Image="/images/Michael.jpg"
            },
            new()
            {
                Id = 5,
                Name = "John",
                Surname = "Snow",
                BirthDate = new DateTime(2001, 7, 15),
                Position = "Software Engineer",
                Image="/images/John.jpg"
            },
            new ()
            {
                Id = 6,
                Name = "Nina",
                Surname = "Soprano",
                BirthDate = new DateTime (1999, 9, 30),
                Position = "Software Engineer",
                Image="/images/Nina.jpg"
            },
            new ()
            {
                Id = 7,
                Name = "Tina",
                Surname = "Fins",
                BirthDate = new DateTime (2000, 5, 14),
                Position = "Team Leader",
                Image="/images/Tina.jpg"
            }
        };

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Layout = "_Lab2Layout";
            return View(employees);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            ViewBag.Layout = "_Lab2Layout";
            Employee employee = employees.Find(e => e.Id == id);

            if (employee == null)
            {
                return View("Index");
            }

            return View(employee);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Layout = "_Lab2Layout";
            Employee employee = employees.Find(e => e.Id == id);

            if (employee == null)
            {
                return View("Index");
            }

            return View("Form", employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee updatedEmployee)
        {
            if (ModelState.IsValid)
            {
                Employee employeeToUpdate = employees.Find(e => e.Id == updatedEmployee.Id);

                if (employeeToUpdate == null)
                {
                    return NotFound();
                }

                // Update the employee in the list
                employeeToUpdate.Name = updatedEmployee.Name;
                employeeToUpdate.Surname = updatedEmployee.Surname;
                employeeToUpdate.BirthDate = updatedEmployee.BirthDate;
                employeeToUpdate.Position = updatedEmployee.Position;
                employeeToUpdate.Image = updatedEmployee.Image;

                return RedirectToAction("Index");
            }

            ViewBag.Layout = "_Lab2Layout";
            return View("Form", updatedEmployee);
        }

        [HttpGet("/Edit/Employee/{id?}")]
        public IActionResult Update(int id)
        {
            ViewBag.Layout = "_Lab2Layout";
            Employee employee = employees.Find(e => e.Id == id);

            if (employee == null)
            {
                return View("Index");
            }

            return View("Form", employee);
        }

        [HttpPost]
        public IActionResult Update(Employee updatedEmployee)
        {
            if (ModelState.IsValid)
            {
                Employee employeeToUpdate = employees.Find(e => e.Id == updatedEmployee.Id);

                if (employeeToUpdate == null)
                {
                    return NotFound();
                }

                // Update the employee in the list
                employeeToUpdate.Name = updatedEmployee.Name;
                employeeToUpdate.Surname = updatedEmployee.Surname;
                employeeToUpdate.BirthDate = updatedEmployee.BirthDate;
                employeeToUpdate.Position = updatedEmployee.Position;
                employeeToUpdate.Image = updatedEmployee.Image;

                return RedirectToAction("Index");
            }

            ViewBag.Layout = "_Lab2Layout";
            return View("Form", updatedEmployee);
        }
    }
}
