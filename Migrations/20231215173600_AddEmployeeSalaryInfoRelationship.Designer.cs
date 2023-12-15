﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lab2.Data;

#nullable disable

namespace lab2.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20231215173600_AddEmployeeSalaryInfoRelationship")]
    partial class AddEmployeeSalaryInfoRelationship
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("lab2.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "City1",
                            Country = "Country1",
                            Name = "Company1",
                            Zipcode = "12345"
                        },
                        new
                        {
                            Id = 2,
                            City = "City2",
                            Country = "Country2",
                            Name = "Company2",
                            Zipcode = "54321"
                        },
                        new
                        {
                            Id = 3,
                            City = "City3",
                            Country = "Country3",
                            Name = "Company3",
                            Zipcode = "75643"
                        },
                        new
                        {
                            Id = 4,
                            City = "City4",
                            Country = "Country4",
                            Name = "Company4",
                            Zipcode = "01232"
                        },
                        new
                        {
                            Id = 5,
                            City = "City5",
                            Country = "Country5",
                            Name = "Company5",
                            Zipcode = "65100"
                        });
                });

            modelBuilder.Entity("lab2.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalaryInfoId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("SalaryInfoId")
                        .IsUnique()
                        .HasFilter("[SalaryInfoId] IS NOT NULL");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1992, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "/images/Martin.jpg",
                            Name = "Martin",
                            Position = "Marketing Expert",
                            Surname = "Simpson"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1995, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "/images/Jacob.jpg",
                            Name = "Jacob",
                            Position = "Manager",
                            Surname = "Hawk"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2000, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "/images/Elizabeth.jpg",
                            Name = "Elizabeth",
                            Position = "Software Engineer",
                            Surname = "Geil"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1997, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "/images/Kate.jpg",
                            Name = "Kate",
                            Position = "Admin",
                            Surname = "Metain"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1990, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "/images/Michael.jpg",
                            Name = "Michael",
                            Position = "Marketing expert",
                            Surname = "Cook"
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(2001, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "/images/John.jpg",
                            Name = "John",
                            Position = "Software Engineer",
                            Surname = "Snow"
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateTime(1999, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "/images/Nina.jpg",
                            Name = "Nina",
                            Position = "Software Engineer",
                            Surname = "Soprano"
                        },
                        new
                        {
                            Id = 8,
                            BirthDate = new DateTime(2000, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "/images/Tina.jpg",
                            Name = "Tina",
                            Position = "Team Leader",
                            Surname = "Fins"
                        });
                });

            modelBuilder.Entity("lab2.Models.SalaryInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Gross")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Net")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("SalaryInfos");
                });

            modelBuilder.Entity("lab2.Models.Employee", b =>
                {
                    b.HasOne("lab2.Models.Company", null)
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId");

                    b.HasOne("lab2.Models.SalaryInfo", "SalaryInfo")
                        .WithOne("Employee")
                        .HasForeignKey("lab2.Models.Employee", "SalaryInfoId");

                    b.Navigation("SalaryInfo");
                });

            modelBuilder.Entity("lab2.Models.Company", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("lab2.Models.SalaryInfo", b =>
                {
                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}