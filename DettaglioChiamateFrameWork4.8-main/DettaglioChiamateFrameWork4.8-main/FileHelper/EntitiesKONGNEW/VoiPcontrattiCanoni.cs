using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class VoiPcontrattiCanoni
{
    public int ID { get; set; }

    public string? IdContratto { get; set; }

    public double? CanoneAnnuo { get; set; }

    public int? MesiFatturazione { get; set; }

    public bool? Attivo { get; set; }
}
