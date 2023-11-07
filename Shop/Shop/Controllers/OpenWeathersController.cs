using Microsoft.AspNetCore.Mvc;
using Shop.Core.ServiceInterface;

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
    }
}
