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

namespace GasStationProject.Controllers
{
    //[AllowAnonymous]
    public class HomeController : ControllerExtention
    {
        private IGasStationRepository _gasStationRepository;
        private IGasStationGasTypeRepository _gasStationGasTypeRepository;
        private IDistrictRepository _districtRepository;
        public HomeController(IUnitOfWork unitOfWork, ILogWrapper logWrapper, 
            IGasStationRepository gasStationRepository,
            IGasStationGasTypeRepository gasStationGasTypeRepository,
            IDistrictRepository districtRepository
            ) : base(unitOfWork, logWrapper)
        {
            _gasStationRepository = gasStationRepository;
            _gasStationGasTypeRepository = gasStationGasTypeRepository;
            _districtRepository = districtRepository;
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            var gasStations = _gasStationRepository.GetAll().ToList();

            List<GasStationVM> result = new List<GasStationVM>();
            foreach (var item in gasStations)
            {
                GasStationVM gasStationVM = new GasStationVM();
                gasStationVM.GasStationName = item.GasStationName;
                foreach (var style in item.GasStationGasType)
                {
                    var gasStyle = _gasStationGasTypeRepository.FindById(style.GasStationGasTypeId);
                    gasStationVM.GasStyle.Add(gasStyle.GasType);
                }
                gasStationVM.DistrictName = _districtRepository.FindById(item.District ).DistrictName;
                gasStationVM.Longitude = item.Longitude;
                gasStationVM.Latitude = item.Latitude;
                gasStationVM.Rating = item.Rating;


            }

            return View(gasStations);
        }

    }
}
