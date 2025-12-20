using System.ComponentModel.DataAnnotations;

namespace GymManagerWebsite.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Duration { get; set; } // dakika
        public decimal Price { get; set; }

        // Foreign Key
        public int GymId { get; set; }
        public Gym Gym { get; set; }

        // Navigation
        public ICollection<Appointment> Appointments { get; set; }
    }
}
