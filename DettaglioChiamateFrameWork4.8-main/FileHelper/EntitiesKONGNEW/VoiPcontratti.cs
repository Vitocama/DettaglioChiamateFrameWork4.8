using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class VoiPcontratti
{
    public string IdContratto { get; set; } = null!;

    public string? CodCli { get; set; }

    public string? Nome { get; set; }

    public string? Password { get; set; }

    public string? Voip { get; set; }

    public string? Portabilita { get; set; }

    public string? Migrazione { get; set; }

    public string? Migrazioneport { get; set; }

    public DateOnly? Datainizio { get; set; }

    public DateOnly? Dataport { get; set; }

    public DateOnly? Datadisdetta { get; set; }

    public string? Tipo { get; set; }

    public string? Seriale { get; set; }

    public int? Offerta { get; set; }

    public DateOnly? Lastdata { get; set; }

    public DateOnly? Fatturazione { get; set; }

    public bool? Stato { get; set; }

    public bool? AdeguamentoIstat { get; set; }

    public double? Sconto { get; set; }
}
