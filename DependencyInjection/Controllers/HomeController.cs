using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
       private readonly IProductService _productService;
       private readonly ICustomerService _customerService;
        public HomeController(IProductService productService,ICustomerService customerService)
        {
            _customerService = customerService;
            _productService = productService;
        }
        public IActionResult Index()
        {
            var total = _productService.GetTotal();
            var total2 = _customerService.GetTotal();
            return View();
        }
    }
    public interface IProductService
    {
        string GetTotal();
    }
    public interface ICustomerService
    {
        string GetTotal();
    }
    public class ProductManger : IProductService
    {
        public string GetTotal()
       {
           return "Product Merhaba";
        }
    }
    public class CustomerManager : ICustomerService
    {
        public string GetTotal()
        {
            return "Customer Merhaba";
        }
    }
}
