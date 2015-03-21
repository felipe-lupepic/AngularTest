using Exemplo3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exemplo3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new ExemploViewModel() { Id = 10, Name = "Teste name", Duration = "15m", Speaker = "Speaker teste", Venue = "Venue test" };

            return View(model);
        }

    }
}
