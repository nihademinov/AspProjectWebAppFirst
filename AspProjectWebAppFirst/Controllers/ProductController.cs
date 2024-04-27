using AspProjectWebAppFirst.Models;
using AspProjectWebAppFirst.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace AspProjectWebAppFirst.Controllers
{
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        

        private ProductService _productService;
        public ProductController(ProductService productService, IWebHostEnvironment webHostEnvironment)
        {

            _productService = productService;   
            _webHostEnvironment = webHostEnvironment;
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
        



        //[HttpPost]
        public IActionResult Create(Product product,IFormFile image) 
        {


            if (ModelState.IsValid)
            {
                if (image != null && image.Length > 0)
                {
                    //var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);

                    //var uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "wwwroot","images");

                    //if (!Directory.Exists(uploadDir))
                    //{
                    //    Directory.CreateDirectory(uploadDir);
                    //}

                    //var filePath = Path.Combine(uploadDir, fileName);

                    //using (var stream = new FileStream(filePath, FileMode.Create))
                    //{
                    //    image.CopyTo(stream);
                    //}

                    //product.ImgUrl = filePath;

                    _productService.CreateProduct(product);


                    return RedirectToAction("Create");
                }


            }
            return View();
            
        }

        public IActionResult GetProductById(int id) 
        {
            Product? tempProductById = _productService.GetProductById(id);   

            if(tempProductById == null) 
                return RedirectToAction("NotFound404");
            ViewData["productsById"] = tempProductById;
            return View();
        }


        public IActionResult GetProductByPrice(string id)
        {
            List<Product>? tempProductByPrice = _productService.GetProductByPrice(id);

            if (tempProductByPrice == null)
                return RedirectToAction("NotFound404");
            ViewData["productsByPrice"] = tempProductByPrice;
            return View();
        }

    }
}
