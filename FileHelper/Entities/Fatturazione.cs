using System;
using System.Collections.Generic;

namespace FileHelper.Entities;

public partial class Fatturazione
{
    public int Id { get; set; }

    public string Contratto { get; set; } = null!;

    public string? Nome { get; set; }

    public string? Voip { get; set; }

    public string? Portabilita { get; set; }

    public int? Offerta { get; set; }

    public DateOnly? Fatturazione1 { get; set; }

    public DateOnly? Data { get; set; }

    public string? Tipo { get; set; }

    public string? CodCli { get; set; }
}
