using System.Collections.Generic;
using HahaFunnyJokes.Domain.Entities;

namespace HahaFunnyJokes.Domain.ViewModels.Admin
{
    public class CategoryViewModel
    {
        
        public IEnumerable<Category> categories { get; set; }
    }
}