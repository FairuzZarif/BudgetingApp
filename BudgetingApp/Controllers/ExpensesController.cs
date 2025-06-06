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
        public IActionResult Index()
        {
            return View();
        }
    }
}
