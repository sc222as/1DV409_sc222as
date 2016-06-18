using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumberGuessingGame.Controllers
{
    public class SecretNumberController : Controller
    {


        private Models.SecretNumber _SecretNumber = new Models.SecretNumber();
        // GET: SecretNumber
        public ActionResult Index()
        {

            var model = _SecretNumber;
            return View(model);
        }


        // POST: SecretNumber

        [HttpPost]
        public ActionResult Index(Models.SecretNumber SecretNumber, int number) 
        {
            //Models.SecretNumber SecretNumber
            //SecretNumber.MakeGuess(View.number);
            //SecretNumber.MakeGuess(3);
            var model = SecretNumber.MakeGuess(number);
            

            return View("ResultOfGuess", model);



            //TODO
            //Kontrollera Partial Views            
            //Fixa Modellen med det sista
            //


        }
    }
}