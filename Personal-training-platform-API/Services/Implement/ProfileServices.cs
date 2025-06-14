using Microsoft.EntityFrameworkCore;
using Personal_training_platform_API.Models;
using Personal_training_platform_API.Services.Interfaces;



namespace Personal_training_platform_API.Services.Implement
{
    public class ProfileServices(TrainingContext context) : IProfileService
    {
        private readonly TrainingContext _context = context;

        public string DeleteProfile(Profile profile)
        {
            try { 
                _context.Profiles.Remove(profile);
                return "El elemento fue eliminado exitosamente";
            }
            catch
            {
                return "El elemento no fue eliminado";

            }
        }

        public async Task<Profile> GetProfileById(Guid id)
        {
            try
            {
                Profile profile =await _context.Profiles.FirstAsync(x=>x.Id == (id));
                return profile;
            }
            catch
            {
                return new Profile();
            }
        }

        public async Task<List<Profile>> GetProfiles()
        {
            try
            {
                return  await _context.Profiles.ToListAsync();
            }
            catch
            {
                return [];
            }
        }

        public async Task<Profile> PostProfile(Profile profile)
        {
            try
            {
                await _context.AddAsync(profile);
                await _context.SaveChangesAsync();
                return profile;
            }
            catch (Exception ex)
            {
                return new Profile();
            }
        }

        public async Task<Profile> UpdateProfile(Profile profile, Guid id)
        {
            if (id != profile.Id)
            {
                return profile;
            }
            Profile profilet = await GetProfileById(id);
            _context.Entry(profile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (profilet is null)
                {
                    return profile;
                }
                else
                {
                    throw;
                }
            }

            return profile;
        }
    }
}
