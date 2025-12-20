using GymManagerWebsite.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Trainer
{
    public int Id { get; set; }

    [Required]
    public string FullName { get; set; }

    [Required]
    public string Specialty { get; set; }

    [Required]
    public int GymId { get; set; }

    [ValidateNever]   // 🔥 ÇÖZÜM
    public Gym Gym { get; set; }
}
