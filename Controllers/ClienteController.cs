using System;
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
}
