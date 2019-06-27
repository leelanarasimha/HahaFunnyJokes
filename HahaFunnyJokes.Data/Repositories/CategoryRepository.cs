using System.Collections.Generic;
using System.Linq;
using HahaFunnyJokes.Domain;
using HahaFunnyJokes.Domain.Contracts;

namespace HahaFunnyJokes.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private HahaFunnyJokesDbContext _dbContext;

        public CategoryRepository(HahaFunnyJokesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Category> getAllCategories()
        {
            return _dbContext.Categories.ToList();
        }
    }
}