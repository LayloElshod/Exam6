using N_Tier.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Models.ReytingGroupDtos
{
    public class RetingGroupUpdateModel:BaseEntity
    {
        public Guid GroupId { get; set; }
        public double Reyting { get; set; }
    }

    public class RetingGroupUpdateResponseModel : BaseResponseModel { }
}
