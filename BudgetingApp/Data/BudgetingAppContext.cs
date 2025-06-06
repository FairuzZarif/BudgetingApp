using BudgetingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetingApp.Data
{
    public class BudgetingAppContext : DbContext
    {
        public BudgetingAppContext(DbContextOptions<BudgetingAppContext> options) : base(options) { } // Constructor that accepts DbContextOptions for configuration

        // instance of DbSet for managing expenses in the database
        DbSet<Expense> Expenses { get; set; } // DbSet for managing expenses in the database
    }
}
