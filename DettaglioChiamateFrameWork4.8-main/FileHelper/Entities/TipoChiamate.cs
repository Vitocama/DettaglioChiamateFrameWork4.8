using System;
using System.Collections.Generic;

namespace FileHelper.Entities;

public partial class TipoChiamate
{
    public int ID { get; set; }

    public string? Tipo { get; set; }

    public string? Descrizione { get; set; }

    public string? Prefisso { get; set; }

    public int? LunghezzaCaratteri { get; set; }
}
