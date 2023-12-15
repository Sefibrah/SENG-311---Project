using System.ComponentModel.DataAnnotations;

namespace lab2.Models
{
    public class SalaryInfo
    {
        public int Id { get; set; }
        public decimal Net { get; set; }
        public decimal Gross { get; set; }
        public Employee? Employee { get; set; }
    }
}