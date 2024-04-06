﻿using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Repositories;
using EmployeeManagement.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Service.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return  await _employeeRepository.GetEmployeesAsync();
        }
        public async Task<Employee> GetByIdAsync(int Id)
        {
            return  await  _employeeRepository.GetEmployeeByIdAsync(Id);
        }
        public async Task AddEmployeeAsync(Employee employee)
        {
         await   _employeeRepository.AddEmployeeAsync(employee);
        }
        public async Task UpdateEmployeeAsync(int Id, Employee employee)
        {
          await  _employeeRepository.UpdateEmployeeAsync(Id, employee);
        }
        public async Task DeleteEmployeeAsync(int Id)
        {
           await _employeeRepository.DeleteEmployeeAsync(Id);
        }
    }
}
