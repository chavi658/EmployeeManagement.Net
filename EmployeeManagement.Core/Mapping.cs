using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core
{
    public  class Mapping
    {
        public  EmployeeDto MapToEmployeeDto(Employee employee)
        {
            return  new EmployeeDto() { DateOfStartingWork = employee.DateOfStartingWork, EmployeeId = employee.EmployeeId, FirstName = employee.FirstName, LastName = employee.LastName };
        }
    }
}
