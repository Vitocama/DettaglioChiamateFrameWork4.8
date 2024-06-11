using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class Ricaricabili
{
    public string? IdContratto { get; set; }

    public string? CodCli { get; set; }

    public string? UserName { get; set; }

    public double? Attivo { get; set; }

    public string? TipoContratto { get; set; }

    public double? Ricarica { get; set; }

    public DateTime? DataContratto { get; set; }

    public DateTime? Scadenza { get; set; }
}
