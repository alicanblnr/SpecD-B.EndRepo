using Dominos.BLL.Concrete;
using Dominos.Dal.Concrete.EntityFramework;
using Dominos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dominos.WebUI.Controllers
{
    public class ProductController : Controller
    {
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        ProductManager _productManager = new ProductManager(new EfProductDal());
        [HttpGet]
        public ViewResult Index()
        {
            var products = _productManager.GetAll();
            return View(products);
        }

        public ActionResult ProductUpdate(int id)
        {
            var product = _productManager.Get(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult ProductUpdate(int id, Product myProduct)
        {
            _productManager.Update(myProduct);
            return View();
        }

        public ActionResult SaveForm()
        {

            return RedirectToAction("Index");
        }
    }
}