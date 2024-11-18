﻿using N_Tier.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Models.GroupDtos
{
    public class GroupCreateModel:BaseEntity
    {
        public string Name { get; set; }
        public Guid TeacherId { get; set; }
    }
    public class GroupCreateResponseModel : BaseResponseModel { }
}
