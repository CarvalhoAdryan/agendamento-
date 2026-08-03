using System;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;

namespace DFsite;

[ApiController]
[Route("api/[Controller]")]
public class VeiculoController : ControllerBase
{
    private readonly VeiculoService _service;

    public VeiculoController(VeiculoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> ListarVeiculos()
    {
        var veiculo = await _service.ListarVeiculosAsync(); 

        return Ok(veiculo);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> BuscarVeiculoPorId(int Id)
    {
        var veiculo = await _service.BuscarVeiculoPorIdAsync(Id);
        
        if(veiculo == null)
        {
            return NotFound($"Veiculo com id {Id} não encontrado!");
        }

        return Ok(veiculo);
    }

    [HttpPost]
    public async Task<IActionResult> CriarVeiculo([FromBody] VeiculoCreateDto dto)
    {
        var veiculoCriado = await _service.CriarVeiculoAsync(dto);

        if(veiculoCriado == null){
            return BadRequest($"Cliente com Id {dto.ClienteId} não encontrado. Não foi possivel criar o veiculo!");
        }
        return CreatedAtAction(nameof(BuscarVeiculoPorId), new {id = veiculoCriado.ClienteId }, veiculoCriado);
    }
}
