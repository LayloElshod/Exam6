using N_Tier.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Models.MarkDtos
{
    public class MarkCreateModel:BaseEntity
    {
        public byte Score { get; set; }
    }
    public class MarkCreateResponseModel : BaseResponseModel { }
}
