using System.Linq;
using System.Threading.Tasks;
using HahaFunnyJokes.Domain.Contracts;
using HahaFunnyJokes.Domain.ViewModels.Admin.Subcategory;
using Microsoft.AspNetCore.Mvc;

namespace HahaFunnyJokes.Mvc.Areas.Admin.Controllers
{
    [Area("admin")]
    public class SubcategoryController : Controller
    {
        private ISubcategoryRespository _subcategoryRepository;

        public SubcategoryController(ISubcategoryRespository subcategoryRespository)
        {
            _subcategoryRepository = subcategoryRespository;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var subcategories = await _subcategoryRepository.getAll();
            var subcategoryviewmodel = new SubcategoryViewModel()
            {
                Subcategories = subcategories.ToList()
            };
            return View(subcategoryviewmodel);
        }


        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}