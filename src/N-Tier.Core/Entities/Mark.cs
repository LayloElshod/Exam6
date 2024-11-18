using N_Tier.Core.Common;

namespace N_Tier.Core.Entities
{
    public class Mark:BaseEntity,IAuditedEntity
    {
        public byte Score { get; set; }
        public IList<MarkStudent> MarkStudents { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
