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
        private IGasStationGasTypeRepository _gasStationGasTypeRepository;
        public GasstationController(
            IUnitOfWork unitOfWork, 
            ILogWrapper logWrapper, 
            IGasStationRepository gasStationRepository, 
            IDistrictRepository districtRepository,
            IMTpyeRepository mTpyeRepository,
            IGasStationGasTypeRepository gasStationGasTypeRepository
            ) : base(unitOfWork, logWrapper)
        {
            _gasStationRepository = gasStationRepository;
            _districtRepository = districtRepository;
            _mTpyeRepository = mTpyeRepository;
            _gasStationGasTypeRepository = gasStationGasTypeRepository;
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

            if (ModelState.IsValid)
            {
                if (_gasStationRepository.isNameExist(gasStationAddVM.GasStationName))
                {
                    ModelState.AddModelError("",Resources.Resource.E0003);
                    return View();
                }
                DataAccess.Models.GasStation gasStation = new DataAccess.Models.GasStation();
                gasStation.GasStationName = gasStationAddVM.GasStationName;
                gasStation.Address = gasStationAddVM.Address;
                string[] listType = gasStationAddVM.Gatype.Split( Convert.ToChar(","));
                try {
                    gasStation.District = Convert.ToInt64(gasStationAddVM.District);
                    gasStation.Latitude = Convert.ToDouble(gasStationAddVM.Latitude);
                    gasStation.Longitude = Convert.ToDouble(gasStationAddVM.Longitude);
                    gasStation.Rating = gasStation.Rating;
                    gasStation.InsertedAt = DateTime.Now;
                    gasStation.InsertedBy = Convert.ToInt64(Session["個人ID"].ToString());
                }
                catch {
                    ModelState.AddModelError("","Vui lòng kiểm tra lại.");
                    return View();
                }
                _gasStationRepository.Insert(gasStation);
                foreach (var item in listType)
                {
                    DataAccess.Models.GasStationGasType gasStationGasType = new DataAccess.Models.GasStationGasType();
                    gasStationGasType.GasStationId = gasStation.GasStationId;
                    gasStationGasType.GasType = item.Trim();
                    _gasStationGasTypeRepository.Insert(gasStationGasType);
                }
                


            }

            ModelState.AddModelError("", "Có lỗi, vui lòng kiểm tra lại");

            return View();
        }

    }
}