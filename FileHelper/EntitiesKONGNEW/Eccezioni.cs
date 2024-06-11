using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class Eccezioni
{
    public string? UserMan { get; set; }

    public string? Codice { get; set; }

    public string? Denominazione { get; set; }

    public string? DescrizioneOperazione { get; set; }

    public string? ProfiloAttuale { get; set; }

    public string? ProfiloFuturo { get; set; }

    public DateTime? Data { get; set; }

    public string? Contratto { get; set; }

    public bool? ProcessatoMsg { get; set; }

    public bool? Concluso { get; set; }

    public int? TipoOperazione { get; set; }

    public bool? InvioSms { get; set; }

    public DateTime? DataOperazione { get; set; }

    public string? Telefono { get; set; }

    public DateTime? Data1 { get; set; }

    public DateTime? Data2 { get; set; }

    public string? Utente { get; set; }

    public double? Importo { get; set; }

    public int Id { get; set; }
}
