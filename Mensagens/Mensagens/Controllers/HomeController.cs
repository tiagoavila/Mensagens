using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mensagens.Models;

namespace Mensagens.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View().ComMensagem("ola mundo!!!", "alert-success");
        }

    }
}
