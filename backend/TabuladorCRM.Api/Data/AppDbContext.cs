using Microsoft.EntityFrameworkCore;
using TabuladorCRM.Api.Models;

namespace TabuladorCRM.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes => Set<Cliente>();
}