using N_Tier.Core.Common;

namespace N_Tier.Core.Entities
{
    public class Group:BaseEntity,IAuditedEntity
    {
        public string Name { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public IList<Student> Students { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
}
