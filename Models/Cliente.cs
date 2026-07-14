using System;
using System.ComponentModel.DataAnnotations;

namespace DFsite;

public class Cliente
{
    public int Id {get; set;}

    [Required]
    [MaxLength(150)]
    public string Nome {get; set;} = string.Empty;

    [Required]
    [MaxLength(20)]
    public string Telefone {get; set;} = string.Empty;

    [MaxLength(150)]
    public string? Email {get; set;}
    
    public DateTime CriadoEm {get; set;} = DateTime.UtcNow;

    //public List<Veiculo> Veiculos {get; set;} = new();
}
