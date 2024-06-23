using System;
using System.Collections.Generic;

namespace Child_mg.Models;

public partial class ScheduleInfo
{
    public int Id { get; set; }

    public int? IdSchedule { get; set; }

    public string? Name { get; set; }

    public int? IdSubject { get; set; }

    public int? Status { get; set; }

    public virtual Schedule? IdScheduleNavigation { get; set; }

    public virtual Subject? IdSubjectNavigation { get; set; }
}
