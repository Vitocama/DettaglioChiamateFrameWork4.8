using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class ArticoliProvvigioni
{
    public string CodArt { get; set; } = null!;

    public string? Descrizione { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }
}
