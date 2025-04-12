using System;
using System.Collections.Generic;

namespace SoftWare_Engineering.Models;

public partial class User
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? FullName { get; set; }

    public string? University { get; set; }

    public string? Password { get; set; }

    public string? Major { get; set; }

    public string? Role { get; set; }
}
