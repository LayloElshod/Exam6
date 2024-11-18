using N_Tier.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Models.StudentDtos
{
    public class StudentUpdateModel:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid GroupId { get; set; }
    }
    public class StudentUpdateResponseModel : BaseResponseModel { }
}
