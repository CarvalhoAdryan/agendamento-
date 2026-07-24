using System;
using System.Runtime.CompilerServices;

namespace DFsite;

public class VeiculoCreateDto
{
    public string Modelo {get; set;} = string.Empty;
    public string Marca {get; set;} = string.Empty;
    public string Placa {get; set;} = string.Empty;
    public int Id {get; set;}

    public int Ano {get; set;}
    public int ClienteId {get; set;}

}
