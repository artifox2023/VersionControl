using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;

namespace Dnn.SzinvalasztoArtifox_Szinvalaszto_Module.Controllers
{
    [DnnHandleError]
    public class InputController : DnnController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}