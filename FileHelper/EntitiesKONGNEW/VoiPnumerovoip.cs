using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class VoiPnumerovoip
{
    public int Id { get; set; }

    public string? IDcontratto { get; set; }

    public string? CodCli { get; set; }

    public string? Denom { get; set; }

    public string? Password { get; set; }

    public string? Numerovoip { get; set; }

    public string? Numeroportato { get; set; }

    public string? Migrazione { get; set; }

    public string? Migrazioneoperatore { get; set; }

    public DateOnly? Datainizio { get; set; }

    public DateOnly? Dataport { get; set; }

    public DateOnly? Datafine { get; set; }

    public bool? Stato { get; set; }

    public int? IDofferta { get; set; }

    public string? Tipo { get; set; }

    public string? Seriale { get; set; }

    public DateOnly? DataUltimaFatturazione { get; set; }

    public string? Note { get; set; }

    public bool? Cancellato { get; set; }
}
