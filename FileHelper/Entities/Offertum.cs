using System;
using System.Collections.Generic;

namespace FileHelper.Entities;

public partial class Offertum
{
    public int Idofferta { get; set; }

    public string Nome { get; set; } = null!;

    public int Minfisso { get; set; }

    public int Minmobile { get; set; }

    public int Scatto { get; set; }

    public double Costo { get; set; }

    public bool? AllInclusive { get; set; }

    public double? SpesaScatto { get; set; }

    public double? SpesaVfissi { get; set; }

    public double? SpesaVmobili { get; set; }
}
