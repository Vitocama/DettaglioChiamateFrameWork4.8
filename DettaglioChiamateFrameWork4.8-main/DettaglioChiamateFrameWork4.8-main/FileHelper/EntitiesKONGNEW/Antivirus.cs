using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class Antivirus
{
    public int ID { get; set; }

    public string? Cliente { get; set; }

    public string? CodiceKing { get; set; }

    public string? Indirizzo { get; set; }

    public string? Cap { get; set; }

    public string? Citta { get; set; }

    public string? Pr { get; set; }

    public string? Telefono { get; set; }

    public string? Tel2 { get; set; }

    public string? Email { get; set; }

    public int? IDmarca { get; set; }

    public string? CodiceAntivirus { get; set; }

    public int? Postazioni { get; set; }

    public DateOnly? DataAcquisto { get; set; }

    public DateOnly? DataRinnovo { get; set; }

    public DateOnly? DataScadenza { get; set; }

    public double? Importo { get; set; }

    public string? Note { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }
}
