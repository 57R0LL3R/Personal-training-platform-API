using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Personal_training_platform_API.Models;
using Personal_training_platform_API.Services.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Personal_training_platform_API.Services.Implement
{
    public class UserService(TrainingContext context) :IUserService
    {
        private readonly TrainingContext _context = context;

        public async Task<Response> GetUsers()
        {
            try
            {
                return new() { Message = "La lista se obtuvo exitosamente", Data = await _context.Users.ToListAsync() };
            }
            catch (Exception ex)
            {
                return new() { Message = "Error: " + ex.Message, CodeReponse = 3, Data = null };
            }
        }

        public async Task<Response> GetUser(Guid id)
        {

            try
            {
                var user = await _context.Users.FirstAsync(x => x.Id == (id));
                return new() { Message = "El elemento se encontro exitosamene", Data = user };
            }
            catch (Exception ex)
            {
                return new() { Message = "Error: " + ex.Message, CodeReponse = 3, Data = null };
            }
        }

        public async Task<Response> PutUser(User user)
        {
            try
            {
                _context.Entry(user).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return new() {Data = user };
            }
            catch (Exception ex)
            {
                return new() { Message = "Error: " + ex.Message, CodeReponse = 3, Data = user };
            }


        }

        public async Task<Response> PostUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return new() { Data = user };
            }
            catch(Exception ex) 
            {
                return new() { Message = "Error: "+ex.Message, CodeReponse = 3, Data = user };
            }
        }

        public async Task<Response> DeleteUser(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return new() { Message = "Error: No se encuentra el usuario", CodeReponse = 3, Data = user };
            }
            try
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return new() {  Data = user };
            }
            catch (Exception ex)
            {
                return new() { Message = "Error: " + ex.Message, CodeReponse = 3, Data = user };
            }
        }

        private bool UserExists(Guid id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
