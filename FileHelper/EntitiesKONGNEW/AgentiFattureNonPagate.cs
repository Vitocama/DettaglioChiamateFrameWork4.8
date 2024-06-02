using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class AgentiFattureNonPagate
{
    public string? Anno { get; set; }

    public string? NumDoc { get; set; }

    public DateTime? DataDoc { get; set; }

    public string? Cliente { get; set; }

    public string? Denom { get; set; }

    public string? Agente { get; set; }

    public string? Descrizione { get; set; }

    public float? PercProv { get; set; }

    public double? TotMerce { get; set; }

    public double? TotDocum { get; set; }

    public string? CodDoc { get; set; }

    public short? Nriga { get; set; }

    public double? Importo { get; set; }

    public short? NumRiga { get; set; }

    public string? Partita { get; set; }

    public DateTime? DataScad { get; set; }

    public double? ImportoScadenza { get; set; }

    public double? Incassato { get; set; }

    public string? CodArt { get; set; }

    public double? Qta { get; set; }

    public double? ImpUni { get; set; }

    public double? ValoreMov { get; set; }

    public double? Provvigioni { get; set; }

    public int ID { get; set; }
}
