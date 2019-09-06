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
 
        public string Index() 
        { 
            return "This is my <b>default</b> action..."; 
        } 
 
        // 
        // GET: /HelloWorld/Welcome/ 
 
        public string Welcome() 
        { 
            return "This is the Welcome action method..."; 
        } 
        public string Browse()
        {
            return "Browse Displayed";
           
        }
        public string Details(int id)
        {
           string message = "Store.Details, ID =" + id;
           return message;
          
        }
        public string Location(int zip)
        {
            string message = HttpUtility.HtmlEncode("Store.Details, zip =" + zip);
            return message;

        }


    }
}