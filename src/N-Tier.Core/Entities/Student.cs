

using N_Tier.Core.Common;

namespace N_Tier.Core.Entities
{
    public class Student:BaseEntity,IAuditedEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid GroupId { get; set; }
        public Group Group { get; set; }
        public virtual IList<MarkStudent> MarkStudents { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
