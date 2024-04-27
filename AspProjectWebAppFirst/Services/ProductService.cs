using AspProjectWebAppFirst.Models;

namespace AspProjectWebAppFirst.Services;

public class ProductService
{
    public  List<Product> _products; 

    public ProductService()
    {
        _products = new()
            {
                new Product() {Name = "Coca-Cola",Description = "1l, Istifade muddeti: 05.06.2025",Price = "1.40 Azn",ImgUrl = "https://strgimgr.umico.az/sized/840/543173-0c6e710e9596f08741be3ea13e828dee.jpg", Id=1},
                new Product() {Name = "Annenfeld",Description = "0.5l, Istifade muddeti: 08.03.2025",Price = "2.00 Azn",ImgUrl = "https://strgimgr.umico.az/sized/840/542780-e800df33de1df168017489cfcdb734dd.jpg", Id=2},

                new Product() {Name = "Sirab",Description = "1.5l, Istifade muddeti: 01.17.2024",Price = "1.00 Azn",ImgUrl = "https://strgimgr.umico.az/sized/840/539974-03e9598bf03f82c992f59a19ed27d5a5.jpg", Id=3},
                new Product() {Name = "Fanta",Description = "2l, Istifade muddeti: 05.14.2025",Price = "2.00 Azn",ImgUrl = "https://strgimgr.umico.az/sized/840/542780-e800df33de1df168017489cfcdb734dd.jpg", Id=4},
                new Product() {Name = "Finlandiya",Description = "1l, Istifade muddeti: 02.22.2026",Price = "53.99 Azn",ImgUrl = "https://strgimgr.umico.az/sized/840/542780-e800df33de1df168017489cfcdb734dd.jpg", Id=5},
                new Product() {Name = "Nemiroff",Description = "0.5l, Istifade muddeti: 07.20.2024",Price = "18.79 Azn",ImgUrl = "https://strgimgr.umico.az/sized/840/542780-e800df33de1df168017489cfcdb734dd.jpg", Id=6},
                new Product() {Name = "Reyka",Description = "1l, Istifade muddeti: 10.03.2026",Price = "90.99 Azn",ImgUrl = "https://strgimgr.umico.az/sized/840/542780-e800df33de1df168017489cfcdb734dd.jpg", Id=7},
                new Product() {Name = "Chivas Regal",Description = "0.7l, Istifade muddeti: 12.25.2024",Price = "2.00 Azn",ImgUrl = "https://strgimgr.umico.az/sized/840/542780-e800df33de1df168017489cfcdb734dd.jpg", Id=8},
                new Product() {Name = "Fortuna",Description = "0.7l, Istifade muddeti: 07.01.2027",Price = "2.00 Azn",ImgUrl = "https://strgimgr.umico.az/sized/840/542780-e800df33de1df168017489cfcdb734dd.jpg", Id=9},
                new Product() {Name = "Absolut",Description = "0.7l, Istifade muddeti: 09.09.2027",Price = "2.00 Azn",ImgUrl = "https://strgimgr.umico.az/sized/840/542780-e800df33de1df168017489cfcdb734dd.jpg", Id=10},
                new Product() {Name = "Ciroc",Description = "0.7l, Istifade muddeti: 08.13.2025",Price = "2.00 Azn",ImgUrl = "https://strgimgr.umico.az/sized/840/542780-e800df33de1df168017489cfcdb734dd.jpg", Id=11},


            };
    }

    public void DeleteProduct(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            _products.Remove(product);
        }
    }

    public void CreateProduct(Product product)
    {
        _products.Add(product); 
    }

    public Product? GetProductById(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            return product;
        }

        return null;
    }

    public List<Product>? GetProductByPrice(string price)
    {

        List<Product>? products = new List<Product>();
        var checkPice = price + " Azn";

        foreach (var item in _products)
        {
            if(item.Price == checkPice)
            {
                products?.Add(item);
            }
        }
        if (products != null)
        {
            return products;
        }
        return null;
    }
}
