using Application.Facade;
using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Apresentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(IUserService userService, UserFacade userFacade) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Users users)
        {
            try
            {
                var result = await userFacade.Create(users);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
