using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class ContrattiPerKong
{
    public string IdContratto { get; set; } = null!;

    public string? TipoContr { get; set; }

    public string? Fstato { get; set; }

    public short? DurMesi { get; set; }

    public bool RinnAuto { get; set; }

    public string? CodPag { get; set; }

    public string? CodBanca { get; set; }

    public string? Note { get; set; }

    public double? TotContr { get; set; }

    public DateTime? DataDec { get; set; }

    public DateTime? DataScad { get; set; }

    public string? CodCli { get; set; }

    public DateTime? DataStip { get; set; }

    public short? AnniRinn { get; set; }

    public DateTime? DataDisdetta { get; set; }

    public DateTime? DataInSosp { get; set; }
}
