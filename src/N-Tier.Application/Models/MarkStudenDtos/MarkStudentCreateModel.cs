using N_Tier.Core.Common;
using N_Tier.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Models.MarkStudenDtos
{
    public class MarkStudentCreateModel:BaseEntity
    {
        public Guid StudentId { get; set; }
        public Guid MarkId { get; set; }
        public DateTime DateTime { get; set; }
    }
    public class MarkStudentCreateResponseModel:BaseResponseModel
    {
    }
}
