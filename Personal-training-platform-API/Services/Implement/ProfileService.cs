using Microsoft.EntityFrameworkCore;
using Personal_training_platform_API.Models;
using Personal_training_platform_API.Services.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace Personal_training_platform_API.Services.Implement
{
    public class ProfileService(TrainingContext context) : IProfileService
    {
        private readonly TrainingContext _context = context;


        public async Task<Response> GetProfileById(Guid id)
        {
            try
            {

                Profile profile =await _context.Profiles.FirstAsync(x=>x.Id == (id));
                return new() { Message = "El elemento se encontro exitosamene", Data = profile };
            }
            catch (Exception ex)
            {
                return new() { Message = "Error: " + ex.Message, CodeReponse=3, Data = null };
            }
        }

        public async Task<Response> GetProfiles()
        {
            try
            {
                return new() { Message = "La lista se obtuvo exitosamente", Data = await _context.Profiles.ToListAsync() };
            }
            catch (Exception ex)
            {
                return new() { Message = "Error: " + ex.Message, CodeReponse = 3, Data = null }; 
            }
        }

        public async Task<Response> PostProfile(Profile profile)
        {
            try
            {
                await _context.AddAsync(profile);
                await _context.SaveChangesAsync();
                return new() { Message = "El perfil se creo exitosamente", Data = profile };
            }
            catch (Exception ex)
            {
                return new() { Message = "Error: " + ex.Message, CodeReponse = 3, Data = null };
            }
        }

        public async Task<Response> UpdateProfile(Profile profile)
        {

            Response response = await GetProfileById(profile.Id);
            if (response.Data is not null)
            {
                _context.Entry(profile).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return new() { Message = "El proceso se realizo exitosamente", Data = profile };
            }
            else
            {
                return new() { Message = "El proceso no se realizo",CodeReponse=3, Data = profile };
            }
        }
        public async Task<Response> DeleteProfile(Guid id)
        {
            Profile profile = await _context.Profiles.FirstOrDefaultAsync(x => x.Id == id);
            try
            {
                _context.Profiles.Remove(profile);
                return new() { Message = "El elemento fue eliminado exitosamente", Data = profile };
            }
            catch (Exception ex)
            {
                return new() { Message = "Error: " + ex.Message, CodeReponse = 3, Data = profile };

            }
        }
    }
}
