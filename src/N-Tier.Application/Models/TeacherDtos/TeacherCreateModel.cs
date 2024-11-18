using N_Tier.Core.Common;
using N_Tier.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Models.TeacherDtos
{
    public class TeacherCreateModel:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public Guid DepartmentId { get; set; }
    }
    public class TeacherCreateResponseModel : BaseResponseModel { }
}
