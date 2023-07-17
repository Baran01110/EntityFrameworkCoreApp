using EfCore.Data.Entities;
using EfCore.Data.Entities.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            UdemyContext context = new UdemyContext();

            /*   var entityEntry =  context.Products.Add(new Data.Entities.Product
                 {
                     Name = "Telefon",
                     Price = 3400
                 });*/
            /* var updateProduct =  context.Products.Find(1);
            updateProduct.Price = 400;
            context.Products.Update(updateProduct);
            */
            //  var deletedProduct = context.Products.FirstOrDefault(x => x.Id == 1);
            // context.Products.Remove(deletedProduct);

            Product product = new() { Price = 4000 };
            context.Products.Add(product);
            context.SaveChanges();

            context.SaveChanges();

            return View();
        }
    }
}
