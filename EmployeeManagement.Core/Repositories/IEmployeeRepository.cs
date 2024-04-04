using EmployeeManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<List<Employee>> GetEmployeesAsync();
        public Task<Employee> GetEmployeeByIdAsync(int EmployeeId);
        public Task AddEmployeeAsync(Employee employee);
        public  Task UpdateEmployeeAsync(int EmployeeId, Employee employee);
        public Task DeleteEmployeeAsync(int EmployeeId);
    }
}
