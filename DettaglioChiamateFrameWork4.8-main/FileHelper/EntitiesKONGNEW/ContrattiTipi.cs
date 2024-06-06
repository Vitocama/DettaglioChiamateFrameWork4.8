using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class ContrattiTipi
{
    public int ID { get; set; }

    public string Codice { get; set; } = null!;

    public string? Descrizione { get; set; }

    /// <summary>
    /// True se è una connessione
    /// </summary>
    public bool? Connessione { get; set; }

    /// <summary>
    /// Se il contratto prevede dei consumi
    /// </summary>
    public bool? FlagConsumi { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }
}
