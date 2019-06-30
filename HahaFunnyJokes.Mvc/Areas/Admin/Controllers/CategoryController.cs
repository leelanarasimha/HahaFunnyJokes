using System;
using System.Threading.Tasks;
using HahaFunnyJokes.Domain;
using HahaFunnyJokes.Domain.Contracts;
using HahaFunnyJokes.Domain.ViewModels.Admin;
using HahaFunnyJokes.Logic;
using HahaFunnyJokes.Logic.Users;
using Microsoft.AspNetCore.Mvc;

namespace HahaFunnyJokes.Mvc.Areas.Admin.Controllers
{
    [Area("admin")]
    public class CategoryController : Controller
    {
        private ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        
        
        // GET
        public async Task<IActionResult> Index()
        {
            var CategoryViewModel = new CategoryViewModel
            {
                categories = await _categoryRepository.getAllCategories()
            };
            
            return View(CategoryViewModel);
        }


        public IActionResult Create()
        {
            var categorydetails = new Category();
            return View(categorydetails);
        }

        
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            var slugGenerator = "";
            var slugFound = new Category();
                
            do
            {
                
                slugGenerator = SlugGenerator.makeSlug(category.Name);
                slugFound = await _categoryRepository.getCategoryBySlug(slugGenerator);

            } while (slugFound != null);

            category.Slug = slugGenerator;
            category.UserId = (new LoggedInUser()).getUserId();
            category.CreatedDate = new DateTime();

            await _categoryRepository.AddCategory(category);
            TempData["successmessage"] = "Category Added Successfully";
                
            return RedirectToAction("Index");
            
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var categorydetails = await _categoryRepository.getCategoryById(Id);
            
            return View(categorydetails);
        }

        
        [HttpPost]
        public async Task<IActionResult> Edit(int Id, Category category)
        {
            var categorydetails = await _categoryRepository.getCategoryById(Id);
            
            if (categorydetails == null)
            {
                TempData["errormessage"] = "Invalid Category";
                return RedirectToAction("Index");
            }
            
            
            

            TempData["successmessage"] = "Category Updated Successfully";
            return RedirectToAction("Index");
        }

    }
}