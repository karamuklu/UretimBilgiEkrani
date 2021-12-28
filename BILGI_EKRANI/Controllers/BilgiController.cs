using BG_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BILGI_EKRANI.Controllers
{
    public class BilgiController : Controller
    {
        // GET: Bilgi
        BG_BusinessLayer bg_manager = new BG_BusinessLayer();
        public ActionResult Index()
        {
            return View(bg_manager.isList());
        }
    }
}
