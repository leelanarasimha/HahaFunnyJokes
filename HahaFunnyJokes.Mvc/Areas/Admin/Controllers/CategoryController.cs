using System;
using System.Threading.Tasks;
using HahaFunnyJokes.Domain;
using HahaFunnyJokes.Domain.Contracts;
using HahaFunnyJokes.Domain.Entities;
using HahaFunnyJokes.Domain.Models;
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
            var categorydetails = new CreateCategoryViewModel();
            return View(categorydetails);
        }

        
        [HttpPost]
        public async Task<IActionResult> Create(CategoryModel category)
        {

            var categoryNameExists = await _categoryRepository.getCategoryByName(category.Name);


            if (categoryNameExists != null)
            {
                var categorymodel = new CreateCategoryViewModel()
                {
                    errormessage = "Category Name Already Present. Please select another Name"

                };

                categorymodel.category = new CategoryModel() {
                     Name = categoryNameExists.Name
                }; 

                return View(categorymodel);
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            var categorydetails = new Category();

            categorydetails.Name = category.Name;
            categorydetails.Slug = SlugGenerator.makeSlug(category.Name);
            categorydetails.UserId = (new LoggedInUser()).getUserId();
            categorydetails.CreatedDate = new DateTime();


            await _categoryRepository.AddCategory(categorydetails);
            TempData["successmessage"] = "Category Added Successfully";

            return RedirectToAction("Index");

        }


        public async Task<IActionResult> Edit(int Id)
        {
            var categorydetails = await _categoryRepository.getCategoryById(Id);
            return View(categorydetails);

        }

        
        [HttpPost]
        public async Task<IActionResult> Edit(int Id, CategoryModel category)
        {
        
            var categorydetails = await _categoryRepository.getCategoryById(Id);

            if (categorydetails == null)
            {
                TempData["errormessage"] = "Invalid Category";
                return RedirectToAction("Index");
            }



            var categoryNameExists = await _categoryRepository.getCategoryByName(category.Name);

            if (categoryNameExists != null && categoryNameExists.Id != Id) {
                var createCategoryModel = new CreateCategoryViewModel()
                {
                    category = category,
                    errormessage = "Category Name Aready exists. Please try with other name"
                };

                return View(createCategoryModel);
            }


            categorydetails.Name = category.Name;
            categorydetails.Slug = SlugGenerator.makeSlug(category.Name);

            await _categoryRepository.UpdateCategory(categorydetails);


            TempData["successmessage"] = "Category Updated Successfully";
            return RedirectToAction("Index");
        }

    }
}