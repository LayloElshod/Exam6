using N_Tier.Core.Common;

namespace N_Tier.Core.Entities
{
    public class MarkStudent:BaseEntity,IAuditedEntity
    {
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid MarkId { get; set; }
        public Mark Mark { get; set; }
        public DateTime DateTime { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
