using DataAccess.UnitOfWork;
using GasStationProject.App_Core;
using GasStationProject.App_Core.LogWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GasStationProject.Controllers
{
    public class ErrorController : ControllerExtention
    {
        public ErrorController(IUnitOfWork unitOfWork, ILogWrapper logWrapper) : base(unitOfWork, logWrapper)
        {
        }

        //
        // GET: /*/Error
        [AllowAnonymous]
        public ActionResult Error(string RequestUrl)
        {
            ViewBag.RequestUrl = RequestUrl;

            return View();
        }

        //
        // GET: /*/NotFound
        [AllowAnonymous]
        public ActionResult NotFound(string RequestUrl)
        {
            return View();
        }

        //
        // GET: /*/AccessDenied
        [AllowAnonymous]
        public ActionResult AccessDenied(string RequestUrl)
        {
            return View();
        }
    }
}
