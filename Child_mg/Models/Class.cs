using System;
using System.Collections.Generic;

namespace Child_mg.Models;

public partial class Class
{
    public int Id { get; set; }

    public int? IdUser { get; set; }

    public string? Name { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<Child> Children { get; set; } = new List<Child>();

    public virtual User? IdUserNavigation { get; set; }

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}
