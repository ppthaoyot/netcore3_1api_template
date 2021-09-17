using AutoMapper;
using netcore3_1api_template.DTOs;
using netcore3_1api_template.Models;
using netcore3_1api_template.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcore3_1api_template
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<Role, RoleDto>()
                .ForMember(x => x.RoleName, x => x.MapFrom(x => x.Name));
            CreateMap<RoleDtoAdd, Role>()
                .ForMember(x => x.Name, x => x.MapFrom(x => x.RoleName)); ;
            CreateMap<UserRole, UserRoleDto>();
        }
    }
}