using System;

namespace DFsite;

public class VeiculoUpdateDto
{
    public string Modelo {get; set;} = string.Empty;
    public string Marca {get; set;} = string.Empty;
    public string Placa {get; set;} = string.Empty;
    public int Ano {get; set;}
}
