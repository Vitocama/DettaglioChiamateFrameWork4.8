using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class Agendum
{
    public string? Titolo { get; set; }

    public bool? Interno { get; set; }

    public string? Codice { get; set; }

    public string? Denom { get; set; }

    public string? GeneratoDa { get; set; }

    public string? Descrizione { get; set; }

    public DateTime? DataInserimento { get; set; }

    public DateTime? DataInizio { get; set; }

    public DateTime? DataFine { get; set; }

    public bool? Concluso { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }

    public int Id { get; set; }
}
