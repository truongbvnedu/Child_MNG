using System;
using System.Collections.Generic;

namespace Child_mg.Models;

public partial class Schedule
{
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public int? IdClass { get; set; }

    public int? Status { get; set; }

    public virtual Class? IdClassNavigation { get; set; }

    public virtual ICollection<ScheduleInfo> ScheduleInfos { get; set; } = new List<ScheduleInfo>();
}
