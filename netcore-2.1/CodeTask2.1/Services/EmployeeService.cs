using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTask21.DTO;
using CodeTask21.Entities;
using CodeTask21.Interfaces;

namespace CodeTask21.Services
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService()
        {
            
        }

        /// <summary>
        /// Deletes an employee
        /// </summary>
        /// <param name="id">The employee id</param>
        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets an employee with its id
        /// </summary>
        /// <param name="id">employee id</param>
        /// <returns></returns>
        public EmployeeViewModel GetEmployeeHandler(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Will create an employee with the provided Dto and calls the IUserRepository
        /// </summary>
        /// <param name="employeeDto"></param>
        /// <returns></returns>
        public EmployeeViewModel CreateEmployeeHandler(EmployeeDto employeeDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all the employees
        /// </summary>
        /// <returns></returns>
        public IList<EmployeeViewModel> GetAllHandler()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an employee
        /// </summary>
        /// <param name="employeeDto">Dto that contains the data to be updated</param>
        /// <returns></returns>
        public EmployeeViewModel UpdateEmployeeHandler(EmployeeDto employeeDto)
        {
            throw new NotImplementedException();
        }
    }
}
