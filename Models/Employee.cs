using System.ComponentModel.DataAnnotations;
namespace lab2.Models;
public class Employee
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    [MinLength(3, ErrorMessage = "Name must be at least 3 characters.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Surname is required.")]
    [MinLength(3, ErrorMessage = "Surname must be at least 3 characters.")]
    public string? Surname { get; set; }

    [Required(ErrorMessage = "Position is required.")]
    [MinLength(3, ErrorMessage = "Position must be at least 3 characters.")]
    public string? Position { get; set; }

    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }
    public string? Image { get; set; }
    public int? CompanyId { get; set; }
    public Company? Company { get; set; }
    public int? SalaryInfoId { get; set; }
    public SalaryInfo? SalaryInfo { get; set; }
}