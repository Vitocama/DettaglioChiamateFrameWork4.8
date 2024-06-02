using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class Sconti
{
    public int ID { get; set; }

    public string? Descrizione { get; set; }

    /// <summary>
    /// 0-Bonifico o Contanti 1-RID o Carta di credito
    /// </summary>
    public bool? TipoPagamento { get; set; }

    public double? ScontoPagamento { get; set; }

    /// <summary>
    /// False = non unica soluzione True=Unica Soluzione
    /// </summary>
    public bool? UnicaSoluzione { get; set; }

    public double? ScontoUnicaSoluzione { get; set; }

    public int? DurataMesi { get; set; }

    public double? ScontoDurata { get; set; }

    public double? ScontoDurata1 { get; set; }

    public double? ScontoDurata2 { get; set; }

    public double? ScontoDurata3 { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }
}
