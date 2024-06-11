using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class ContrattiArticoli
{
    public string? CodArt { get; set; }

    public string? Descrizione { get; set; }

    public string? IDcontratto { get; set; }

    public double? Qta { get; set; }

    public double? Prezzo { get; set; }

    public double? Importo { get; set; }

    public string? Misura { get; set; }

    public double? PrezzoAnnuale { get; set; }

    public double? PrezzoAnnualeSo { get; set; }

    public double? Attivazione { get; set; }

    public double? AttivazioneSo { get; set; }

    public bool? Ricaricabile { get; set; }

    public bool? ISnoleggio { get; set; }

    public string? CodIva { get; set; }

    public string? ContoRicavo { get; set; }

    public bool? ArticoloKing { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }

    public int Id { get; set; }

    public virtual ContrattiOld? IDcontrattoNavigation { get; set; }
}
