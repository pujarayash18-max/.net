using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Practical_6.Models;

namespace Practical_6.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> products = new List<Product>()
        {
            new Product
            {
                ProductId = 1,
                ProductName = "Laptop",
                Category = "Electronics",
                Description = "Laptop for study and programming.",
                Price = 65000,
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWXmgPWswO0QWjGSd4i5-sxWA2aKEngInJ_rrooKfDLg&s=10",
                Quantity = 10
            },
            new Product
            {
                ProductId = 2,
                ProductName = "Smartphone",
                Category = "Electronics",
                Description = "Smartphone for everyday use.",
                Price = 25000,
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ0ebsmflj_g-ZHGeXxNPN8hhX-G1iRNN-eFVjU2BsF1A&s=10",
                Quantity = 15
            },
            new Product
            {
                ProductId = 3,
                ProductName = "Headphones",
                Category = "Accessories",
                Description = "Headphones for music and calls.",
                Price = 3300,
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRomLn4JUJXn3PD9OkWia6Mo8YCYH1r2LEhSVPESk6xIA&s=10",
                Quantity = 20
            }
        };

        public ActionResult Index()
        {
            return View(products);
        }

        public ActionResult Details(int id)
        {
            Product product = products.FirstOrDefault(
                p => p.ProductId == id
            );

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
    }
}