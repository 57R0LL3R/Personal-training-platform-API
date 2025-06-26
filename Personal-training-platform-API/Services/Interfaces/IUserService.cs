using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Personal_training_platform_API.Models;

namespace Personal_training_platform_API.Services.Interfaces
{
    public interface IUserService
    {

        // GET: api/Users
        [HttpGet]
        Task<ActionResult<IEnumerable<User?>>> GetUsers();
        Task<ActionResult<User?>> GetUser(Guid id);
        Task<IActionResult> PutUser(Guid id, User user);
        Task<ActionResult<User?>> PostUser(User user);

         Task<IActionResult> DeleteUser(Guid id);

    }
}
