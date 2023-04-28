// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this

using aspnetcore_jwt.Models;

namespace aspnetcore_jwt.Repositories
{
    public interface ICategoryRepository
    {
        List<CategoryVM> GetAll();
        CategoryVM GetById(int id);
        CategoryVM Add(Data.Category category);
        void Update(CategoryVM category);
        void Delete(int id);
    }
}
