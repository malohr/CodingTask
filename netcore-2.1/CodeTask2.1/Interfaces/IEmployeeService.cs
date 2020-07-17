using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTask21.DTO;
using CodeTask21.Services;

namespace CodeTask21.Interfaces
{
    /// <summary>
    /// Service for handling the requests of EmployeeController
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEmployeeService
    {
        EmployeeViewModel CreateEmployeeHandler(EmployeeDto employeeDto);
        EmployeeViewModel UpdateEmployeeHandler(EmployeeDto employeeDto);
        IList<EmployeeViewModel> GetAllHandler();
        EmployeeViewModel GetEmployeeHandler(int id);
        void DeleteEmployee(int id);
    }
}
