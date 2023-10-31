using lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class LeftNavigationViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var links = new List<LeftNavigationLink>
        {
            new("Home", "/Home/Index"),
            new("Employees", "/Employee/Index"),
            new("Privacy", "/Home/Privacy"),
        };

        return View(links);
    }
}
