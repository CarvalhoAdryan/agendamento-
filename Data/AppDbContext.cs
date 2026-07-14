using System;
using Microsoft.EntityFrameworkCore;

namespace DFsite;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    public DbSet<Cliente> Clientes {get; set;}
}
