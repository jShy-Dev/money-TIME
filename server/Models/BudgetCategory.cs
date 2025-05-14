using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetApp_MVP.Models
{
    public class BudgetCategory
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public string CategoryName { get; set; }

        public decimal MonthlyLimit { get; set; }
        public decimal? YearlyLimit { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}