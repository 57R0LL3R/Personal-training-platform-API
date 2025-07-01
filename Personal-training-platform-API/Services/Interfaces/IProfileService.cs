using Personal_training_platform_API.Models;

namespace Personal_training_platform_API.Services.Interfaces
{
    public interface IProfileService
    {
        public Task<Response> GetProfiles();
        public Task<Response> GetProfileById(Guid id);
        public Task<Response> UpdateProfile(Profile profile);
        public Task<Response> DeleteProfile(Profile profile);

        public Task<Response> PostProfile(Profile profile);



    }
}
