using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class PartiteAperte
{
    public DateTime? DataDoc { get; set; }

    public DateTime? DataScad { get; set; }

    public string? Codice { get; set; }

    public string? Denom { get; set; }

    public string? Partita { get; set; }

    public double? Importo { get; set; }

    public double? Incassato { get; set; }

    public double? Avere { get; set; }

    public double? Dare { get; set; }

    public double? Saldo { get; set; }

    public int Id { get; set; }
}
