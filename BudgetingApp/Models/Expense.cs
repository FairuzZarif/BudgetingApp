using System.ComponentModel.DataAnnotations;

namespace BudgetingApp.Models
{
    public class Expense
    {
        public int Id { get; set; } // Unique identifier for the expense
        [Required]
        public string Description { get; set; } = null!; // Description of the expense, cannot be null
        [Required]
        public double Amount { get; set; } // Amount of the expense, cannot be negative
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount needs to be higher than 0")] // data attribute for validation and error handling
        public DateTime Date { get; set; } = DateTime.Now; // Date of the expense, cannot be in the future
        public string Category { get; set; } // e.g., "Food", "Transport", etc.
    }
}
