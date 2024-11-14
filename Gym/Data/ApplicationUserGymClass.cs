using Gym.Models;

namespace Gym.Data
{
    public class ApplicationUserGymClass
    {

        // Primärnyckel
        public int Id { get; set; }

        // Främmande nyckel till ApplicationUser
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        // Främmande nyckel till GymClass
        public int GymClassId { get; set; }
        public GymClass GymClass { get; set; }
    }
}
