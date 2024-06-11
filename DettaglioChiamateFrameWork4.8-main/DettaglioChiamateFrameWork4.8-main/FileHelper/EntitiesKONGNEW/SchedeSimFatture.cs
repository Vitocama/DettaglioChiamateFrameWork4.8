using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class SchedeSimFatture
{
    public int ID { get; set; }

    public int? IDscheda { get; set; }

    public string? NumeroFattura { get; set; }

    public DateOnly? DataFattura { get; set; }

    public double? Importo { get; set; }

    public string? Periodo { get; set; }

    public virtual SchedeSim? IDschedaNavigation { get; set; }
}
