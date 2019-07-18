using DataAccess.Repositories.IRepositories;
using DataAccess.UnitOfWork;
using GasStationProject.App_Core;
using GasStationProject.App_Core.LogWrapper;
using GasStationProject.Models;
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
        private IDistrictRepository _districtRepository;
        private IMTpyeRepository _mTpyeRepository;
        public GasstationController(
            IUnitOfWork unitOfWork, 
            ILogWrapper logWrapper, 
            IGasStationRepository gasStationRepository, 
            IDistrictRepository districtRepository,
            IMTpyeRepository mTpyeRepository
            ) : base(unitOfWork, logWrapper)
        {
            _gasStationRepository = gasStationRepository;
            _districtRepository = districtRepository;
            _mTpyeRepository = mTpyeRepository;
        }
        // GET: Gasstation
        public ActionResult Update()
        {

            return View();
        }

        public ActionResult Add()
        {
            ViewBag.listDistrist = _districtRepository.GetAll().OrderBy(x => x.DistrictName);
            ViewBag.listGasType = _mTpyeRepository.GetAll().Where(x => x.TypeType == 3).ToList();
            ViewBag.ratingList = _mTpyeRepository.GetAll().Where(x=>x.TypeType ==4).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Add(GasStationAddVM gasStationAddVM)
        {
            
            ViewBag.listDistrist = _districtRepository.GetAll().OrderBy(x => x.DistrictName);
            ViewBag.listGasType = _mTpyeRepository.GetAll().Where(x => x.TypeType == 3).ToList();
            ViewBag.ratingList = _mTpyeRepository.GetAll().Where(x => x.TypeType == 4).ToList();

            return View();
        }

    }
}