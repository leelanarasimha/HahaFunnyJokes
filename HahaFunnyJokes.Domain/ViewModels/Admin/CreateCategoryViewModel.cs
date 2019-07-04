using HahaFunnyJokes.Domain.Models;
using System;


namespace HahaFunnyJokes.Domain.ViewModels.Admin
{
    public class CreateCategoryViewModel
    {
        public CategoryModel category { get; set; }
        public string errormessage { get; set; } 
    }
}