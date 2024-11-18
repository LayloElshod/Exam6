using N_Tier.Core.Common;

namespace N_Tier.Application.Models.TeacherDtos
{
    public class TeacherResponseModel:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
