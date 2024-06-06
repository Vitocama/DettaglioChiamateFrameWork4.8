using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class ContrattiTipiFatturazione
{
    public int ID { get; set; }

    public string? Descrizione { get; set; }

    public int? NumeroRate { get; set; }

    public int? Mesi { get; set; }

    public bool? Posticipata { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }
}
