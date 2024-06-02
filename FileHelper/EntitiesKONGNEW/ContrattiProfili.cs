using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class ContrattiProfili
{
    public int ID { get; set; }

    public string? Codice { get; set; }

    public string? Descrizione { get; set; }

    public string? Profilo { get; set; }

    public double? PrezzoAnnuale { get; set; }

    public double? PrezzoAnnualeSo { get; set; }

    public double? Attivazione { get; set; }

    public double? AttivazioneSo { get; set; }

    public bool? Ricaricabile { get; set; }

    public bool? IsNoleggio { get; set; }

    public string? CodIva { get; set; }

    public string? ContoRicavo { get; set; }

    public bool? Attivo { get; set; }

    public int? IdUtente { get; set; }

    public DateTime? DataModifica { get; set; }
}
