﻿using System;
using System.Collections.Generic;

namespace FileHelper.Entities;

public partial class TargheComuni
{
    public string Provincia { get; set; } = null!;

    public string Comune { get; set; } = null!;

    public string Cap { get; set; } = null!;

    public string CodiceComune { get; set; } = null!;

    public int CodiceAuto { get; set; }
}
