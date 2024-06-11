using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class Sm
{
    public int Id { get; set; }

    public string? Numero { get; set; }

    public string? Messaggio { get; set; }

    public bool? Elaborato { get; set; }

    public string? IdSms { get; set; }

    public string? Stato { get; set; }

    public string? StatusDetail { get; set; }

    public DateTime? Data { get; set; }

    public string? TipoMessaggio { get; set; }

    public string? Codice { get; set; }

    public string? Denom { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }
}
