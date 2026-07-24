using System;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DFsite;

public class VeiculoService
{
    private readonly AppDbContext _context;

    public VeiculoService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<VeiculoResponseDto>> ListarVeiculosAsync()
    {
        var veiculos = await _context.Veiculos.ToListAsync();

        return veiculos.Select(c => new VeiculoResponseDto
        {
            Modelo = c.Modelo,
            Marca = c.Marca,
            Placa = c.Placa,
            Ano = c.Ano,
            ClienteId = c.ClienteId
        }).ToList();
    }

    public async Task<VeiculoResponseDto?> BuscarVeiculoPorIdAsync(int Id)
    {
        var veiculo = await _context.Veiculos.FindAsync(Id);

        if (veiculo == null) return null;

        return new VeiculoResponseDto
        {
            Modelo = veiculo.Modelo,
            Marca = veiculo.Marca,
            Placa = veiculo.Placa,
            Ano = veiculo.Ano,
            ClienteId = veiculo.ClienteId
        };
    }

    public async Task<VeiculoCreateDto> CriarVeiculoAsync(VeiculoCreateDto dto)
    {
        
    }
}
