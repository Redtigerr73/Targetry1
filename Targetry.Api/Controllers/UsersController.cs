using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Targetry.Application.Users.Commands;
using Targetry.Application.Users.Models;
using Targetry.Application.Users.Queries;
using Targetry.Domain.Entities;

namespace Targetry.Api.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/[controller]")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    //[Authorize(Roles = "Admin, WeatherUser, SomeOtherRole")] *** If needed specify Auth0 Role 



    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAllUsers()
        {
            return Ok(await _mediator.Send(new GetUsersQuery()));
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<UserDto>> GetUserById(int id)
        {
            return Ok(await _mediator.Send(new GetUserByIdQuery(id)));
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDto user)
        {
            return Ok(await _mediator.Send(new CreateUserCommand(user)));
        }
        
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateUser(int id, UpdateUserDto user)
        {
            return Ok(await _mediator.Send(new UpdateUserCommand(id, user)));
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            return Ok(await _mediator.Send(new DeleteUserCommand(id)));
        }




    }
}
