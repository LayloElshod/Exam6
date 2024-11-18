using N_Tier.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Models.StudentDtos
{
    public class CreateStudentModel:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid GroupId { get; set; }
    }
    public class CreateStudentResponseModel : BaseResponseModel { }
}
