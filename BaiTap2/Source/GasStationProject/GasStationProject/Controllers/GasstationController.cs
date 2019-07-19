using DataAccess.Repositories.IRepositories;
using DataAccess.UnitOfWork;
using GasStationProject.App_Core;
using GasStationProject.App_Core.LogWrapper;
using GasStationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

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
                try {
                    gasStation.GasStationName = gasStationAddVM.GasStationName;
                    gasStation.Address = gasStationAddVM.Address;
                    gasStation.OpeningTime = gasStationAddVM.OpeningTime;
                    gasStation.District = Convert.ToInt64(gasStationAddVM.District);
                    gasStation.Latitude = Convert.ToDouble(gasStationAddVM.Latitude);
                    gasStation.Longitude = Convert.ToDouble(gasStationAddVM.Longitude);
                    gasStation.Rating = gasStationAddVM.Rating;
                    gasStation.InsertedAt = DateTime.Now;
                    string userID = Session["個人ID"].ToString().Replace("{","").Replace("}","");
                    gasStation.InsertedBy = Convert.ToInt64(Regex.Replace(userID, @"\D", ""));
                    gasStation.UpdatedAt = DateTime.Now;
                    gasStation.UpdatedBy = gasStation.InsertedBy;                    
                    
                }
                catch {
                    ModelState.AddModelError("","Vui lòng kiểm tra lại.");
                    return View();
                }
                _gasStationRepository.Insert(gasStation);
                _unitOfWork.Commit();
                string[] listType = gasStationAddVM.Gatype.Split(Convert.ToChar(","));
                foreach (var item in listType)
                {
                    DataAccess.Models.GasStationGasType gasStationGasType = new DataAccess.Models.GasStationGasType();
                    gasStationGasType.GasStationId = gasStation.GasStationId;
                    gasStationGasType.GasType = item.Trim();
                    _gasStationGasTypeRepository.Insert(gasStationGasType);
                }
                _unitOfWork.Commit();
                return RedirectToAction("Index", "Home");   
            }
            ModelState.AddModelError("", "Có lỗi, vui lòng kiểm tra lại");
            return View();
        }

        public ActionResult Edit(int Id)
        {
            if( Id.ToString() == null )
            {
                return RedirectToAction("Error", "Error");
            }

            DataAccess.Models.GasStation gasStation = _gasStationRepository.FindById(Id);

            if (gasStation == null)
            {
                return RedirectToAction("NotFound", "Error");
            }

            ViewBag.listDistrist = _districtRepository.GetAll().OrderBy(x => x.DistrictName);
            ViewBag.listGasType = _mTpyeRepository.GetAll().Where(x => x.TypeType == 3).ToList();
            ViewBag.ratingList = _mTpyeRepository.GetAll().Where(x => x.TypeType == 4).ToList();
            GasStationAddVM gasStationAddVM = new GasStationAddVM();
            gasStationAddVM.GasStationName = gasStation.GasStationName;
            gasStationAddVM.Longitude = gasStation.Longitude.ToString();
            gasStationAddVM.Latitude = gasStation.Latitude.ToString();
            gasStationAddVM.District = gasStation.District.ToString();
            gasStationAddVM.Address = gasStation.Address;
            gasStationAddVM.OpeningTime = gasStation.OpeningTime;
            gasStationAddVM.Rating = gasStation.Rating;
            gasStationAddVM.GasStationId = gasStation.GasStationId;
            List<DataAccess.Models.GasStationGasType> listGasTypes = _gasStationGasTypeRepository.findByGasStationId(Id);
            foreach (var item in listGasTypes)
            {
                if(gasStationAddVM.Gatype == null)
                {
                    gasStationAddVM.Gatype += item.GasType;
                } else { gasStationAddVM.Gatype += "," + item.GasType; }
            }
            return View(gasStationAddVM);
        }

        [HttpPost]
        public ActionResult Edit(GasStationAddVM gasStationEdit)
        {
            ViewBag.listDistrist = _districtRepository.GetAll().OrderBy(x => x.DistrictName);
            ViewBag.listGasType = _mTpyeRepository.GetAll().Where(x => x.TypeType == 3).ToList();
            ViewBag.ratingList = _mTpyeRepository.GetAll().Where(x => x.TypeType == 4).ToList();
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Vui lòng kiểm tra lại dữ liệu");
                return View(gasStationEdit);
            }

            if (_gasStationRepository.isNameExist(gasStationEdit.GasStationName) && _gasStationRepository.FindById(gasStationEdit.GasStationId).GasStationName != gasStationEdit.GasStationName)
            {
                ModelState.AddModelError("", Resources.Resource.E0003);
                return View(gasStationEdit);
            }

            DataAccess.Models.GasStation gasStation = _gasStationRepository.FindById(gasStationEdit.GasStationId);
            try
            {
                gasStation.GasStationName = gasStationEdit.GasStationName;
                gasStation.Address = gasStationEdit.Address;
                gasStation.OpeningTime = gasStationEdit.OpeningTime;
                gasStation.District = Convert.ToInt64(gasStationEdit.District);
                gasStation.Latitude = Convert.ToDouble(gasStationEdit.Latitude);
                gasStation.Longitude = Convert.ToDouble(gasStationEdit.Longitude);
                gasStation.Rating = gasStationEdit.Rating;
                gasStation.InsertedAt = DateTime.Now;
                string userID = Session["個人ID"].ToString().Replace("{", "").Replace("}", "");
                gasStation.InsertedBy = Convert.ToInt64(Regex.Replace(userID, @"\D", ""));
                gasStation.UpdatedAt = DateTime.Now;
                gasStation.UpdatedBy = gasStation.InsertedBy;

            }
            catch
            {
                ModelState.AddModelError("", "Vui lòng kiểm tra lại.");
                return View();
            }
            _gasStationRepository.Update(gasStation);
            _unitOfWork.Commit();

            List<DataAccess.Models.GasStationGasType> gasTypeList = _gasStationGasTypeRepository.findByGasStationId(gasStationEdit.GasStationId);
            foreach (var item in gasTypeList)
            {
                _gasStationGasTypeRepository.Delete(item.GasStationGasTypeId);
            }
            _unitOfWork.Commit();
            string[] listType = gasStationEdit.Gatype.Split(Convert.ToChar(","));
            foreach (var item in listType)
            {
                DataAccess.Models.GasStationGasType gasStationGasType = new DataAccess.Models.GasStationGasType();
                gasStationGasType.GasStationId = gasStation.GasStationId;
                gasStationGasType.GasType = item.Trim();
                _gasStationGasTypeRepository.Insert(gasStationGasType);
            }
            _unitOfWork.Commit();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Delete( long Id)
        {
            if (Id.ToString() == null)
            {
                return RedirectToAction("Error", "Error");
            }

            DataAccess.Models.GasStation gasStation = _gasStationRepository.FindById(Id);

            if (gasStation == null)
            {
                return RedirectToAction("NotFound", "Error");
            }

            ViewBag.listDistrist = _districtRepository.GetAll().OrderBy(x => x.DistrictName);
            ViewBag.listGasType = _mTpyeRepository.GetAll().Where(x => x.TypeType == 3).ToList();
            ViewBag.ratingList = _mTpyeRepository.GetAll().Where(x => x.TypeType == 4).ToList();
            GasStationAddVM gasStationAddVM = new GasStationAddVM();
            gasStationAddVM.GasStationName = gasStation.GasStationName;
            gasStationAddVM.Longitude = gasStation.Longitude.ToString();
            gasStationAddVM.Latitude = gasStation.Latitude.ToString();
            gasStationAddVM.District = gasStation.District.ToString();
            gasStationAddVM.Address = gasStation.Address;
            gasStationAddVM.OpeningTime = gasStation.OpeningTime;
            gasStationAddVM.Rating = gasStation.Rating;
            gasStationAddVM.GasStationId = gasStation.GasStationId;
            List<DataAccess.Models.GasStationGasType> listGasTypes = _gasStationGasTypeRepository.findByGasStationId(Id);
            foreach (var item in listGasTypes)
            {
                if (gasStationAddVM.Gatype == null)
                {
                    gasStationAddVM.Gatype += item.GasType;
                }
                else { gasStationAddVM.Gatype += "," + item.GasType; }
            }
            return View(gasStationAddVM);
        }

        [HttpPost]
        public ActionResult Delete (GasStationAddVM gasStationAddVM)
        {
            if(gasStationAddVM.GasStationId.ToString() == null)
            {
                return RedirectToAction("NotFound", "Error");
            }
            List<DataAccess.Models.GasStationGasType> gasTypeList = _gasStationGasTypeRepository.findByGasStationId(gasStationAddVM.GasStationId);
            foreach (var item in gasTypeList)
            {
                _gasStationGasTypeRepository.Delete(item.GasStationGasTypeId);
            }
            _gasStationRepository.Delete(gasStationAddVM.GasStationId);
            _unitOfWork.Commit();
            return RedirectToAction("Index", "Home");
        }

    }
}