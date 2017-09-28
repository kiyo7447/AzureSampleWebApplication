using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class FontController : Controller
    {
        // GET: Font
        public ActionResult Index(string id)
        {
			Debug.WriteLine($"fontName={id}");
			ViewBag.FontName = id;
            return View();
        }


    }
}