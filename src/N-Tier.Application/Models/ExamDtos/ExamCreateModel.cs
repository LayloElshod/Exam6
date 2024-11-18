﻿using N_Tier.Core.Common;
using N_Tier.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Models.ExamDtos
{
    public class ExamCreateModel:BaseEntity
    {
        public Guid GroupId { get; set; }
        public DateTime DateTime { get; set; }
        public Guid RoomId { get; set; }
    }
    public class ExamCreateResponseModel : BaseResponseModel { }
}