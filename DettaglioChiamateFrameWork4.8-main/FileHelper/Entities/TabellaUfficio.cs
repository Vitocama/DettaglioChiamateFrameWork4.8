using System;
using System.Collections.Generic;

namespace FileHelper.Entities;

public partial class TabellaUfficio
{
    public string Id { get; set; } = null!;

    public double? Spesa { get; set; }

    public string IdContratto { get; set; } = null!;

    public string? SigliaComuneDomicilio { get; set; }

    public string? ComuneDiComicilio { get; set; }

    public string? CodiceFiscale { get; set; }

    public string? Datadinascita { get; set; }

    public string? Luogodinascita { get; set; }

    public string? Provinciadinascita { get; set; }

    public string? Nome { get; set; }

    public string? Cognome { get; set; }

    public string? Disdetta { get; set; }

    public string? Denom { get; set; }

    public string? Sesso { get; set; }

    public string? Datainizio { get; set; }

    public string? Indirizzo { get; set; }

    public string CodiceComune { get; set; } = null!;

    public string? Piva { get; set; }
}
