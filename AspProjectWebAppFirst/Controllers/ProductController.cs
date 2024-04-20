using AspProjectWebAppFirst.Models;
using AspProjectWebAppFirst.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspProjectWebAppFirst.Controllers
{
    public class ProductController : Controller
    {
        

        private ProductService _productService;
        public ProductController(ProductService productService)
        {

            _productService = productService;   
        }

        public IActionResult GetAllProduct()
        {
             List<Product> _products = _productService._products;
            ViewData["products"] = _products;
            return View();
        }

        public IActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return RedirectToAction("GetAllProduct");
        }
    }
}
