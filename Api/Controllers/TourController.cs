using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class TourController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TourController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public IActionResult GetPersonalizedTours()
        {
            throw new NotImplementedException("Hop şampiyon! Acelen ne ¿ Daha servisi yazmadık !");
        }

        public IActionResult GetPopularTours()
        {
            throw new NotImplementedException("Şerefsizim lokalimde çalışıyordu !");
        }
    }
}
