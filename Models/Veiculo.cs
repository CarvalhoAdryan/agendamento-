using System;
using System.ComponentModel.DataAnnotations;

namespace DFsite;

public class Veiculo
{
    public int Id {get; set;}

    [Required]
    [MaxLength(100)]
    public string Modelo {get; set;} = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Marca {get; set;} = string.Empty;

    [Required]
    [MaxLength(10)]
    public string Placa {get; set;} = string.Empty;

    public int Ano {get; set;}

    public int ClienteId {get; set;}

    public Cliente Cliente {get; set;} = null!;
}
