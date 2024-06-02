using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class ContrattiRateOld
{
    public string IDcontratto { get; set; } = null!;

    public short? NMesi1 { get; set; }

    public bool? Rata1 { get; set; }

    public double? Importo1 { get; set; }

    public short? NMesi2 { get; set; }

    public bool? Rata2 { get; set; }

    public double? Importo2 { get; set; }

    public short? NMesi3 { get; set; }

    public bool? Rata3 { get; set; }

    public double? Importo3 { get; set; }

    public short? NMesi4 { get; set; }

    public bool? Rata4 { get; set; }

    public double? Importo4 { get; set; }

    public short? NMesi5 { get; set; }

    public bool? Rata5 { get; set; }

    public double? Importo5 { get; set; }

    public short? NMesi6 { get; set; }

    public bool? Rata6 { get; set; }

    public double? Importo6 { get; set; }

    public short? NMesi7 { get; set; }

    public bool? Rata7 { get; set; }

    public double? Importo7 { get; set; }

    public short? NMesi8 { get; set; }

    public bool? Rata8 { get; set; }

    public double? Importo8 { get; set; }

    public short? NMesi9 { get; set; }

    public bool? Rata9 { get; set; }

    public double? Importo9 { get; set; }

    public short? NMesi10 { get; set; }

    public bool? Rata10 { get; set; }

    public double? Importo10 { get; set; }

    public short? NMesi11 { get; set; }

    public bool? Rata11 { get; set; }

    public double? Importo11 { get; set; }

    public short? NMesi12 { get; set; }

    public bool? Rata12 { get; set; }

    public double? Importo12 { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }

    public virtual ContrattiOld IDcontrattoNavigation { get; set; } = null!;
}
