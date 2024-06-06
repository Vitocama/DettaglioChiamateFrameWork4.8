using System;
using System.Collections.Generic;

namespace FileHelper.Entities;

public partial class TmpfatturazioneClone
{
    public string Contratto { get; set; } = null!;

    public string? Nome { get; set; }

    public string? CodCli { get; set; }

    public string? Telefono { get; set; }

    public int? Offerta { get; set; }

    public string? Tipo { get; set; }

    public string? Descrizione { get; set; }

    public int? Secondi { get; set; }

    public int? SecondiAddebitabili { get; set; }

    public int? Nchiamate { get; set; }

    public int? NchiamateAddebitabili { get; set; }

    public double? Scatto { get; set; }

    public double? Spesa { get; set; }
}
