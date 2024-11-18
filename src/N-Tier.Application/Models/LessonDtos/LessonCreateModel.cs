using N_Tier.Core.Common;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Models.LessonDtos
{
    public class LessonCreateModel : BaseEntity
    {
        public Guid TeacherId { get; set; }
        public Guid GroupId { get; set; }
        public DateTime Time { get; set; }
        public Guid RoomId { get; set; }
    }
    public class LessonCreateResponseModel : BaseResponseModel { }
}
