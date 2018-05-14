using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniPriceCalculator.Domain.Abstract;
using MiniPriceCalculator.Domain.Entities;
using MiniPriceCalculator.WebUI.Models;

namespace MiniPriceCalculator.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository repository;

        public CartController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToCart(int productID, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductID == productID);

            if (product != null)
            {
                GetCart().AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(int productID, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductID == productID);

            if (product != null)
            {
                GetCart().RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
        
    }
}