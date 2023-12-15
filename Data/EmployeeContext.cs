using lab2.Models;
using Microsoft.EntityFrameworkCore;

namespace lab2.Data
{
    public class EmployeeContext : DbContext
    {
        static readonly string connectionString = "Server=localhost;Database=Seng311DB;User Id=sa;Password=12345OHdf%e;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";
        public DbSet<Employee> Employees { get; set; }
        // public DbSet<Company> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Insert the list of employees into the "Employees" table
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Martin",
                    Surname = "Simpson",
                    BirthDate = new DateTime(1992, 12, 3),
                    Position = "Marketing Expert",
                    Image = "/images/Martin.jpg"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Jacob",
                    Surname = "Hawk",
                    BirthDate = new DateTime(1995, 10, 2),
                    Position = "Manager",
                    Image = "/images/Jacob.jpg"
                },
                new Employee
                {
                    Id = 3,
                    Name = "Elizabeth",
                    Surname = "Geil",
                    BirthDate = new DateTime(2000, 1, 7),
                    Position = "Software Engineer",
                    Image = "/images/Elizabeth.jpg"
                },
                new Employee
                {
                    Id = 4,
                    Name = "Kate",
                    Surname = "Metain",
                    BirthDate = new DateTime(1997, 2, 13),
                    Position = "Admin",
                    Image = "/images/Kate.jpg"
                },
                new Employee
                {
                    Id = 5,
                    Name = "Michael",
                    Surname = "Cook",
                    BirthDate = new DateTime(1990, 12, 25),
                    Position = "Marketing expert",
                    Image = "/images/Michael.jpg"
                },
                new Employee
                {
                    Id = 6,
                    Name = "John",
                    Surname = "Snow",
                    BirthDate = new DateTime(2001, 7, 15),
                    Position = "Software Engineer",
                    Image = "/images/John.jpg"
                },
                new Employee
                {
                    Id = 7,
                    Name = "Nina",
                    Surname = "Soprano",
                    BirthDate = new DateTime(1999, 9, 30),
                    Position = "Software Engineer",
                    Image = "/images/Nina.jpg"
                },
                new Employee
                {
                    Id = 8,
                    Name = "Tina",
                    Surname = "Fins",
                    BirthDate = new DateTime(2000, 5, 14),
                    Position = "Team Leader",
                    Image = "/images/Tina.jpg"
                }
            );

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Company1", Zipcode = "12345", City = "City1", Country = "Country1" },
                new Company { Id = 2, Name = "Company2", Zipcode = "54321", City = "City2", Country = "Country2" },
                new Company { Id = 3, Name = "Company3", Zipcode = "75643", City = "City3", Country = "Country3" },
                new Company { Id = 4, Name = "Company4", Zipcode = "01232", City = "City4", Country = "Country4" },
                new Company { Id = 5, Name = "Company5", Zipcode = "65100", City = "City5", Country = "Country5" }
            );

            // modelBuilder.Entity<Company>()
            //     .HasMany(c => c.Employees)
            //     .WithOne(e => e.Company)
            //     .HasForeignKey(c => c.CompanyId);
        }

    }
}