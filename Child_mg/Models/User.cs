using System;
using System.Collections.Generic;

namespace Child_mg.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Account { get; set; }

    public string? Password { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public int? Role { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public int? Status { get; set; }

    public string? IdentityId { get; set; }

    public string? Gender { get; set; }
    public string? Image {  get; set; }

    public virtual ICollection<Child> Children { get; set; } = new List<Child>();

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
