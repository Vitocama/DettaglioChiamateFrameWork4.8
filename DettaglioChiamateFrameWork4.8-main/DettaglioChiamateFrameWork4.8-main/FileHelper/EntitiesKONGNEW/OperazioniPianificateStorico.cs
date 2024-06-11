using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class OperazioniPianificateStorico
{
    public string? UserMan { get; set; }

    public string? Codice { get; set; }

    public string? Denominazione { get; set; }

    public string? DescrizioneOperazione { get; set; }

    public string? ProfiloAttuale { get; set; }

    public string? ProfiloFuturo { get; set; }

    public string? Contratto { get; set; }

    public bool? Concluso { get; set; }

    /// <summary>
    /// 0-Cambio Profilo 1-Disdetta contratto 2-Riattivazione dopo pagamento 3-Disattivazione moroso
    /// </summary>
    public int? TipoOperazione { get; set; }

    public bool? InvioSms { get; set; }

    public DateTime? DataOperazione { get; set; }

    public string? Telefono { get; set; }

    public DateTime? DataInizio { get; set; }

    public DateTime? DataFine { get; set; }

    public double? Importo { get; set; }

    public string? Messaggio2 { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }

    public DateTime? DataPassaggioStorico { get; set; }

    public int Id { get; set; }
}
