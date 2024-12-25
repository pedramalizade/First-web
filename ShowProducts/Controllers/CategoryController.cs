using Microsoft.AspNetCore.Mvc;
using ShowProducts.Models;
using ShowProducts.Models.Db;
using ShowProducts.Models.Interface.Service;
using ShowProducts.Models.Service;

namespace ShowProducts.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service = new CategoryService();
        private readonly ProductDbContext _dbContext;
        public CategoryController()
        {
            _dbContext = new ProductDbContext();
        }

        public IActionResult Index()
        {
            var categories = _service.GetAllCategories();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _service.AddCategory(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteCategory(int id)
        {
            _service.DeleteCategory(id);
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                _service.UpdateCategory(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }
    }
}
