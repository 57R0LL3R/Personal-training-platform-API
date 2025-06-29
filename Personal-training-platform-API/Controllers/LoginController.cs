using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Personal_training_platform_API.Models;

namespace Personal_training_platform_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController(TrainingContext context) : ControllerBase
    {
        private readonly TrainingContext _context = context;


        [HttpPost]
        public async Task<ActionResult<Response>> Login(User user)
        {

            var finaluser = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email && u.PasswordHash == user.PasswordHash);
            if (finaluser == null)
            {
                return new Response
                {
                    CodeReponse = 3,
                    Message = "The user not exist",
                    Data = null
                };
            }
            return new Response
            {
                CodeReponse = 1,
                Message = "The user exist",
                Data = finaluser
            }; ;
        }
    }
}
