using System.Collections.Generic;
using System.Threading.Tasks;

using User.Api.Models;

namespace User.Api.Services.Repository
{
    public interface IUserRepository
    {
        Task<bool> CreateUser(int userType, string gender, string firstName, string middleName, string lastName, int age, string email, string phoneNumber, string position);

        
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployeeById(string employeeId);
        Task<IEnumerable<Employee>> GetEmployeeByLastName(string email);
        Task<IEnumerable<Employee>> GetEmployeesByFirstName(string firstName);
        Task<IEnumerable<Employee>> GetEmployeesByPostition(string position);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<Employee> DeleteClientById(string id);


        Task<IEnumerable<Client>> GetClients();
        Task<Client> GetClientById(string id);
        Task<Client> GetClientByEmail(string email);
        Task<IEnumerable<Client>> GetClientByLastName(string lastName);
        Task<IEnumerable<Client>> GetClientByFirstName(string firstName);
        Task<Employee> DeleteEmployeeById(string id);
    }
}
