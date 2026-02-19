using System;
using System.Collections.Generic;

namespace NorthwindRestApi.Models;

public partial class Login
{
    public int LoginId { get; set; }

    public string UserName { get; set; } = null!;

    public string PassWord { get; set; } = null!;

    public string? LoginErrorMessage { get; set; }

    public bool Maintenance { get; set; }

    public DateOnly? RegisterationDate { get; set; }

    public string? Salt { get; set; }
}
