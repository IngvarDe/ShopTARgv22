using Microsoft.AspNetCore.Mvc;
using Shop.Core.Dto.OpenWeatherDtos;
using Shop.Core.ServiceInterface;
using Shop.Models.OpenWeathers;

namespace Shop.Controllers
{
    public class OpenWeathersController : Controller
    {
        private readonly IWeatherForecastServices _weatherForecastServices;

        public OpenWeathersController
            (
            IWeatherForecastServices weatherForecastServices
            )
        {
            _weatherForecastServices = weatherForecastServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchCity(SearchCityViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City", "OpenWeathers", new { city = model.CityName });
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult City(string city)
        {
            OpenWeatherResultDto dto = new();
            dto.City = city;

            _weatherForecastServices.OpenWeatherResult(dto);
            OpenWeatherViewModel vm = new();

            vm.City = dto.City;
            vm.Lon = dto.Lon;
            vm.Lat = dto.Lat;
            vm.WeatherId = dto.WeatherId;
            vm.Main = dto.Main;
            vm.Description = dto.Description;
            vm.Icon = dto.Icon;
            vm.Base = dto.Base;
            vm.Temp = dto.Temp;
            vm.FeelsLike = dto.FeelsLike;
            vm.TempMin = dto.TempMin;
            vm.TempMax = dto.TempMax;
            vm.Pressure = dto.Pressure;
            vm.Humidity = dto.Humidity;
            vm.Visibility = dto.Visibility;
            vm.WindSpeed = dto.WindSpeed;
            vm.WinDeg = dto.WinDeg;
            vm.CloudsAll = dto.CloudsAll;
            vm.Dt = dto.Dt;
            vm.Type = dto.Type;
            vm.SysId = dto.SysId;
            vm.Country = dto.Country;
            vm.Sunrise = dto.Sunrise;
            vm.Sunset = dto.Sunset;
            vm.TimeZone = dto.TimeZone;
            vm.TimeZoneId = dto.TimeZoneId;
            vm.Name = dto.Name;
            vm.Cod = dto.Cod;

            return View(vm);
        }
    }
}
