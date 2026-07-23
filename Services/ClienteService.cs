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

    public async Task<List<ClienteResponseDto>> ListarTodosAsync()
    {
        var cliente =  await _context.Clientes.ToListAsync();

        return cliente.Select(c => new ClienteResponseDto
        {
            Id = c.Id,
            Nome = c.Nome,
            Email = c.Email,
            Telefone = c.Telefone,
            CriadoEm = c.CriadoEm
        }).ToList();


    }

    public async Task<ClienteResponseDto?> BuscarPorIdAsync(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);

        if (cliente == null) return null;

        return new ClienteResponseDto
        {
          Id = cliente.Id,
          Nome = cliente.Nome,
          Email = cliente.Email,
          Telefone = cliente.Telefone,
          CriadoEm = cliente.CriadoEm
        };
    }

    public async Task<ClienteResponseDto> CriarAsync(ClienteCreateDTO dto)
    {
        var cliente = new Cliente
        {
            Nome = dto.Nome,
            Email = dto.Email,
            Telefone = dto.Telefone
        };

        await _context.Clientes.AddAsync(cliente);
        await _context.SaveChangesAsync();

        return new ClienteResponseDto
        {
            Id = cliente.Id,
            Nome = cliente.Nome,
            Email = cliente.Email,
            Telefone = cliente.Telefone,
            CriadoEm = cliente.CriadoEm
        };
    
    }

    public async Task<ClienteResponseDto?> AtualizarAsync(int Id, ClienteUpdateDto dto)
    {
        var cliente = await _context.Clientes.FindAsync(Id);

        if (cliente == null) return null;

        cliente.Nome = dto.Nome;
        cliente.Email = dto.Email;
        cliente.Telefone = dto.Telefone;

        await _context.SaveChangesAsync();

        return new ClienteResponseDto
        {
            Id = cliente.Id,
            Nome = cliente.Nome,
            Email = cliente.Email,
            Telefone = cliente.Telefone,
            CriadoEm = cliente.CriadoEm
        };
    }

    public async Task<bool> RemoverAsync(int Id)
    {
        var cliente = await _context.Clientes.FindAsync(Id);

        if (cliente == null) return false;

        _context.Clientes.Remove(cliente);
        await _context.SaveChangesAsync();

        return true;
    }
}
