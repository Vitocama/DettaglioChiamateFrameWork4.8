using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class Operazioni
{
    public int ID { get; set; }

    public string? UserMan { get; set; }

    public string? Profilo { get; set; }

    public DateOnly? Data { get; set; }

    public int? IDoperazionePianificata { get; set; }

    public virtual OperazioniPianificate? IDoperazionePianificataNavigation { get; set; }
}
