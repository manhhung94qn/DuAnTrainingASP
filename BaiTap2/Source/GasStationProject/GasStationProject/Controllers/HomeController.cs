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

namespace GasStationProject.Controllers
{
    //[AllowAnonymous]
    public class HomeController : ControllerExtention
    {
        private IGasStationRepository _gasStationRepository;
        public HomeController(IUnitOfWork unitOfWork, ILogWrapper logWrapper, IGasStationRepository gasStationRepository) : base(unitOfWork, logWrapper)
        {
            _gasStationRepository = gasStationRepository;
        }

        public ActionResult Index()
        {
            var gasStations = _gasStationRepository.GetAll().ToList();

            return View(gasStations);
        }

    }
}
