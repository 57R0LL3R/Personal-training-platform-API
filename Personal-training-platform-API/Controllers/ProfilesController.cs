
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Personal_training_platform_API.Models;
using Personal_training_platform_API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personal_training_platform_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController(IProfileService profileService) : ControllerBase
    {
        private readonly IProfileService _profileService = profileService;

        // GET: api/Profiles
        [HttpGet]
        public async Task<Response> GetProfiles()
        {
            return await _profileService.GetProfiles();
        }

        // GET: api/Profiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Response>> GetProfile(Guid id)
        {
            var profile = await _profileService.GetProfileById(id);

            if (profile == null)
            {
                return NotFound();
            }

            return profile;
        }

        // PUT: api/Profiles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<Response> PutProfile(Profile profile)
        {
            return await _profileService.UpdateProfile(profile);
        }

        // POST: api/Profiles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<Response> PostProfile(Profile profile)
        {
            

            return await _profileService.PostProfile(profile);
        }

        // DELETE: api/Profiles/5
        [HttpDelete("{id}")]
        public async Task<Response> DeleteProfile(Guid id)
        {
            try
            {
                return await _profileService.DeleteProfile(id);
            }
            catch (Exception ex)
            {
                return new() { Message ="Error: "+ex.Message };
            }
        }

    }
}
