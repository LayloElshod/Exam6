using AutoMapper;
using N_Tier.Application.Models.ExamDtos;
using N_Tier.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.MappingProfiles
{
    public class ExamProfile:Profile
    {
        public ExamProfile()
        {
            CreateMap<ExamCreateModel, Exam>();
            CreateMap<ExamUpdateModel, Exam>();
            CreateMap<Exam,ExamResponseModel>();
            CreateMap<ExamCreateModel, ExamCreateResponseModel>();
            CreateMap<ExamUpdateModel,ExamUpdateResponseModel>();
        }
    }
}
