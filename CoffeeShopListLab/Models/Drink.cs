using System;
using System.Collections.Generic;

namespace CoffeeShopListLab.Models;

public partial class Drink
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }

    public double? Price { get; set; }
}
