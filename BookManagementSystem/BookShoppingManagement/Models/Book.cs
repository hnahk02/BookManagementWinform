using System;
using System.Collections.Generic;

namespace BookShoppingManagement.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string? Author { get; set; }

    public string? Category { get; set; }

    public int? Quantity { get; set; }

    public int? Price { get; set; }
}
