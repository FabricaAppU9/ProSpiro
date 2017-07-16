using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProSpiro.Models;
using WebAppProSpiro.ViewModel.AdministradorViewModel;

namespace WebAppProSpiro.Mappers
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration()
        : this("MyProfile")
        {
        }
        protected AutoMapperProfileConfiguration(string profileName)
        : base(profileName)
        {
            CreateMap<AdministradorViewModel, Administrador>();
        }
    }
}
