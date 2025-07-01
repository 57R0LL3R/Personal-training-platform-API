using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Personal_training_platform_API.Models;

namespace Personal_training_platform_API.Services.Interfaces
{
    public interface IUserService
    {

        // GET: api/Users
        [HttpGet]
        Task<Response> GetUsers();
        Task<Response> GetUser(Guid id);
        Task<Response> PutUser(User user);
        Task<Response> PostUser(User user);

         Task<Response> DeleteUser(Guid id);

    }
}
