using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using User.Api.Models;
using User.Api.Models.Enums;
using User.Api.Services.DataContext;

namespace User.Api.Services.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext dbContext;

        public UserRepository(UserDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }


        public Task<bool> CreateUser(int userType, string gender, string firstName, string middleName, string lastName, int age, string email, string phoneNumber, string position = null)
        {
            switch (userType)
            {
                case (int)UserType.Client:
                    var client = new Client
                    {
                        Id = $"CLI-{new Random().Next(1000, 9999)}",
                        FirstName = firstName,
                        MiddleName = middleName,
                        LastName = lastName,
                        Gender = gender,
                        Age = age,
                        Email = email,
                        PhoneNumber = phoneNumber
                    };
                    dbContext.Clients.Add(client);
                    dbContext.SaveChanges();
                    return Task.FromResult(true);


                case (int)UserType.Employee:
                    var employee = new Employee()
                    {
                        Id = $"EMP-{new Random().Next(10000, 99999)}",
                        FirstName = firstName,
                        MiddleName= middleName,
                        LastName= lastName,
                        Gender = gender,
                        Age = age,
                        Email = email,
                        PhoneNumber = phoneNumber, 
                        Position = position,
                        Company = "Tshegofatso Bicycles",
                    }; 
                    dbContext.Employees.Add(employee);
                    dbContext.SaveChanges();
                    return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public async Task<Employee> DeleteClientById(string id)
        {
            var clientToDelete = await dbContext.Clients.FirstOrDefaultAsync(client => client.Id == id);

            if (clientToDelete != null)
            {
                dbContext.Clients.Remove(clientToDelete);
                await dbContext.SaveChangesAsync();
            }

            return null;
        }

        public async Task<Client> GetClientByEmail(string email)
        {
            var result = await dbContext.Clients.FirstOrDefaultAsync(client => client.Email == email);

            if (result != null)
                return result;

            return result;
        }

        public async Task<IEnumerable<Client>> GetClientByFirstName(string firstName)
        {
            var result = await dbContext.Clients.Where(client => client.FirstName == firstName).ToListAsync();

            if (result != null)
                return result;

            return null;
        }

        public async Task<Client> GetClientById(string id)
        {
            var result = await dbContext.Clients.FirstOrDefaultAsync(client => client.Id == id);

            if (result != null)
                return result;

            return null;
        }

        public async Task<IEnumerable<Client>> GetClientByLastName(string lastName)
        {
            var result = dbContext.Clients.Where(client => client.LastName == lastName).ToList();

            if (result != null)
                return await Task.FromResult(result);

            return null;
        }

        public async Task<IEnumerable<Client>> GetClients()
        {
            var result = await dbContext.Clients.ToListAsync();

            if (result.Any())
                return result;

            return null;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByFirstName(string firstName)
        {
            var result = await dbContext.Employees.Where(client => client.FirstName == firstName).ToListAsync();

            if (result != null)
                return result;

            return null;
        }

        public async Task<Employee> GetEmployeeById(string employeeId)
        {
            var result = await dbContext.Employees.FirstOrDefaultAsync(client => client.Id == employeeId);

            if (result != null)
                return result;

            return null;
        }

        public async Task<IEnumerable<Employee>> GetEmployeeByLastName(string lastName)
        {
            var result = await dbContext.Employees.Where(client => client.LastName == lastName).ToListAsync();

            if (result != null)
                return result;

            return null;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var result = await dbContext.Employees.ToListAsync();

            if (result.Any())
                return result;

            return null;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByPostition(string position)
        {
            var result = await dbContext.Employees.Where(employee => employee.Position == position).ToListAsync();

            if (result != null)
                return result;

            return null;
        }

        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            var result = await dbContext.Employees.FirstOrDefaultAsync(employee => employee.Email == email);

            if (result != null)
                return result;

            return null;
        }

        

        public async Task<Employee> DeleteEmployeeById(string id)
        {
            var employeeToDelete = await dbContext.Employees.FirstOrDefaultAsync(employee => employee.Id == id);

            if (employeeToDelete != null)
            {
                dbContext.Employees.Remove(employeeToDelete);
                await dbContext.SaveChangesAsync();
            }

            return null;
        }
    }
}
