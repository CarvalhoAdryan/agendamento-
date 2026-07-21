using System;

namespace DFsite;

public class ClienteCreateDTO
{
    public string Nome {get; set; } = string.Empty;
    public string? Email {get; set; }
    public string Telefone {get; set; } = string.Empty;
}

