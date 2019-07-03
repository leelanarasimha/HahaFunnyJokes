using System;
using HahaFunnyJokes.Domain.Entities;

namespace HahaFunnyJokes.Domain.ViewModels.Admin
{
    public class CreateCategoryViewModel
    {
        public Category category { get; set; }
        public string errormessage { get; set; } 
    }
}