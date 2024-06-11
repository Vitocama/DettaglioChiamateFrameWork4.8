using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class Pagamento
{
    public string? IdContratto { get; set; }

    public DateTime? Data { get; set; }

    public double? Pid { get; set; }

    public string? Token { get; set; }

    public string? PaymentiId { get; set; }

    public string? PayerId { get; set; }

    public DateTime? Scadenza { get; set; }

    public double? Idpagamento { get; set; }

    public string? NumeroFattura { get; set; }

    public string? DataFattura { get; set; }
}
