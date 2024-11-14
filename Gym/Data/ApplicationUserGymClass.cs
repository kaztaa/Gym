using Gym.Models;

namespace Gym.Data
{
    public class ApplicationUserGymClass
    {

        public int Id { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int GymClassId { get; set; }
        public GymClass GymClass { get; set; }
    }
}
