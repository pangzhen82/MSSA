using Assignment10_3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10_3.Data
{
    public class CarContext : DbContext
    {
        public DbSet<CarModel> CarModels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=LAPTOP-OFOEO069;initial catalog=PCAD16Cars;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarModel>().HasData(
                new CarModel { VIN = "7ASDFSD34563456", Make = "TOYOTA", Model = "CAMRY", Price = 35_000, Year = 2024, Color = "Gray" },
                new CarModel { VIN = "7DKDKDK78436474", Make = "HONDA", Model = "TYPE R", Price = 65_000, Year = 2021, Color = "Red" },
                new CarModel { VIN = "7ASDDDF34563456", Make = "PORSCHE", Model = "911", Price = 95_000, Year = 2022, Color = "Light Blue" },
                new CarModel { VIN = "6JDJDKD85484948", Make = "TESLA", Model = "Y", Price = 65_000, Year = 2025, Color = "Quick Silver" },
                new CarModel { VIN = "4JDJDDK85757474", Make = "FORD", Model = "EXPLORER", Price = 35_000, Year = 2019, Color = "Black" },
                new CarModel { VIN = "5ASDU3JDD345236", Make = "MERCEDEZ", Model = "CLA200", Price = 35_000, Year = 2024, Color = "White" },
                new CarModel { VIN = "7AJDJDK84849856", Make = "BMW", Model = "Z4", Price = 55_000, Year = 2020, Color = "Neon Blue" }
            );
        }
    }
}
