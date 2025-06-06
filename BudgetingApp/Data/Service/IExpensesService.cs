using BudgetingApp.Models;

namespace BudgetingApp.Data.Service
{
    public interface IExpensesService
    {
        Task<IEnumerable<Expense>> GetAll(); // Fetches all expenses asynchronously
        Task Add(Expense expense); // Adds a new expense asynchronously
        IQueryable GetChartData();
    }
}
