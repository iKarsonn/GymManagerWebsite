using System.ComponentModel.DataAnnotations;

namespace GymManagerWebsite.Models
{
    public class Gym
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public TimeSpan OpenTime { get; set; }

        [Required]
        public TimeSpan CloseTime { get; set; }

        // Navigation Properties
        public ICollection<Trainer> Trainers { get; set; } = new List<Trainer>();
        public ICollection<Service> Services { get; set; } = new List<Service>();
    }
}
