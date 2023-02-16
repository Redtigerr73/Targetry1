using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Targetry.Api.Controllers
{
    public class SessionsController : Controller
    {
        private readonly IMediator _mediator;

        public SessionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public IActionResult CreateSession()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteSession()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetSession()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSession()
        {
            return Ok();
        }
    }
}
