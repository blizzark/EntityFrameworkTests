using System;
using System.Collections.Generic;

namespace EntityFrameworkTests;

public partial class User
{
    public long Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string SecondName { get; set; } = null!;

    public long Age { get; set; }

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
