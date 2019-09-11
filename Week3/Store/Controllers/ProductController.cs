using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
// 
        // GET: /HelloWorld/ 
 
        public ActionResult Index() 
        { 
            return View(); 
        } 
 
        // 
        // GET: /HelloWorld/Welcome/ 
 
        public ActionResult Welcome() 
        { 
            return View(); 
        } 
        public ActionResult Browse()
        {
            return View();

        }
        public ActionResult Details(int id)
        {
           ViewBag.Message = "Store.Details, ID =" + id;
            return View();

        }
        public ActionResult Location(int zip)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Store.Details, zip =" + zip);
            return View();

        }


    }
}