// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this

namespace aspnetcore_jwt.Models
{
    public class ProductVM
    {
        public string? ProductName { get; set; }
        public double UnitPrice { get; set; }
    }

    public class Product : ProductVM
    {
        public Guid ProductId { get; set; }
    }

    public class ProductModel
    {
        public Guid ProductId { get; set; }
        public string? ProductName { get; set; }
        public double UnitPrice { get; set; }
        public string? CategoryName { get; set; }
    }
}
