using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dnn.Artifox.Artifox_Szinvalaszto_Modul.Models;

namespace Dnn.Artifox.Artifox_Szinvalaszto_Modul.Controllers
{
    public class ImageController : Controller
    {
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
    }
}