using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GymManagerWebsite.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan Time { get; set; }

        public bool IsApproved { get; set; }

        // Identity User
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        // Trainer
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }

        // Service
        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
