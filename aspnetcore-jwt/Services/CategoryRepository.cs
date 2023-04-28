// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this

using aspnetcore_jwt.Data;
using aspnetcore_jwt.Models;
using aspnetcore_jwt.Repositories;

namespace aspnetcore_jwt.Services
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly MyDbContext _context;

        public CategoryRepository(MyDbContext context)
        {
            _context = context;
        }

        public CategoryVM Add(Data.Category category)
        {
            var _cat = new Data.Category
            {
                CategoryName = category.CategoryName
            };
            _context.Add(_cat);
            _context.SaveChanges();

            return new CategoryVM
            {
                CategoryId = _cat.CategoryId,
                CategoryName = _cat.CategoryName
            };
        }

        public void Delete(int id)
        {
            var category = _context.Categories.SingleOrDefault(cat => cat.CategoryId == id);
            if (category != null)
            {
                _context.Remove(category);
                _context.SaveChanges();
            }
        }

        public List<CategoryVM> GetAll()
        {
            var categories = _context.Categories.Select(cat => new CategoryVM
            {
                CategoryId = cat.CategoryId,
                CategoryName = cat.CategoryName
            });
            return categories.ToList();
        }

        public CategoryVM GetById(int id)
        {
            var category = _context.Categories.SingleOrDefault(cat => cat.CategoryId == id);
            if (category != null)
            {
                return new CategoryVM
                {
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName
                };
            }
            return null;
        }

        public void Update(CategoryVM category)
        {
            var _loai = _context.Categories.SingleOrDefault(cat => cat.CategoryId == category.CategoryId);
            category.CategoryName = category.CategoryName;
            _context.SaveChanges();
        }
    }
}
