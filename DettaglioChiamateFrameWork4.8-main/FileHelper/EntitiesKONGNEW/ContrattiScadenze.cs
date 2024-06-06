using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class ContrattiScadenze
{
    public int IDscadenza { get; set; }

    public string? IDcontratto { get; set; }

    public string? CodArt { get; set; }

    public string? Descrizione { get; set; }

    public DateOnly? DataInizio { get; set; }

    public DateOnly? DataFine { get; set; }

    public double? ImportoRata { get; set; }

    public bool? RigaManuale { get; set; }

    public string? NumeroFattura { get; set; }

    public DateOnly? DataFattura { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }

    public virtual ContrattiOld? IDcontrattoNavigation { get; set; }
}
