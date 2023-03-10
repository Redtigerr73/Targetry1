using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Targetry.Application.Common.Mappings;
using Targetry.Domain.Entities;

namespace Targetry.Application.Users.Models
{
    public class CreateUserDto : IMapFrom<User>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Matricule { get; set; }
        public int RoleId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateUserDto, User>();
        }
    }
}
