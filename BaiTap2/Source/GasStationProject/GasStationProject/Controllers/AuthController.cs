using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess.UnitOfWork;
using System.Web.Mvc;
using GasStationProject.App_Core.LogWrapper;
using GasStationProject.App_Core;
using DataAccess.Repositories.IRepositories;
using DataAccess.Models;
using GasStationProject.Models;

namespace GasStationProject.Controllers
{
    public class AuthController : ControllerExtention
    {
        public AuthController(IUnitOfWork unitOfWork, ILogWrapper logWrapper) : base(unitOfWork, logWrapper)
        {
            
        }
        #region Login

        [AllowAnonymous]
        public ActionResult Login()
        {
            
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(UserLoginVM _user)
        {
            
            return View();
        }

        #endregion


        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}