using System;
using System.Collections.Generic;

namespace Child_mg.Models;

public partial class Subject
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<ScheduleInfo> ScheduleInfos { get; set; } = new List<ScheduleInfo>();
}
