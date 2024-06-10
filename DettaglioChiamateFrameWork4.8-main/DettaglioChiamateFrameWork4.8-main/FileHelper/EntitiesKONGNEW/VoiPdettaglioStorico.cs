using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class VoiPdettaglioStorico
{
    public string? Orachiamata { get; set; }

    public DateOnly? Data { get; set; }

    public string? Chiamante { get; set; }

    public string? Prefisso { get; set; }

    public string? Chiamato { get; set; }

    public string? Durata { get; set; }

    public double? Importo { get; set; }

    public double? Spesa { get; set; }

    public string? Tipo { get; set; }

    public int? Ntipo { get; set; }

    public int? DurataTime { get; set; }

    public DateOnly? DataPassaggioStorico { get; set; }

    public int? IDutente { get; set; }

    public int ID { get; set; }
}
