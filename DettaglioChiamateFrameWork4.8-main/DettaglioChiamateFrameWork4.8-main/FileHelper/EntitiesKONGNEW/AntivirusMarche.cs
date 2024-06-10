using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class AntivirusMarche
{
    public int ID { get; set; }

    public string Antivirus { get; set; } = null!;

    public double? P1 { get; set; }

    public double? P2 { get; set; }

    public double? P3 { get; set; }

    public double? P4 { get; set; }

    public double? P5 { get; set; }

    public double? P6 { get; set; }

    public double? P7 { get; set; }

    public double? P8 { get; set; }

    public double? P9 { get; set; }

    public double? P10 { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }
}
