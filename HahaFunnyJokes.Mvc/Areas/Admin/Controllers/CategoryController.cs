using System.Threading.Tasks;
using HahaFunnyJokes.Domain;
using HahaFunnyJokes.Domain.Contracts;
using HahaFunnyJokes.Domain.ViewModels.Admin;
using HahaFunnyJokes.Logic;
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


        public async Task<IActionResult> Create()
        {
            var categorydetails = new Category();
            return View(categorydetails);
        }

        
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                var slugGenerator = "";
                var found = 0;
                do
                {
                    slugGenerator = SlugGenerator.makeSlug(category.Name);
                    await 
                    
                } while ();



                return RedirectToAction("Index");    
            }

            return View();

        }




    }
}