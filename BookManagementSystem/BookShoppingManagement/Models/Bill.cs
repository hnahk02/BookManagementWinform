using System;
using System.Collections.Generic;

namespace BookShoppingManagement.Models;

public partial class Bill
{
    public int BillId { get; set; }

    public int? UserId { get; set; }

    public string? Username { get; set; }

    public string? ClientName { get; set; }

    public int? Amount { get; set; }
}
