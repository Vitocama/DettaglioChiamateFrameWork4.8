using System;
using System.Collections.Generic;

namespace FileHelper.Entities;

public partial class ConteggioSecondo
{
    public string Contratto { get; set; } = null!;

    public int? SommaDeiSecondi { get; set; }

    public string? Tipo { get; set; }
}
