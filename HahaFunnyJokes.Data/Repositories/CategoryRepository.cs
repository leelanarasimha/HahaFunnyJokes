using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HahaFunnyJokes.Domain;
using HahaFunnyJokes.Domain.Contracts;
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
            return await _dbContext.Categories.ToListAsync();
        }

        public async Task<Category> getCategoryBySlug(string slug)
        {
            return await _dbContext.Categories.Where(c => c.Slug == slug).FirstOrDefaultAsync();
        }
    }
}