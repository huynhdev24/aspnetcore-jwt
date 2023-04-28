// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this

using aspnetcore_jwt.Models;

namespace aspnetcore_jwt.Repositories
{
    public interface IProductRepository
    {
        List<ProductModel> GetAll(string search, double? from, double? to, string sortBy, int page = 1);
    }
}
