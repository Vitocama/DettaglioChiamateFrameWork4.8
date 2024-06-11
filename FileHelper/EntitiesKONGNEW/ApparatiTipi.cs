using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class ApparatiTipi
{
    public int ID { get; set; }

    public string? Descrizione { get; set; }

    public virtual ICollection<Apparati> Apparatis { get; set; } = new List<Apparati>();
}
