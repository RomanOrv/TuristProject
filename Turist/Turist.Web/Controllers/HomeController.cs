using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Turist.Repository.Interfaces;
using Turist.Web.Models.Shared;

namespace Turist.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITuristRepository _turistRepository;
        private int [] _childHotels = new int[] { 1, 2, 4 };
        private int[] _youngHotels = new int[] { 1, 6, 8 };
        private int[] _middleAgeHotels = new int[] { 2, 3, 8 };
        private int[] _oldAgeHotels = new int[] { 1, 7, 10 };

        public HomeController(ITuristRepository turistRepository)
        {
            this._turistRepository = turistRepository;
        }

        public ActionResult Index()
        {
            ViewBag.ChartSafetyData = GetChartSafetyData(_childHotels);
            ViewBag.ChartComfortData = GetChartComfortData(_childHotels);
            ViewBag.ChartInformativeData = GetChartInformativeData(_childHotels);
            ViewBag.ChartStaffQualificationData = GetChartStaffQualificationData(_childHotels);
            return View();
        }



        public ActionResult Young()
        {
            ViewBag.ChartSafetyData = GetChartSafetyData(_youngHotels);
            ViewBag.ChartComfortData = GetChartComfortData(_youngHotels);
            ViewBag.ChartInformativeData = GetChartInformativeData(_youngHotels);
            ViewBag.ChartStaffQualificationData = GetChartStaffQualificationData(_youngHotels);
            return View();
        }

        public ActionResult MiddleAge()
        {
            ViewBag.ChartSafetyData = GetChartSafetyData(_middleAgeHotels);
            ViewBag.ChartComfortData = GetChartComfortData(_middleAgeHotels);
            ViewBag.ChartInformativeData = GetChartInformativeData(_middleAgeHotels);
            ViewBag.ChartStaffQualificationData = GetChartStaffQualificationData(_middleAgeHotels);
            return View();
        }

        public ActionResult OldAge()
        {
            ViewBag.ChartSafetyData = GetChartSafetyData(_oldAgeHotels);
            ViewBag.ChartComfortData = GetChartComfortData(_oldAgeHotels);
            ViewBag.ChartInformativeData = GetChartInformativeData(_oldAgeHotels);
            ViewBag.ChartStaffQualificationData = GetChartStaffQualificationData(_oldAgeHotels);
            return View();
        }


        #region Child

        public ActionResult GetChildSafeties([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetSafetyList().Where(x => _childHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }

        public ActionResult GetChildComforts([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetСomfortList().Where(x => _childHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }


        public ActionResult GetChildInformative([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetInformativeList().Where(x => _childHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }

        public ActionResult GetChildStaffQualification([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetStaffQualificationList().Where(x => _childHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }

        #endregion


        #region Young

        public ActionResult GetYoungSafeties([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetSafetyList().Where(x => _youngHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }

        public ActionResult GetYoungComforts([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetСomfortList().Where(x => _youngHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }


        public ActionResult GetYoungInformative([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetInformativeList().Where(x => _youngHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }

        public ActionResult GetYoungStaffQualification([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetStaffQualificationList().Where(x => _youngHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }

        #endregion


        #region MiddleAge

        public ActionResult GetMiddleAgeSafeties([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetSafetyList().Where(x => _middleAgeHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }

        public ActionResult GetMiddleAgeComforts([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetСomfortList().Where(x => _middleAgeHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }


        public ActionResult GetMiddleAgeInformative([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetInformativeList().Where(x => _middleAgeHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }

        public ActionResult GetMiddleAgeStaffQualification([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetStaffQualificationList().Where(x => _middleAgeHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }

        #endregion


        #region OldAge

        public ActionResult GetOldAgeSafeties([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetSafetyList().Where(x => _oldAgeHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }

        public ActionResult GetOldAgeComforts([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetСomfortList().Where(x => _oldAgeHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }


        public ActionResult GetOldAgeInformative([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetInformativeList().Where(x => _oldAgeHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }

        public ActionResult GetOldAgeStaffQualification([DataSourceRequest] DataSourceRequest request)
        {
            var models =
                this._turistRepository.GetStaffQualificationList().Where(x => _oldAgeHotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return Json(models.OrderBy(x => x.CompanyNumber).ToDataSourceResult(request));
        }

        #endregion


        #region Helpers

        private List<CyclogramChartModel> GetChartStaffQualificationData(int[] hotels)
        {
            var models =
                this._turistRepository.GetStaffQualificationList().Where(x => hotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return CreateCyclogramChartModels(models);
        }

        private List<CyclogramChartModel> GetChartInformativeData(int[] hotels)
        {
            var models =
                this._turistRepository.GetInformativeList().Where(x => hotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return CreateCyclogramChartModels(models);
        }

        private List<CyclogramChartModel> GetChartComfortData(int[] hotels)
        {
            var models =
                this._turistRepository.GetСomfortList().Where(x => hotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return CreateCyclogramChartModels(models);
        }

        private List<CyclogramChartModel> GetChartSafetyData(int[] hotels)
        {
            var models =
                this._turistRepository.GetSafetyList().Where(x => hotels.Contains(x.CompanyId)).Select(y =>
                    new GridModel
                    {
                        CompanyNumber = y.CompanyId,
                        ResidenceCoefficient = y.Residence,
                        FoodCoefficient = y.Food,
                        TransportationCoefficient = y.Transportation,
                        ExcursionCoefficient = y.Excursion,
                        AverageRateCoefficient = y.AverageRate
                    }).ToList();

            return CreateCyclogramChartModels(models);
        }

        private List<CyclogramChartModel> CreateCyclogramChartModels(List<GridModel> models)
        {
            var chartsData = new List<CyclogramChartModel>();
            foreach (var m in models)
            {
                var chart = new CyclogramChartModel();
                chart.name = $"Туристична організація №{m.CompanyNumber}.";
                var data = new List<decimal>();
                data.Add(m.AverageRateCoefficient);
                data.Add(m.FoodCoefficient);
                data.Add(m.TransportationCoefficient);
                data.Add(m.ExcursionCoefficient);
                data.Add(m.ResidenceCoefficient);
                chart.data.AddRange(data);
                chartsData.Add(chart);
            }

            return chartsData;
        }

        #endregion
    }
}