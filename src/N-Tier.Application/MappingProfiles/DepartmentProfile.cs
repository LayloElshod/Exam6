using AutoMapper;
using N_Tier.Application.Models.DepartmentDtos;
using N_Tier.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.MappingProfiles
{
    public class DepartmentProfile:Profile
    {
        public DepartmentProfile()
        {
            CreateMap<DepartmentCreateModel, Department>();
            CreateMap<DepartmentCreateModel, DepartmentCreateReponseModel>();
            CreateMap<DepartmentUpdateModel, Department>();
            CreateMap<DepartmentUpdateModel, DepartmentUpdateResponseModel>();
            CreateMap<Department,DepartmentResponseModel>();
        }
    }
}
