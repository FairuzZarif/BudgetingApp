using BudgetingApp.Data;
using BudgetingApp.Models;
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
        [HttpPost] // Indicates that this action method responds to HTTP POST requests
        public IActionResult Create(Expense expense)
        {
            if (ModelState.IsValid) 
            {
                _context.Expenses.Add(expense); // Adds the new expense to the database context
                _context.SaveChanges(); // Saves changes to the database

                return RedirectToAction("Index"); // Redirects to the Index action to display the updated list of expenses
            }
            return View(expense); // Returns the view for creating a new expense
        }
    }
}
