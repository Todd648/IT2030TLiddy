using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class ProductController : Controller
    {
        // GET: /Product 
        public ActionResult Index() 
        { 
            return View(); 
        } 
        // GET: /Product/Welcome/  
        public ActionResult Welcome() 
        { 
            return View(); 
        }
        // GET: /Product/Browse/ 
        public ActionResult Browse()
        {
            return View();
        }
        // GET: /Product/Details/
        public ActionResult Details(int id)
        {
           ViewBag.Message = "ID =" + id;
            return View();
        }
        // GET: /Product/Location/ 
        public ActionResult Location(int zip)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Zip =" + zip);
            return View();
        }
    }
}