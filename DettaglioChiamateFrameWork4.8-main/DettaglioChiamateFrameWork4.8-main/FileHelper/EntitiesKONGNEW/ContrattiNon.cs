using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class ContrattiNon
{
    public string IdContratto { get; set; } = null!;

    public string? CodCli { get; set; }

    public string? Denom { get; set; }

    public string? TipoContr { get; set; }

    public string? Fstato { get; set; }

    public DateTime? DataScad { get; set; }

    public DateTime? DataDecIniz { get; set; }

    public DateTime? DataScadFin { get; set; }

    public string? EsComp { get; set; }

    public DateTime? DataMov { get; set; }

    public string? MeseScad { get; set; }

    public string? AnnoScad { get; set; }

    public string? Nfatt { get; set; }

    public DateTime? DataInizio { get; set; }

    public DateTime? DataFine { get; set; }

    public bool RinnAuto { get; set; }

    public int ID { get; set; }
}
