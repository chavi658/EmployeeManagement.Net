﻿using EmployeeManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.NewFolder
{
    public class EmployeeDto
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateOfStartingWork { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        ///תפקידים ליסט
        //public List<Role> RoleList { get; set; }
    }
}