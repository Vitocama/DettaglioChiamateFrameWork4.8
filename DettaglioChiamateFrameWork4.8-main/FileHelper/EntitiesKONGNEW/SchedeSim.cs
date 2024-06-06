using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class SchedeSim
{
    public int ID { get; set; }

    public string? Puk { get; set; }

    public string? Utente { get; set; }

    public string? Imei { get; set; }

    public string? Telefono { get; set; }

    public string? Apn { get; set; }

    public string? Fornitore { get; set; }

    public string? TipoAbbonamento { get; set; }

    public string? RiferimentoOperatore { get; set; }

    public bool? InMagazzino { get; set; }

    public bool? Dismessa { get; set; }

    public bool? Attiva { get; set; }

    public DateOnly? DataAttivazione { get; set; }

    public virtual ICollection<SchedeSimFatture> SchedeSimFattures { get; set; } = new List<SchedeSimFatture>();
}
