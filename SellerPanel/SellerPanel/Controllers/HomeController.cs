using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SellerPanel.Models;
namespace SellerPanel.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        DAC _dac = new DAC();
        public ActionResult Index()
        {
            List<product> products = _dac.getproducts();
            return View(products);
        }



    }
}
