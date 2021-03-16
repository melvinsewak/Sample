﻿using System.Collections.Generic;
using Sample.Roles.Dto;
using Sample.Users.Dto;

namespace Sample.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}