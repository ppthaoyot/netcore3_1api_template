﻿using netcore3_1api_template.DTOs;
using netcore3_1api_template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcore3_1api_template.Services
{
    public interface IAuthService
    {
        Task<ServiceResponse<string>> Register(UserRegisterDto userRegisterDto);

        Task<ServiceResponse<string>> Login(UserLoginDto userLoginDto);

        Task<bool> UserExists(string username);

        Task<ServiceResponse<List<RoleDto>>> GetRoles();

        Task<ServiceResponse<RoleDto>> AddRole(RoleDtoAdd newRole);

        Task<ServiceResponse<RoleDto>> UpdateRole(string guid, RoleDtoAdd newRole);

        Task<ServiceResponse<RoleDto>> DeleteRole(string guid);

        Task<ServiceResponse<List<UserDto>>> GetUsers();

        Task<ServiceResponse<UserDto>> GetUserById(string guid);

        Task<ServiceResponse<List<UserRoleDto>>> AssignRole(AssignRoleDto assignRoleDto);

        Task<ServiceResponse<string>> Renew();

        IEnumerable<string> GetUserRoles();
    }
}