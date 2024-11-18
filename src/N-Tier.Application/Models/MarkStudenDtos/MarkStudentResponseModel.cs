using N_Tier.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Models.MarkStudenDtos
{
    public class MarkStudentResponseModel:BaseEntity
    {
        public Guid StudentId { get; set; }
        public Guid MarkId { get; set; }
        public DateTime DateTime { get; set; }
    }
}
