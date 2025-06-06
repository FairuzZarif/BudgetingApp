using BudgetingApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace BudgetingApp.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly BudgetingAppContext _context;
        public ExpensesController(BudgetingAppContext context)
        {
            _context = context;
        }
        public IActionResult Index() // Displays a list of expenses
        {
            var expenses = _context.Expenses.ToList(); // Fetches all expenses from the database
            return View(expenses); // Returns the view with the list of expenses
        }
        public IActionResult Create() 
        {
            return View(); // Returns the view for creating a new expense
        }
    }
}
