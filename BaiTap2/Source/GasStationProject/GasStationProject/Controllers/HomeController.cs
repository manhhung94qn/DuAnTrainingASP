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
        private IMTpyeRepository _mTypeRepository;
        static public int countPage;
        public HomeController(IUnitOfWork unitOfWork, ILogWrapper logWrapper, 
            IGasStationRepository gasStationRepository,
            IGasStationGasTypeRepository gasStationGasTypeRepository,
            IDistrictRepository districtRepository,
            IMTpyeRepository mTypeRepository
            ) : base(unitOfWork, logWrapper)
        {
            _gasStationRepository = gasStationRepository;
            _gasStationGasTypeRepository = gasStationGasTypeRepository;
            _districtRepository = districtRepository;
            _mTypeRepository = mTypeRepository;
        }


        public ActionResult Index()
        {
            ViewBag.listDistrist = _districtRepository.GetAll().OrderBy(x=>x.DistrictName);
            ViewBag.listGasType = _mTypeRepository.GetAll().Where(x => x.TypeType == 3).ToList();
            ViewBag.pageCount = _gasStationRepository.GetAll().Count();
            return View();
        }

        public ActionResult MapList()
        {
            ViewBag.listDistrist = _districtRepository.GetAll().OrderBy(x => x.DistrictName);
            ViewBag.listGasType = _mTypeRepository.GetAll().Where(x => x.TypeType == 3).ToList();
            ViewBag.pageCount = _gasStationRepository.GetAll().Count();
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
            int queryPage = Convert.ToInt32(queryData["selectPage"]);
            
            // Dung để kiểm tra xem có tồn tại gastype hay không.
            bool checkType(string qr, List<DataAccess.Models.GasStationGasType> gt)
                {
                    foreach (var item in gt)
                    {
                        if(qr.Contains(item.GasType)) { return true; }
                    }
                    return false;
                }

            //Fillter theo các điều kiện truyền vào
            var gasStationsN = _gasStationRepository.GetAll().Where(x=>
                (queryGasName != null ?  x.GasStationName.ToLowerInvariant().Contains(queryGasName) :true) &&
                ( querygasTpye != null ? checkType(querygasTpye, x.GasStationGasType.ToList()): true ) &&
                (queryDistrict != null ? x.District == (long)Convert.ToDouble(queryDistrict): true) 
            );

            countPage = gasStationsN.Count();

            var gasStations = gasStationsN.Skip((queryPage - 1) * 10).Take(10).ToList();

            List<GasStationVM> result = new List<GasStationVM>();

            //Add gasstartion vào bên trong result
            foreach (var item in gasStations)
            {
                GasStationVM gasStationVM = new GasStationVM();
                gasStationVM.GasStationName = item.GasStationName;
                int count = 0;
                foreach (var type in item.GasStationGasType)
                {
                    if (count == 0)
                    {
                        gasStationVM.GasType += _mTypeRepository.getTypeText(type.GasType, 3);
                        count++;
                    }
                    gasStationVM.GasType += ", " + _mTypeRepository.getTypeText(type.GasType, 3);
                }
                gasStationVM.GasStationId = item.GasStationId;
                gasStationVM.DistrictName = _districtRepository.FindById(item.District).DistrictName;
                gasStationVM.Longitude = item.Longitude;
                gasStationVM.Latitude = item.Latitude;
                gasStationVM.Rating = _mTypeRepository.getTypeText(item.Rating, 4);
                result.Add(gasStationVM);
            }

            return Json(result);
        }

        public JsonResult getCountPage()
        {
            return Json(new { page = countPage});
        }

    }
}
