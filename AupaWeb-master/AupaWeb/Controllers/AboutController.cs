using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace AupaWeb.Controllers
{
    public class AboutController : Controller
    {
      public ActionResult AupaIntroduce()
        {
            return View();
        }
      
    }
}