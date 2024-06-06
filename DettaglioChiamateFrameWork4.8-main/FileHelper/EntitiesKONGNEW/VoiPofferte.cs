using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class VoiPofferte
{
    public int Idofferta { get; set; }

    public string? Descrizione { get; set; }

    public int? Minfisso { get; set; }

    public int? Minmobile { get; set; }

    public bool? Scatto { get; set; }

    public double? CanoneMensile { get; set; }

    public bool? AllInclusive { get; set; }

    public double? CostoScatto { get; set; }

    public double? CostoVfissi { get; set; }

    public double? CostoVmobili { get; set; }

    public string? Note { get; set; }
}
