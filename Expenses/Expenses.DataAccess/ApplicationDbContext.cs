using Expenses.Models;
using Microsoft.EntityFrameworkCore;

namespace Expenses.DataAccess
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ExpenseModel> ExpensesTable  {  get; set; } 
    }
}
