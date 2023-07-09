using Expense_tracker.Entities;
using Microsoft.EntityFrameworkCore;

namespace Expense_tracker.Context;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions options):base(options)
    {

    }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Category> Categories { get; set; }
}