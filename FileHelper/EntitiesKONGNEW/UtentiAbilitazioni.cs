using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class UtentiAbilitazioni
{
    public int Id { get; set; }

    public int? IDutente { get; set; }

    public int? IDfunzione { get; set; }

    public byte? Abilitazione { get; set; }
}
