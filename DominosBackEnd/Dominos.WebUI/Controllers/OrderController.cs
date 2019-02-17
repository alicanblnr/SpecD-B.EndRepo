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
    public class OrderController : Controller
    {
        OrderManager _orderManager = new OrderManager(new EfOrderDal());
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Order myOrder,List<OrderItems> orderItems)
        {
            _orderManager.Add(myOrder, orderItems);
            return View();
        }
    }
}