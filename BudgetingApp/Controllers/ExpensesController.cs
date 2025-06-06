using BudgetingApp.Data;
using BudgetingApp.Data.Service;
using BudgetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BudgetingApp.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly IExpensesService _expensesService;
        public ExpensesController(IExpensesService expensesService)
        {
            _expensesService = expensesService;
        }
        public async Task<IActionResult> Index() // Displays a list of expenses
        {
            var expenses = await _expensesService.GetAll(); // Fetches all expenses from the database
            return View(expenses); // Returns the view with the list of expenses
        }
        public IActionResult Create() 
        {
            return View(); // Returns the view for creating a new expense
        }
        [HttpPost] // Indicates that this action method responds to HTTP POST requests
        public async Task<IActionResult> Create(Expense expense)
        {
            if (ModelState.IsValid) 
            {
                await _expensesService.Add(expense); // Adds the new expense to the database if the model state is valid


                return RedirectToAction("Index"); // Redirects to the Index action to display the updated list of expenses
            }
            return View(expense); // Returns the view for creating a new expense
        }
    }
}
