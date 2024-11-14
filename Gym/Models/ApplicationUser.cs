using Gym.Data;
using Microsoft.AspNetCore.Identity;

namespace Gym.Models
{
    public class ApplicationUser: IdentityUser
    {
        public ICollection<ApplicationUserGymClass> AttendedClasses { get; set; }
    }
}
