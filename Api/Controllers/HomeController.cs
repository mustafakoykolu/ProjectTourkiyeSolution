using Application.Contracts.Identity;
using Application.Models.Widgets;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IAuthService _authenticationService;

        public HomeController(IAuthService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        [HttpGet("GetWidgets")]
        public IActionResult GetWidgets()
        {
            var response = new WidgetResponse
            {
                Widgets = new List<Widget>
            {
                new Widget
                {
                    Type = "tourSlider",
                    Header = new WidgetHeader
                    {
                        Title = "Sana Özel Turlar",
                        Navigation = new WidgetNavigation
                        {
                            Title = "Tümünü Gör",
                            Deeplink = "tourkiye://Discovery/TourLanding?title=Sana%20Özel%20Turlar"
                        }
                    },
                    ServiceURL = "http://localhost:5049/api/tour/GetPersonalizedTours"
                },
                new Widget
                {
                    Type = "tourSlider",
                    Header = new WidgetHeader
                    {
                        Title = "Popüler Turlar"
                    },
                    ServiceURL = "http://localhost:5049/api/tour/GetPopularTours"
                }
            }
            };

            return Ok(response);
        }
    }
}
