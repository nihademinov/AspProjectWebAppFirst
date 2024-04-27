namespace AspProjectWebAppFirst.Models;
using System.Web;
using System;

public class Product
{

    public Product()
    {
       
    }

    public Product( string? name, string? description, string? price, string? imgUrl)
    {
        Id++;
        Name = name;
        Description = description;
        Price = price;
        ImgUrl = imgUrl;
    }

    public  int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Price { get; set;}
    public string? ImgUrl {  get; set; }

    //public  Image ImageFile { get; set; }

   



}
