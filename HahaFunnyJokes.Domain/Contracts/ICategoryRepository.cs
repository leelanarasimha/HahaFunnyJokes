using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HahaFunnyJokes.Domain.Entities;

namespace HahaFunnyJokes.Domain.Contracts
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> getAllCategories();
        Task<Category> getCategoryBySlug(string slug);
        Task<Category> getCategoryById(int Id);
        Task<Category> AddCategory(Category category);
        Task<Category> getCategoryByName(string Name);
    }
}