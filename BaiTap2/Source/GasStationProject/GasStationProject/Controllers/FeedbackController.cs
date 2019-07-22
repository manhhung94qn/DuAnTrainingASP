using DataAccess.Repositories.IRepositories;
using DataAccess.UnitOfWork;
using GasStationProject.App_Core;
using GasStationProject.App_Core.LogWrapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Script.Services;

namespace GasStationProject.Controllers
{
    public class FeedbackController : ControllerExtention
    {
        private IGasStationRepository _gasStationRepository;
        private IGasStationGasTypeRepository _gasStationGasTypeRepository;
        private IMTpyeRepository _mTpyeRepository;
        private IDistrictRepository _districtRepository;
        private IFeedbackRepository _feedbackRepository;
        public FeedbackController (IUnitOfWork unitOfWork, ILogWrapper logWrapper,
            IGasStationRepository gasStationRepository,
            IGasStationGasTypeRepository gasStationGasTypeRepository,
            IMTpyeRepository mTpyeRepository,
            IDistrictRepository districtRepository,
            IFeedbackRepository feedbackRepository
            ) : base(unitOfWork, logWrapper)
        {
            _gasStationRepository = gasStationRepository;
            _gasStationGasTypeRepository = gasStationGasTypeRepository;
            _mTpyeRepository = mTpyeRepository;
            _districtRepository = districtRepository;
            _feedbackRepository = feedbackRepository;
        }

        public ActionResult Detail(long Id)
        {
            Models.FeedbackVM feedbackVM = new Models.FeedbackVM();
            if (Id.ToString() == null )
            {
                return RedirectToAction("Error", "Error");
            }
            DataAccess.Models.GasStation gasStation = new DataAccess.Models.GasStation();
            gasStation = _gasStationRepository.FindById(Id);
            if(gasStation == null)
            {
                return RedirectToAction("NotFound", "Error");
            }
            feedbackVM.GasStationName = gasStation.GasStationName;
            List<DataAccess.Models.GasStationGasType> listgasType = new List<DataAccess.Models.GasStationGasType>();
            listgasType = _gasStationGasTypeRepository.GetAll().Where(x => x.GasStationId == Id).ToList();
            foreach (var item in listgasType)
            {
                if(feedbackVM.GasType == null)
                {
                    feedbackVM.GasType += _mTpyeRepository.getTypeText(item.GasType, 3);
                } else
                {
                    feedbackVM.GasType +=", " + _mTpyeRepository.getTypeText(item.GasType, 3);
                }
            }
            feedbackVM.GasAddress = gasStation.Address + ", " + _districtRepository.FindById(gasStation.District).DistrictName;
            feedbackVM.OpenTime = gasStation.OpeningTime;
            feedbackVM.Rating = _mTpyeRepository.getTypeText(gasStation.Rating,4);
            ViewBag.countPage = _feedbackRepository.GetAll().Where(x => x.GasStationId == Id).Count();
            return View(feedbackVM);
        }

        [System.Web.Services.WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public string getFeedback(string data)
        {
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            dynamic queryData = json_serializer.DeserializeObject(data);
            long idGas = Convert.ToInt64(queryData["Id"]);
            int queryPage = Convert.ToInt32(queryData["page"]);
            List<DataAccess.Models.GasStationFeedback> listFeedback = new List<DataAccess.Models.GasStationFeedback>();
            listFeedback = _feedbackRepository.GetAll().Where(x => x.GasStationId == idGas).OrderByDescending(x=>x.FeedbackAt).Skip((queryPage-1)*10).Take(10).ToList();
            var result = JsonConvert.SerializeObject(listFeedback, Formatting.None,new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                        });

            return result;
        }

    }
}