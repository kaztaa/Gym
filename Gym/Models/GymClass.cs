﻿using Gym.Data;
using System.ComponentModel.DataAnnotations;

namespace Gym.Models
{
    public class GymClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EndTime { get { return StartTime + Duration; } }
        public String Description { get; set; }

        public ICollection<ApplicationUserGymClass>? AttendingMembers { get; set; }
    }
}
