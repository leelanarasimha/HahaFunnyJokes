using System;
using HahaFunnyJokes.Domain.Contracts;
using HahaFunnyJokes.Domain.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;

namespace HahaFunnyJokes.Mvc.Controllers.Admin
{
    public class CategoryController : Controller
    {
        private ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        
        
        [Route("admin/category")]
        public IActionResult Index()
        {
            var CategoryViewModel = new CategoryViewModel
            {
                categories = _categoryRepository.getAllCategories()
            };
            Console.WriteLine(CategoryViewModel.categories);

            return View();
        }
    }
}