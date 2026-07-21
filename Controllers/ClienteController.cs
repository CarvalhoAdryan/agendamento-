using System;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;

namespace DFsite;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly ClienteService _service;

    public ClienteController(ClienteService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> ListarTodos()
    {
        var clientes = await _service.ListarTodosAsync(); 
        return Ok(clientes);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> BuscarPorId(int id)
    {
        var cliente = await _service.BuscarPorIdAsync(id);

        if (cliente == null) 
            return NotFound($"Cliente com o id {id} não encontrado!");
        
        return Ok(cliente);
    }
}
