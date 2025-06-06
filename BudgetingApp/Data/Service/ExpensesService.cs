using BudgetingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetingApp.Data.Service
{
    public class ExpensesService : IExpensesService
    {
        private readonly BudgetingAppContext _context; // Instance of BudgetingAppContext for database operations
        public ExpensesService(BudgetingAppContext context) // Constructor that accepts BudgetingAppContext for database operations
        {
            _context = context;
            // Initialize any necessary resources or dependencies here
        }
        public async Task Add(Expense expense)
        {

            _context.Expenses.Add(expense); // Adds the new expense to the database context
            await _context.SaveChangesAsync(); // Saves changes to the database
        }

        public async Task<IEnumerable<Expense>> GetAll()
        {
            var expenses = await _context.Expenses.ToListAsync();
            return expenses; // Returns all expenses from the database as an IEnumerable<Expense>
        }
    }
}
