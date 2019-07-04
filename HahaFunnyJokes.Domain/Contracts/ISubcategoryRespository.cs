using System.Collections.Generic;
using System.Threading.Tasks;
using HahaFunnyJokes.Domain.Entities;

namespace HahaFunnyJokes.Domain.Contracts
{
    public interface ISubcategoryRespository
    {
        Task<IEnumerable<Subcategory>> getAll();
        
    }
}