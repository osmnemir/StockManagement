using Microsoft.AspNetCore.Mvc;
using Services;

namespace StockWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(DateTime startDate, DateTime endDate, string searchTerm)
        {
            var products = _productService.GetProductsByFilter(startDate, endDate, searchTerm);
            return View(products);
        }
    }
}
