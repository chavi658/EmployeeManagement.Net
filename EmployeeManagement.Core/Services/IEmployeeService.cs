using EmployeeManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Services
{
    public interface IEmployeeService
    {
        public Task<List<Employee>> GetAllAsync();
        public Task<Employee> GetByIdAsync(int EmployeeId);
        public Task AddEmployeeAsync (Employee employee);
        public Task UpdateEmployeeAsync(int EmployeeId, Employee employee);
        public Task DeleteEmployeeAsync(int EmployeeId);
    }
}
