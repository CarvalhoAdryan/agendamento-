using System;

namespace DFsite;

public class ClienteUpdateDto
{
    public string Nome {get; set; } = string.Empty;
    public string? Email {get; set; }
    public string Telefone {get; set; } = string.Empty;
}
