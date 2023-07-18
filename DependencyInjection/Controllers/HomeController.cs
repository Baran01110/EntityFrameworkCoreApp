using DependencyInjection.Services;
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
        private readonly ISingletonService _singletonService;
        private readonly ITransientService _transientService;
        private readonly IScopedService _scopedService;


        public HomeController(IProductService productService, ICustomerService customerService, ISingletonService singletonService, ITransientService transientService, IScopedService scopedService)
        {
            _customerService = customerService;
            _productService = productService;
            _singletonService = singletonService;
            _transientService = transientService;
            _scopedService = scopedService;
        }
        public IActionResult Index()
        {
            var total = _productService.GetTotal();
            var total2 = _customerService.GetTotal();


            ViewBag.Transient = _transientService.GuidId;
            ViewBag.Scoped = _scopedService.GuidId;
            ViewBag.Singleton = _singletonService.GuidId;

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
