// CompanyController.cs
using lab2.Data;
using lab2.Models;
using Microsoft.AspNetCore.Mvc;

public class CompanyController : Controller
{

    [HttpGet]
    public IActionResult Index()
    {
        using var context = new EmployeeContext();
        var companyDetailsList = (from c in context.Companies
                                  join e in context.Employees on c.Id equals e.CompanyId into ce
                                  //   from emp in ce.DefaultIfEmpty()
                                  select new CompanyDetailsDto
                                  {
                                      Id = c.Id,
                                      Name = c.Name,
                                      FullAddress = $"{c.City}, {c.Country}, {c.Zipcode}",
                                      NumberOfEmployees = ce.Count()
                                  }).Distinct().ToList();

        ViewBag.Layout = "_Lab2Layout";
        return View("Index", companyDetailsList);
    }
}
