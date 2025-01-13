using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OurHeros.Models;
using OurHeros.Services;


namespace OurHeros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(IUserService userService) : ControllerBase
    {
        private IUserService Userervice { get; } = userService ?? throw new ArgumentNullException(nameof(userService));

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            return Ok(await Userervice.GetAll());
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post([FromBody] User userObj)
        {
            userObj.Id = 0;
            return Ok(await Userervice.AddAndUpdateUser(userObj));
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put(int id, [FromBody] User userObj)
        {
            userObj.Id = id;
            return Ok(await Userervice.AddAndUpdateUser(userObj));
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(AuthenticateRequest model)
        {
            var response = await Userervice.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }
    }
}
