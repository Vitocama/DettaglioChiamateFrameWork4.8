using System;
using System.Collections.Generic;

namespace FileHelper.Entities;

public partial class DettaglioStorico
{
    public int Id { get; set; }

    public string? Orachiamata { get; set; }

    public DateOnly? Data { get; set; }

    public string? Chiamante { get; set; }

    public string? Prefisso { get; set; }

    public string? Chiamato { get; set; }

    public string? Durata { get; set; }

    public double? Importo { get; set; }

    public double? Spesa { get; set; }

    public string? Tipo { get; set; }

    public string? DataPassaggioStorico { get; set; }

    public int? IdOperatore { get; set; }
}
