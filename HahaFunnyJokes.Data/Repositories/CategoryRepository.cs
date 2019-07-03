using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HahaFunnyJokes.Domain;
using HahaFunnyJokes.Domain.Contracts;
using HahaFunnyJokes.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HahaFunnyJokes.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private HahaFunnyJokesDbContext _dbContext;

        public CategoryRepository(HahaFunnyJokesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Category>> getAllCategories()
        {
            return await _dbContext.Categories.Include(c => c.User).ToListAsync();
        }

        public async Task<Category> getCategoryBySlug(string slug)
        {
            return await _dbContext.Categories.Where(c => c.Slug == slug).FirstOrDefaultAsync();
        }

        public async Task<Category> AddCategory(Category category)
        {
            await _dbContext.AddAsync(category);
            await _dbContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> getCategoryByName(string Name)
        {
            return await _dbContext.Categories.Where(c => c.Name == Name).FirstOrDefaultAsync();
        }

        public async Task<Category> getCategoryById(int Id)
        {
            return await _dbContext.Categories.Where(c => c.Id == Id).FirstOrDefaultAsync();
        }
    }
}