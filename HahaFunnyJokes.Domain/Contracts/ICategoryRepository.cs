using System;
using System.Collections.Generic;

namespace HahaFunnyJokes.Domain.Contracts
{
    public interface ICategoryRepository
    {
        List<Category> getAllCategories();
    }
}