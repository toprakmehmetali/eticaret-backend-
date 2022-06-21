using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService userService;
        public UserController(IUserService UserService)
        {
            this.userService = UserService; 
        }

        [HttpPost("get")]
        public ActionResult geti(string email)
        {
            var result = userService.GetByMail(email);
            return Ok(result);
        }
    }
}
