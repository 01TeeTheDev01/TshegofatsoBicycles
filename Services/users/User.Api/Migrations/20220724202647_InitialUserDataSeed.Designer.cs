﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using User.Api.Services.DataContext;

namespace User.Api.Migrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20220724202647_InitialUserDataSeed")]
    partial class InitialUserDataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("User.Api.Models.Client", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = "CLI-4170",
                            Age = 34,
                            Email = "thabiso.mokoena.1@gmail.com",
                            FirstName = "Thabiso",
                            Gender = "Male",
                            LastName = "Mokoena",
                            MiddleName = "",
                            PhoneNumber = "0821231234"
                        },
                        new
                        {
                            Id = "CLI-2028",
                            Age = 25,
                            Email = "werner.b.vanderhobis@gmail.com",
                            FirstName = "Bertus",
                            Gender = "Male",
                            LastName = "Van Der Hobis",
                            MiddleName = "Werner",
                            PhoneNumber = "0721231234"
                        },
                        new
                        {
                            Id = "CLI-4993",
                            Age = 21,
                            Email = "matekane.m.1@icloud.com",
                            FirstName = "Mpho",
                            Gender = "Female",
                            LastName = "Matekane",
                            MiddleName = "",
                            PhoneNumber = "0731231234"
                        },
                        new
                        {
                            Id = "CLI-5671",
                            Age = 34,
                            Email = "lee.dlamini4.1@icloud.com",
                            FirstName = "Lerato",
                            Gender = "Female",
                            LastName = "Dlamini",
                            MiddleName = "",
                            PhoneNumber = "0790791234"
                        },
                        new
                        {
                            Id = "CLI-1887",
                            Age = 30,
                            Email = "fatima.jacobson10@outlook.com",
                            FirstName = "Fatima",
                            Gender = "Female",
                            LastName = "Jacobson",
                            MiddleName = "",
                            PhoneNumber = "0820824321"
                        },
                        new
                        {
                            Id = "CLI-4190",
                            Age = 23,
                            Email = "jackson.mentjies@outlook.com",
                            FirstName = "Jackson",
                            Gender = "Male",
                            LastName = "Mentjies",
                            MiddleName = "",
                            PhoneNumber = "0741231234"
                        });
                });

            modelBuilder.Entity("User.Api.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = "EMP-32160",
                            Age = 23,
                            Company = "TshegofatsoBicycles (Pty) Ltd",
                            Email = "j.mthethwa@tshegofatsobicycles.co.za",
                            FirstName = "Janice",
                            Gender = "Female",
                            LastName = "Mthethwa",
                            MiddleName = "",
                            PhoneNumber = "0111231234",
                            Position = "Sales Consultant"
                        },
                        new
                        {
                            Id = "EMP-31154",
                            Age = 28,
                            Company = "TshegofatsoBicycles (Pty) Ltd",
                            Email = "t.mazibuko@tshegofatsobicycles.co.za",
                            FirstName = "Hopewell",
                            Gender = "Male",
                            LastName = "Mazibuko",
                            MiddleName = "",
                            PhoneNumber = "0111231234",
                            Position = "Bicycle Techician"
                        },
                        new
                        {
                            Id = "EMP-66088",
                            Age = 33,
                            Company = "TshegofatsoBicycles (Pty) Ltd",
                            Email = "j.steenhuizen@tshegofatsobicycles.co.za",
                            FirstName = "Jeffrey",
                            Gender = "Male",
                            LastName = "Steenhuizen",
                            MiddleName = "",
                            PhoneNumber = "0111234321",
                            Position = "Bicycle Techician"
                        },
                        new
                        {
                            Id = "EMP-23256",
                            Age = 23,
                            Company = "TshegofatsoBicycles (Pty) Ltd",
                            Email = "a.hartman@tshegofatsobicycles.co.za",
                            FirstName = "Antoinette",
                            Gender = "Female",
                            LastName = "Hartman",
                            MiddleName = "",
                            PhoneNumber = "0111232314",
                            Position = "Sales Consultant"
                        },
                        new
                        {
                            Id = "EMP-59016",
                            Age = 32,
                            Company = "TshegofatsoBicycles (Pty) Ltd",
                            Email = "marcus.k.sibiya@tshegofatsobicycles.co.za",
                            FirstName = "Katlego",
                            Gender = "Male",
                            LastName = "Sibiya",
                            MiddleName = "Marcus",
                            PhoneNumber = "0111231234",
                            Position = "Sales Team Leader"
                        },
                        new
                        {
                            Id = "EMP-37638",
                            Age = 26,
                            Company = "TshegofatsoBicycles (Pty) Ltd",
                            Email = "b.l.adams@tshegofatsobicycles.co.za",
                            FirstName = "Bernice",
                            Gender = "Female",
                            LastName = "Adams",
                            MiddleName = "Logan",
                            PhoneNumber = "0111233124",
                            Position = "Receptionist"
                        },
                        new
                        {
                            Id = "EMP-84480",
                            Age = 28,
                            Company = "TshegofatsoBicycles (Pty) Ltd",
                            Email = "l.mudau@tshegofatsobicycles.co.za",
                            FirstName = "Lloyd",
                            Gender = "Male",
                            LastName = "Mudau",
                            MiddleName = "",
                            PhoneNumber = "0111235234",
                            Position = "Bicycle Techician"
                        },
                        new
                        {
                            Id = "EMP-32443",
                            Age = 31,
                            Company = "TshegofatsoBicycles (Pty) Ltd",
                            Email = "t.mokobane@tshegofatsobicycles.co.za",
                            FirstName = "Tshegofatso",
                            Gender = "Male",
                            LastName = "Mokobane",
                            MiddleName = "",
                            PhoneNumber = "0820821234",
                            Position = "CEO"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}