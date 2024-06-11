using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class VoiPtotalefattura
{
    public string Idvoip { get; set; } = null!;

    public double? Totale { get; set; }

    public string? Giorno { get; set; }

    public string? Mese { get; set; }

    public string? Anno { get; set; }

    public string? Giornoultima { get; set; }

    public string? Meseultima { get; set; }

    public string? Annoultima { get; set; }

    public int ID { get; set; }
}
