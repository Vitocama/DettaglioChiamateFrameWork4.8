using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class Abilitazioni
{
    public int Id { get; set; }

    public int? Utente { get; set; }

    public string? Funzione { get; set; }

    public byte? Abilitazione { get; set; }
}
