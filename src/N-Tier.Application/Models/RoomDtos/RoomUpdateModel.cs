﻿using N_Tier.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Models.RoomDtos
{
    public class RoomUpdateModel:BaseEntity
    {
        public string Name { get; set; }
    }
    public class RoomUpdateResponseModel : BaseResponseModel { }
}
