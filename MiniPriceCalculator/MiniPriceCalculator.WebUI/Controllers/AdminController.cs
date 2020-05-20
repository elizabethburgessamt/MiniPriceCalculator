using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniPriceCalculator.Domain.Abstract;
using MiniPriceCalculator.Domain.Entities;

namespace MiniPriceCalculator.Controllers
{
    public class AdminController : Controller
    {
        private IProductRepository repository;

        public AdminController(IProductRepository repos)
        {
            repository = repos;
        }

        public ViewResult Index()
        {
            return View(repository.Products);
        }

        public ViewResult Edit(int productID)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductID == productID);

            return View(product);
        }
    }
}