using System.Collections.Generic;

namespace netcore3_1api_template.DTOs
{
    public class AssignRoleDto
    {
        public string Username { get; set; }
        public List<RoleDtoAdd> Roles { get; set; }
    }
}