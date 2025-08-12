

using CQRS_lib.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_lib.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) :base(options)
    {

    }
    public DbSet<Items> Items { get; set; }
}
