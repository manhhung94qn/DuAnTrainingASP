using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GasStationProject.App_Core;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Text;
using DataAccess.Repositories.IRepositories;
using DataAccess.UnitOfWork;
using GasStationProject.App_Core.LogWrapper;
using GasStationProject.Models;
using System.Web.Script.Serialization;

namespace GasStationProject.Controllers
{

    public class HomeController : ControllerExtention
    {
        private IGasStationRepository _gasStationRepository;
        private IGasStationGasTypeRepository _gasStationGasTypeRepository;
        private IDistrictRepository _districtRepository;
        private IMTpyeRepository _mTpyeRepository;
        public HomeController(IUnitOfWork unitOfWork, ILogWrapper logWrapper, 
            IGasStationRepository gasStationRepository,
            IGasStationGasTypeRepository gasStationGasTypeRepository,
            IDistrictRepository districtRepository,
            IMTpyeRepository mTpyeRepository
            ) : base(unitOfWork, logWrapper)
        {
            _gasStationRepository = gasStationRepository;
            _gasStationGasTypeRepository = gasStationGasTypeRepository;
            _districtRepository = districtRepository;
            _mTpyeRepository = mTpyeRepository;
        }


        public ActionResult Index()
        {
            ViewBag.listDistrist = _districtRepository.GetAll().OrderBy(x=>x.DistrictName);
            ViewBag.listGasType = _mTpyeRepository.GetAll().Where(x => x.TypeType == 3).ToList();
            return View();
        }

        

        [ValidateAntiForgeryToken]
        public JsonResult gastationFillter(string data)
        {
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            dynamic queryData = json_serializer.DeserializeObject(data);
            string queryGasName = queryData["gasName"];
            string querygasTpye = queryData["gasType"] ;
            string queryDistrict = queryData["districtID"];
            
            // Dung để kiểm tra xem có tồn tại gastype hay không.
            bool checkType(string qr, List<DataAccess.Models.GasStationGasType> gt)
                {
                    foreach (var item in gt)
                    {
                        if(item.GasType == qr) { return true; }
                    }
                    return false;
                }
            
            var gasStations = _gasStationRepository.GetAll().Where(x=>
                (queryGasName != null ? x.GasStationName.Contains(queryGasName) :true) &&
                ( querygasTpye != null ? checkType(querygasTpye, x.GasStationGasType.ToList()): true ) &&
                (queryDistrict != null ? x.District == (long)Convert.ToDouble(queryDistrict): true)
            ).ToList();

            List<GasStationVM> result = new List<GasStationVM>();
            foreach (var item in gasStations)
            {
                GasStationVM gasStationVM = new GasStationVM();
                gasStationVM.GasStationName = item.GasStationName;
                int count = 0;
                foreach (var type in item.GasStationGasType)
                {
                    if (count == 0)
                    {
                        gasStationVM.GasType += _mTpyeRepository.getTypeText(type.GasType, 3);
                        count++;
                    }
                    gasStationVM.GasType += ", " + _mTpyeRepository.getTypeText(type.GasType, 3);
                }
                gasStationVM.DistrictName = _districtRepository.FindById(item.District).DistrictName;
                gasStationVM.Longitude = item.Longitude;
                gasStationVM.Latitude = item.Latitude;
                gasStationVM.Rating = _mTpyeRepository.getTypeText(item.Rating, 4);
                result.Add(gasStationVM);
            }
            return Json(result);
        }

    }
}
