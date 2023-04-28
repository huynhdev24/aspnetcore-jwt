// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this

using aspnetcore_jwt.Data;
using aspnetcore_jwt.Models;
using aspnetcore_jwt.Repositories;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore_jwt.Services
{
    public class ProductRepository: IProductRepository
    {
        private readonly MyDbContext _context;
        public static int PAGE_SIZE { get; set; } = 5;

        public ProductRepository(MyDbContext context)
        {
            _context = context;
        }

        public List<ProductModel> GetAll(string search, double? from, double? to, string sortBy, int page = 1)
        {
            var allProducts = _context.Products.Include(hh => hh.Category).AsQueryable();

            #region Filtering
            if (!string.IsNullOrEmpty(search))
            {
                allProducts = allProducts.Where(hh => hh.ProductName.Contains(search));
            }
            if (from.HasValue)
            {
                allProducts = allProducts.Where(hh => hh.UnitPrice >= from);
            }
            if (to.HasValue)
            {
                allProducts = allProducts.Where(hh => hh.UnitPrice <= to);
            }
            #endregion


            #region Sorting
            //Default sort by Name (TenHh)
            allProducts = allProducts.OrderBy(hh => hh.ProductName);

            if (!string.IsNullOrEmpty(sortBy))
            {
                switch (sortBy)
                {
                    case "tenhh_desc": allProducts = allProducts.OrderByDescending(hh => hh.ProductName); break;
                    case "gia_asc": allProducts = allProducts.OrderBy(hh => hh.UnitPrice); break;
                    case "gia_desc": allProducts = allProducts.OrderByDescending(hh => hh.UnitPrice); break;
                }
            }
            #endregion

            var result = PaginatedList<aspnetcore_jwt.Data.Product>.Create(allProducts, page, PAGE_SIZE);

            return result.Select(hh => new ProductModel
            {
                ProductId = hh.ProductId,
                ProductName = hh.ProductName,
                UnitPrice = hh.UnitPrice,
                CategoryName = hh.Category?.CategoryName
            }).ToList();
        }
    }
}
