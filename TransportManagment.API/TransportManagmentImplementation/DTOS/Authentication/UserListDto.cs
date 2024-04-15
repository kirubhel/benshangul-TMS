﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.DTOS.Authentication
{
    public class UserListDto
    {
        public string Id { get; set; } = null!;
        public Guid EmployeeId { get; set; }
        public string Name { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string ImagePath { get; set; } = null!;

        public string Department { get; set; } = null!;
        public string Position { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public List<string> Roles { get; set; } = null!;
    }

    public class RoleDropDown
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
    }



    public class AddUSerDto
    {
        public Guid EmployeeId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }

    public class UserRoleDto
    {
        public string UserId { get; set; } = null!;
        public List<string> RoleName { get; set; } = null!;
    }


}
