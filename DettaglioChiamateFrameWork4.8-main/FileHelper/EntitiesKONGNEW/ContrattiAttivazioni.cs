using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class ContrattiAttivazioni
{
    public int ID { get; set; }

    public string? Descrizione { get; set; }

    public string? IdContratto { get; set; }

    public double? Importo { get; set; }

    public bool? Ricorrente { get; set; }

    public bool? SuPrimaRata { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }
}
