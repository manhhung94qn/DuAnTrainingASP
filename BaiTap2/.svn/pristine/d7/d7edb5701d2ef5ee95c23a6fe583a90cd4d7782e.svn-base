//using Community;
using DataAccess.UnitOfWork;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using GasStationProject.App_Core.LogWrapper;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DataAccess.Models;
using DataAccess.Repositories;
using DataAccess.Repositories.IRepositories;
//using Yashima;

namespace GasStationProject.App_Core
{
    [ValidateInput(false)]
    public abstract class ControllerExtention : Controller
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly ILogWrapper _logWrapper;
        public ControllerExtention(IUnitOfWork unitOfWork, ILogWrapper logWrapper)
        {
            _unitOfWork = unitOfWork;
            _logWrapper = logWrapper;
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

        }

    }
}
