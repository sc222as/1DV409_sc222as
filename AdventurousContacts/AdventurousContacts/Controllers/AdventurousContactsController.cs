using AdventurousContacts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventurousContacts.Controllers
{
    public class AdventurousContactsController : Controller
    {
        private Entities _context = new Entities();
        
        
        // GET: AdventurousContacts
        public ActionResult Index()
        {    
            return View();
        }


        //POST NY CONTACT
        [HttpPost] 
        [ValidateAntiForgeryToken]       
        public ActionResult Index([Bind(Include = "Firstname, Lastname, EmailAddress")]Contact model) // Behövs ContactID här?
        {
            if (ModelState.IsValid)
            {
                return View("index", model);
            }
            return View();
        }



    }
}