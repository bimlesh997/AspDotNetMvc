using System.Collections.Generic;
using test2.Roles.Dto;
using test2.Users.Dto;

namespace test2.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}