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
        OrderManager _orderManager = new OrderManager(new EfOrderDal());
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

        [HttpPost]
        public JsonResult SaveForm(List<Parameter> parameters)
        {

            var itemList = new List<OrderItems>();
            if (parameters != null)
            {
                parameters.ForEach(p =>
                {
                    for (int i = 0; i < Convert.ToInt32(p.Adet); i++)
                    {
                        itemList.Add(new OrderItems
                        {
                            ProductId = Convert.ToInt32(p.Id),
                            ProductPrice = Convert.ToDouble(p.Price),
                            ProductDiscountPrice = Convert.ToDouble(p.DiscountPrice)
                        });
                    }

                });
                var totalPrice = parameters.Where(s => s.ProductTypeId != "3").Sum(s => Convert.ToDouble(s.Price) * Convert.ToInt32(s.Adet));

                double discountPrice = totalPrice > 100 ? parameters.Where(s => s.ProductTypeId != "3").Sum(s => Convert.ToDouble(s.DiscountPrice)) : 0;

                _orderManager.Add(new Order { CustomerAddressDesc = "", CustomerId = 1, TotalPrice = totalPrice, DiscountPrice = discountPrice }, itemList);
                //Order ve OrderItems için Id yönetimi düzgün yapılmalı...
                //Customer bilgileri alınıp servisle sorgulanıp eşlenen yoksa yeni id atılmalı...
                //productType Tablosu kontrol edilmeli...
            }
            return Json(true);
        }


    } 

    public class Parameter
    {
        public string Id { get; set; }
        public string Price { get; set; }
        public string DiscountPrice { get; set; }
        public string ProductTypeId { get; set; }
        public string Adet { get; set; }
    }

    public class RootObject
    {
        public List<Parameter> parameters { get; set; }
    }
}
