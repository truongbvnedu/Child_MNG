using System;
using System.Collections.Generic;

namespace Child_mg.Models;

public partial class Child
{
    public int Id { get; set; }

    public int? IdUsers { get; set; }

    public string? Name { get; set; }

    public DateOnly? Date { get; set; }

    public int? IdClass { get; set; }

    public int? Status { get; set; }

    public string? Gender { get; set; }
    public string? Image { get; set; }
    public string? Comment { get; set; }

    public virtual Class? IdClassNavigation { get; set; }

    public virtual User? IdUsersNavigation { get; set; }
}
