using N_Tier.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Models.LessonDtos
{
    public class LessonResponseModel:BaseEntity
    {
        public Guid TeacherId { get; set; }
        public Guid GroupId { get; set; }
        public DateTime Time { get; set; }
        public Guid RoomId { get; set; }
    }
}
