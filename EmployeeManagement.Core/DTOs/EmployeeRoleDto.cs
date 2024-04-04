using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.DTOs
{
    public class EmployeeRoleDto
    {
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public DateTime DateOfRoleEntry { get; set; }
    }
}
