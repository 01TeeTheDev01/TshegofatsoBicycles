using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using User.Api.Models;
using User.Api.Models.Enums;

namespace User.Api.Services.DataContext
{
    public class UserDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> dbContextOptions) 
            : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //List<object> objects = new()
            //{
            //     new Client
            //     {
            //        Id = $"CLI-{new Random().Next(1000, 9999)}",
            //        FirstName = "Thabiso",
            //        MiddleName = string.Empty,
            //        LastName = "Mokoena",
            //        Gender = GenderType.Male.ToString(),
            //        Age = 34,
            //        Email = "thabiso.mokoena.1@gmail.com",
            //        PhoneNumber = "0821231234"
            //     },
            //     new Client
            //     {
            //        Id = $"CLI-{new Random().Next(1000, 9999)}",
            //        FirstName = "Bertus",
            //        MiddleName = "Werner",
            //        LastName = "Van Der Hobis",
            //        Gender = GenderType.Male.ToString(),
            //        Age = 25,
            //        Email = "werner.b.vanderhobis@gmail.com",
            //        PhoneNumber = "0721231234"
            //     },
            //     new Client
            //     {
            //        Id = $"CLI-{new Random().Next(1000, 9999)}",
            //        FirstName = "Mpho",
            //        MiddleName = string.Empty,
            //        LastName = "Matekane",
            //        Gender = GenderType.Female.ToString(),
            //        Age = 21,
            //        Email = "matekane.m.1@icloud.com",
            //        PhoneNumber = "0731231234"
            //     },
            //     new Client
            //     {
            //        Id = $"CLI-{new Random().Next(1000, 9999)}",
            //        FirstName = "Lerato",
            //        MiddleName = string.Empty,
            //        LastName = "Dlamini",
            //        Gender = GenderType.Female.ToString(),
            //        Age = 34,
            //        Email = "lee.dlamini4.1@icloud.com",
            //        PhoneNumber = "0790791234"
            //     },
            //     new Client
            //     {
            //        Id = $"CLI-{new Random().Next(1000, 9999)}",
            //        FirstName = "Fatima",
            //        MiddleName = string.Empty,
            //        LastName = "Jacobson",
            //        Gender = GenderType.Female.ToString(),
            //        Age = 30,
            //        Email = "fatima.jacobson10@outlook.com",
            //        PhoneNumber = "0820824321"
            //     },
            //     new Client
            //     {
            //        Id = $"CLI-{new Random().Next(1000, 9999)}",
            //        FirstName = "Jackson",
            //        MiddleName = string.Empty,
            //        LastName = "Mentjies",
            //        Gender = GenderType.Male.ToString(),
            //        Age = 23,
            //        Email = "jackson.mentjies@outlook.com",
            //        PhoneNumber = "0741231234"
            //     },
            //     new Employee
            //     {
            //         Id = "EMP-" + new Random().Next(10000, 99999),
            //         FirstName = "Janice",
            //         MiddleName = string.Empty,
            //         LastName = "Mthethwa",
            //         Gender = GenderType.Female.ToString(),
            //         Age = 23,
            //         Email = "j.mthethwa@tshegofatsobicycles.co.za",
            //         PhoneNumber = "0111231234",
            //         Position = "Sales Consultant",
            //         Company = "TshegofatsoBicycles (Pty) Ltd"
            //     },
            //     new Employee
            //     {
            //         Id = "EMP-" + new Random().Next(10000, 99999),
            //         FirstName = "Hopewell",
            //         MiddleName = string.Empty,
            //         LastName = "Mazibuko",
            //         Gender = GenderType.Male.ToString(),
            //         Age = 28,
            //         Email = "t.mazibuko@tshegofatsobicycles.co.za", PhoneNumber = "0111231234",
            //         Position = "Bicycle Techician",
            //         Company = "TshegofatsoBicycles (Pty) Ltd"
            //     },
            //     new Employee
            //     {
            //         Id = "EMP-" + new Random().Next(10000, 99999),
            //         FirstName = "Jeffrey",
            //         MiddleName = string.Empty,
            //         LastName = "Steenhuizen",
            //         Gender = GenderType.Male.ToString(),
            //         Age = 33,
            //         Email = "j.steenhuizen@tshegofatsobicycles.co.za",
            //         PhoneNumber = "0111234321",
            //         Position = "Bicycle Techician",
            //         Company = "TshegofatsoBicycles (Pty) Ltd"
            //     },
            //     new Employee
            //     {
            //         Id = "EMP-" + new Random().Next(10000, 99999),
            //         FirstName = "Antoinette",
            //         MiddleName = string.Empty,
            //         LastName = "Hartman",
            //         Gender = GenderType.Female.ToString(),
            //         Age = 23,
            //         Email = "a.hartman@tshegofatsobicycles.co.za",
            //         PhoneNumber = "0111232314",
            //         Position = "Sales Consultant",
            //         Company = "TshegofatsoBicycles (Pty) Ltd"
            //     },
            //     new Employee
            //     {
            //         Id = "EMP-" + new Random().Next(10000, 99999),
            //         FirstName = "Katlego",
            //         MiddleName = "Marcus",
            //         LastName = "Sibiya",
            //         Gender = GenderType.Male.ToString(),
            //         Age = 32,
            //         Email = "marcus.k.sibiya@tshegofatsobicycles.co.za",
            //         PhoneNumber = "0111231234",
            //         Position = "Sales Team Leader",
            //         Company = "TshegofatsoBicycles (Pty) Ltd"
            //     },
            //     new Employee
            //     {
            //         Id = "EMP-" + new Random().Next(10000, 99999),
            //         FirstName = "Bernice",
            //         MiddleName = "Logan",
            //         LastName = "Adams",
            //         Gender = GenderType.Female.ToString(),
            //         Age = 26,
            //         Email = "b.l.adams@tshegofatsobicycles.co.za",
            //         PhoneNumber = "0111233124",
            //         Position = "Receptionist",
            //         Company = "TshegofatsoBicycles (Pty) Ltd"
            //     },
            //     new Employee
            //     {
            //         Id = "EMP-" + new Random().Next(10000, 99999),
            //         FirstName = "Lloyd",
            //         MiddleName = string.Empty,
            //         LastName = "Mudau",
            //         Gender = GenderType.Male.ToString(),
            //         Age = 28,
            //         Email = "l.mudau@tshegofatsobicycles.co.za",
            //         PhoneNumber = "0111235234",
            //         Position = "Bicycle Techician",
            //         Company = "TshegofatsoBicycles (Pty) Ltd"
            //     },
            //     new Employee
            //     {
            //         Id = "EMP-" + new Random().Next(10000, 99999),
            //         FirstName = "Tshegofatso",
            //         MiddleName = string.Empty,
            //         LastName = "Mokobane",
            //         Gender = GenderType.Male.ToString(),
            //         Age = 31,
            //         Email = "t.mokobane@tshegofatsobicycles.co.za",
            //         PhoneNumber = "0820821234",
            //         Position = "CEO",
            //         Company = "TshegofatsoBicycles (Pty) Ltd"
            //     },
            //};

            //for (int i = 0; i < objects.Count; i++)
            //{
            //    if (objects[i] is Employee)
            //        modelBuilder.Entity<Employee>().HasData(objects[i]);

            //    if (objects[i] is Client)
            //        modelBuilder.Entity<Client>().HasData(objects[i]);
            //}
        }
    }
}
