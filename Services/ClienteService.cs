using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace DFsite;

public class ClienteService
{
    private readonly AppDbContext _context;

    public ClienteService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Cliente>> ListarTodosAsync()
    {
        return await _context.Clientes.ToListAsync();
    }
}
