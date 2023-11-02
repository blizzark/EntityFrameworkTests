using System;
using System.Collections.Generic;

namespace EntityFrameworkTests;

public partial class Material
{
    public long Id { get; set; }

    public string NameMaterial { get; set; } = null!;

    public long UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
