using System;
using System.ComponentModel.DataAnnotations;

namespace BudgetApp_MVP.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public string FullName { get; set; }
        public string AuthProvider { get; set; } // "Apple", "Microsoft", or "Google"

        public decimal? TotalIncome { get; set; }
        public string PayFrequency { get; set; } // Monthly, Bi-weekly, etc.

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}