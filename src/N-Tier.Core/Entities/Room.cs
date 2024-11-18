﻿using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Room:BaseEntity,IAuditedEntity
{
    public string Name { get; set; }
    public virtual IList<Lesson> Lessons { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime UpdatedOn { get; set; }

}
