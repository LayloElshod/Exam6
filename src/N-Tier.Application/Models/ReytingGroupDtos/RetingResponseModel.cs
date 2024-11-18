

using N_Tier.Core.Common;

namespace N_Tier.Application.Models.ReytingGroupDtos
{
    public class RetingResponseModel : BaseEntity 
    { 

        public Guid GroupId { get; set; }
        public double Reyting { get; set; }
    }
}
