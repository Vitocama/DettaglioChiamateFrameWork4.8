using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class VoiPtipoChiamate
{
    public int ID { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Descrizione { get; set; }

    public string? Prefisso { get; set; }

    public bool? RifOfferta { get; set; }

    public bool? Fisso { get; set; }
}
