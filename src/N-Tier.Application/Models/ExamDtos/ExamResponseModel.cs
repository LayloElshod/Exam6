using N_Tier.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Models.ExamDtos
{
    public class ExamResponseModel:BaseEntity
    {
        public Guid GroupId { get; set; }
        public DateTime DateTime { get; set; }
        public Guid RoomId { get; set; }
    }
}
