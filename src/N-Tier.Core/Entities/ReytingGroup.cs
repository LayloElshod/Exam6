using N_Tier.Core.Common;

namespace N_Tier.Core.Entities
{
    public class ReytingGroup:BaseEntity,IAuditedEntity
    {
        public Guid GroupId { get; set; }
        public Group Group { get; set; }
        public double Reyting { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
