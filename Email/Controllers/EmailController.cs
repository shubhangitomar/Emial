using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;

namespace Email.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult SendEmail()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendEmail(string username)
        {
           
            
                string subject = "You have been selected ";
                string body = "Please contact us";
                WebMail.Send(username, subject, body, null, null, null, true, null, null, null, null, null, null);
                ViewBag.msg = "Email sent successfully.....";
                return View();
           
           
            
       }
    }
}