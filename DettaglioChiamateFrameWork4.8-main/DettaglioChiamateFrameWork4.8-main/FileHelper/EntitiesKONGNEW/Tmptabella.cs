using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class Tmptabella
{
    public string? Cf { get; set; }

    public string? Piva { get; set; }

    public string? Cognome { get; set; }

    public string? Nome { get; set; }

    public string? Sesso { get; set; }

    public string? DtNascita { get; set; }

    public string? Luogodinascita { get; set; }

    public string? Prov { get; set; }

    public string? Denominazione { get; set; }

    public string? ComuneDomicilio { get; set; }

    public string? SiglaComuneDomicilio { get; set; }

    public string IdContratto { get; set; } = null!;

    public string? CodCli { get; set; }

    public string? Datainizio { get; set; }

    public string? NumeroIniziale { get; set; }

    public string? NumeroFinale { get; set; }

    public string? Indirizzo { get; set; }

    public string? Datadisdetta { get; set; }

    public double? Costi { get; set; }
}
