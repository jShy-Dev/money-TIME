using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetApp_MVP.Models
{
    public class BudgetTracking
    {
        [Key]
        public int TrackingId { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public BudgetCategory BudgetCategory { get; set; }

        public int? TransactionId { get; set; }

        [ForeignKey("TransactionId")]
        public Transaction Transaction { get; set; }

        public DateTime CalendarDate { get; set; }

        public string BudgetStatus { get; set; } // "Green", "Orange", "Red"

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}