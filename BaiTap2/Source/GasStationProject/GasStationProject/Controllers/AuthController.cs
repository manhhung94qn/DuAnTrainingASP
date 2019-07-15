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
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;


namespace GasStationProject.Controllers
{
    public class AuthController : ControllerExtention
    {
        private IUserRepository _userRepository;
        public AuthController(IUnitOfWork unitOfWork, ILogWrapper logWrapper, IUserRepository userRepository) : base(unitOfWork, logWrapper)
        {
            _userRepository = userRepository;
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
            User user = _userRepository.GetUserByEmail(_user.Email, _user.Password);
            return View();
        }

        #endregion


        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}