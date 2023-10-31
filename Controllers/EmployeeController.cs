using lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace lab2.Controllers;

public class EmployeeController : Controller
{
    List<Employee> employees = new();

    public EmployeeController()
    {
        employees = new List<Employee>{
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
    }

    public IActionResult Index()
    {
        ViewBag.Layout = "_Lab2Layout";
        return View(employees);
    }
    public IActionResult Details(int id)
    {
        ViewBag.Layout = "_Lab2Layout";
        // Retrieve the employee by ID from the list (replace this with your data source).
        Employee employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
        {
            // You can handle the case where the employee is not found (e.g., return a not found view).
            return NotFound();
        }

        return View(employee);
    }
}