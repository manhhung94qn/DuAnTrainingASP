using DataAccess.Repositories.IRepositories;
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
    public class GasstationController : ControllerExtention
    {
        private IGasStationRepository _gasStationRepository;
        public GasstationController(IUnitOfWork unitOfWork, ILogWrapper logWrapper, IGasStationRepository gasStationRepository) : base(unitOfWork, logWrapper)
        {
            _gasStationRepository = gasStationRepository;
        }
        // GET: Gasstation
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult listGasstation()
        {
            var listGas = _gasStationRepository.GetAll().ToList();
            return Json( listGas );
        }
    }
}