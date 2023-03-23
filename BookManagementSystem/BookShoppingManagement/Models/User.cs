using System;
using System.Collections.Generic;

namespace BookShoppingManagement.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? Password { get; set; }
}
