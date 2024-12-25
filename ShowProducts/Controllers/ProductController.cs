using Microsoft.AspNetCore.Mvc;
using ShowProducts.Models;
using ShowProducts.Models.Db;
using ShowProducts.Models.Interface.Service;
using ShowProducts.Models.Service;

namespace ShowProducts.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service = new ProdctService();
        private readonly ProductDbContext _dbContext;
        public ProductController()
        {
            _dbContext = new ProductDbContext();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var proscts = _service.GetAllProdct();
            return View(proscts);
        }
        //[HttpGet]
        //public IActionResult Create(Product product)
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult CreateProduct(string name, int price, int quantity)
        //{
        //    _dbContext.Products.Add(new Product()
        //    {
        //        Id = _dbContext.Products.Last(x => true).Id+1,
        //        Name = name,
        //        price= price,
        //        Qantity=quantity
        //    });
        //    return RedirectToAction("Index");   
        //}
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(Product product)
        {
            if (ModelState.IsValid)
            {
                _service.AddProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public IActionResult Delete(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(x => x.Id == id);
            _dbContext.Products.Remove(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }
        [HttpPost]
        public IActionResult UpdateProduct(int id, string name, int price, int quantity)
        {
            var product = _dbContext.Products.FirstOrDefault(x => x.Id == id);
            product.Name = name;
            product.price = price;
            product.Qantity = quantity;
            return RedirectToAction("Index");
        }
    }
}
