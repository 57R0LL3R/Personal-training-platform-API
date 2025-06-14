using Personal_training_platform_API.Models;

namespace Personal_training_platform_API.Services.Interfaces
{
    public interface IProfileService
    {
        public List<Profile> GetProfiles();
        public Profile GetProfileById(int id);
        public Profile UpdateProfile(Profile profile, Guid id);
        public string DeleteProfile(Profile profile);

        public Profile PostProfile(Profile profile);



    }
}
