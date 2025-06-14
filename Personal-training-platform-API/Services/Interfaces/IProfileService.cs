using Personal_training_platform_API.Models;

namespace Personal_training_platform_API.Services.Interfaces
{
    public interface IProfileService
    {
        public Task<List<Profile>> GetProfiles();
        public Task<Profile> GetProfileById(Guid id);
        public Task<Profile> UpdateProfile(Profile profile, Guid id);
        public string DeleteProfile(Profile profile);

        public Task<Profile> PostProfile(Profile profile);



    }
}
