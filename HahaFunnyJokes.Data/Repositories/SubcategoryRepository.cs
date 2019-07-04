using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HahaFunnyJokes.Domain.Contracts;
using HahaFunnyJokes.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HahaFunnyJokes.Data.Repositories
{
    public class SubcategoryRepository : ISubcategoryRespository
    {
        private HahaFunnyJokesDbContext _dbContext;

        public SubcategoryRepository(HahaFunnyJokesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<IEnumerable<Subcategory>> getAll()
        {
            return await _dbContext.Subcategories.ToListAsync();
        }
    }
}