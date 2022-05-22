using AutoMapper;
using RePrjClinicAppoint.Models.Entity;
using RePrjClinicAppoint.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RePrjClinicAppoint.Profiles
{
    public class adminProfile : Profile
    {
        public adminProfile()
        {
            CreateMap<RegViewModel, Doctor>();
        }
    }
}
