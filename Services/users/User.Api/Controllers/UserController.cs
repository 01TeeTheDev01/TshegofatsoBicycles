using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using User.Api.Models;
using User.Api.Models.Enums;
using User.Api.Services.Repository;

namespace User.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }


        [HttpPost("createNewUser")]
        public async Task<ActionResult<object>> CreateNewUser(int userType, int gender, string firstName, string middleName, string lastName, int age, string email, string phoneNumber, string position = null)
        {
            bool isCreated;

            switch (userType)
            {
                case (int)UserType.Client:
                    switch (gender)
                    {
                        case (int)GenderType.Female:
                            var femaleClient = await _userRepository.CreateUser((int)UserType.Client, GenderType.Female.ToString(), firstName, middleName, lastName, age, email, phoneNumber, string.Empty);
                            
                            isCreated = femaleClient;

                            if (isCreated)
                                return Ok("Client added to database!");

                            return BadRequest("Failed to capture employee details! Contact your system administrator.");

                        case (int)GenderType.Male:
                            var maleClient = await _userRepository.CreateUser((int)UserType.Client, GenderType.Male.ToString(), firstName, middleName, lastName, age, email, phoneNumber, string.Empty);

                            isCreated = maleClient;

                            if (isCreated)
                                return Ok("Client added to database!");

                            return BadRequest("Failed to capture employee details! Contact your system administrator.");

                        case (int)GenderType.Other:
                            var otherClient = await _userRepository.CreateUser((int)UserType.Client, GenderType.Other.ToString(), firstName, middleName, lastName, age, email, phoneNumber, string.Empty);

                            isCreated = otherClient;

                            if (isCreated)
                                return Ok("Client added to database!");

                            return BadRequest("Failed to capture employee details! Contact your system administrator.");

                        default:
                            return BadRequest("Invalid option detected!");
                    }

                case (int)UserType.Employee:
                    switch (gender)
                    {
                        case (int)GenderType.Female:
                            var femaleEmployee = await _userRepository.CreateUser((int)UserType.Employee, GenderType.Female.ToString(), firstName, middleName, lastName, age, email, phoneNumber, position);

                            isCreated = femaleEmployee;

                            if (isCreated)
                                return Ok("Employee added to database!");

                            return BadRequest("Failed to capture employee details! Contact your system administrator.");

                        case (int)GenderType.Male:
                            var maleEmployee = await _userRepository.CreateUser((int)UserType.Employee, GenderType.Male.ToString(), firstName, middleName, lastName, age, email, phoneNumber, position);

                            isCreated = maleEmployee;

                            if (isCreated)
                                return Ok("Employee added to database!");

                            return BadRequest("Failed to capture employee details! Contact your system administrator.");

                        case (int)GenderType.Other:
                            var otherEmployee = await _userRepository.CreateUser((int)UserType.Employee, GenderType.Other.ToString(), firstName, middleName, lastName, age, email, phoneNumber, position);

                            isCreated = otherEmployee;

                            if (isCreated)
                                return Ok("Employee added to database!");

                            return BadRequest("Failed to capture employee details! Contact your system administrator.");

                        default:
                            return BadRequest("Invalid option detected!");
                    }

                default:
                    return BadRequest("Invalid option detected!");
            }
        }


        [HttpDelete("deleteClientById")]
        public async Task<ActionResult<IEnumerable<Client>>> DeleteClientById(string id)
        {
            var result = await _userRepository.DeleteClientById(id);

            if (result != null)
                return Ok($"Client = '{result.Id}' has been removed off the system!");

            return NotFound($"No client found with Id = '{id}'!");
        }

        [HttpGet("getCustomers")]
        public async Task<ActionResult<IEnumerable<Client>>> GetCustomers()
        {
            var result = await _userRepository.GetClients();

            if (result != null)
                return Ok(result);

            return NoContent();
        }


        [HttpGet("getCustomersById")]
        public async Task<ActionResult<IEnumerable<Client>>> GetCustomerById(string id)
        {
            var result = await _userRepository.GetClientById(id);

            if (result != null)
                return Ok(result);

            return NotFound($"No client found with Id = '{id}'!");
        }

        [HttpGet("getCustomersByName")]
        public async Task<ActionResult<IEnumerable<Client>>> GetCustomerByName(string name)
        {
            var result = await _userRepository.GetClientByFirstName(name);

            if (result != null)
                return Ok(result);

            return NotFound($"Client with firstname = '{name}' does not exist on the system!");
        }

        [HttpGet("getCustomersByLastName")]
        public async Task<ActionResult<IEnumerable<Client>>> GetCustomerByLastName(string lastName)
        {
            var result = await _userRepository.GetClientByLastName(lastName);

            if (result != null)
                return Ok(result);

            return NotFound($"Client with lastname = '{lastName}' does not exist on the system!");
        }

        [HttpGet("getCustomersByEmail")]
        public async Task<ActionResult<IEnumerable<Client>>> GetCustomerByEmail(string email)
        {
            var result = await _userRepository.GetClientByEmail(email);

            if (result != null)
                return Ok(result);

            return NotFound($"Client with email address = '{email}' does not exist on the system!");
        }



        //Employee methods
        #region
        [HttpDelete("deleteEmployeeById")]
        public async Task<ActionResult<IEnumerable<Client>>> DeleteEmployeeById(string id)
        {
            var result = await _userRepository.DeleteEmployeeById(id);

            if (result != null)
                return Ok($"Employee = '{result.Id}' has been removed off the system!");

            return NotFound($"No employee found with Id = '{id}'!");
        }

        [HttpGet("getEmployees")]
        public async Task<ActionResult<IEnumerable<Client>>> GetEmployees()
        {
            var result = await _userRepository.GetEmployees();

            if (result != null)
                return Ok(result);

            return NoContent();
        }


        [HttpGet("getEmployeeById")]
        public async Task<ActionResult<Client>> GetEmployeeById(string id)
        {
            var result = await _userRepository.GetEmployeeById(id);

            if (result != null)
                return Ok(result);

            return NotFound($"No employee found with Id = '{id}' on the system!");
        }

        [HttpGet("getEmployeesByFirstName")]
        public async Task<ActionResult<IEnumerable<Client>>> GetEmployeesByFirstName(string name)
        {
            var result = await _userRepository.GetEmployeesByFirstName(name);

            if (result != null)
                return Ok(result);

            return NotFound($"Employees with firstname = '{name}' do not exist on the system!");
        }

        [HttpGet("getEmployeesByLastName")]
        public async Task<ActionResult<IEnumerable<Client>>> GetEmployeesByLastName(string lastName)
        {
            var result = await _userRepository.GetEmployeeByLastName(lastName);

            if (result != null)
                return Ok(result);

            return NotFound($"Employees with lastname = '{lastName}' do not exist on the system!");
        }

        [HttpGet("getEmployeeByEmail")]
        public async Task<ActionResult<IEnumerable<Client>>> GetEmployeeByEmail(string email)
        {
            var result = await _userRepository.GetEmployeeByEmail(email);

            if (result != null)
                return Ok(result);

            return NotFound($"Employee with email address = '{email}' does not exist on the system!");
        }

        [HttpGet("getEmployeesByJobPosition")]
        public async Task<ActionResult<IEnumerable<Client>>> GetEmployeesByJobPosition(string jobPosition)
        {
            var result = await _userRepository.GetEmployeesByPostition(jobPosition);

            if (result != null)
                return Ok(result);

            return NotFound($"No employees exists with the position = '{jobPosition}' on the system!");
        }
        #endregion
    }
}