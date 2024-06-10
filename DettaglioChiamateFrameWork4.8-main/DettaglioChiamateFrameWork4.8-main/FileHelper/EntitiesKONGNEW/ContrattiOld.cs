using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class ContrattiOld
{
    public string IDcontratto { get; set; } = null!;

    public string? Descrizione { get; set; }

    public string? CodCli { get; set; }

    public string? Denom { get; set; }

    public int? IDtipo { get; set; }

    public string? Stato { get; set; }

    public string? CodPag { get; set; }

    public string? CodBanca { get; set; }

    public string? CodDoc { get; set; }

    public DateOnly? DataStipula { get; set; }

    public DateOnly? DataInizio { get; set; }

    public DateOnly? DataFine { get; set; }

    public short? DurataMesi { get; set; }

    public DateOnly? DataDisdetta { get; set; }

    public DateOnly? DataSospensione { get; set; }

    public DateOnly? FineSospensione { get; set; }

    public bool? RinnovoAutomatico { get; set; }

    public double? Attivazione { get; set; }

    public bool? AttivazioneGiaFatturata { get; set; }

    public double? ScontoPercentuale { get; set; }

    public double? Sconto1 { get; set; }

    public double? Sconto2 { get; set; }

    public string? DescrizioneSconto { get; set; }

    public int? TipoFatturazione { get; set; }

    public string? Note { get; set; }

    public string? NoteInterne { get; set; }

    public string? UserName { get; set; }

    public bool? Ricaricabile { get; set; }

    public DateOnly? DataInizioFatturazione { get; set; }

    public DateOnly? DataFineFatturazione { get; set; }

    public bool? FlagConsumi { get; set; }

    public DateOnly? DataUltimaFatturazioneConsumi { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }

    public virtual ICollection<ContrattiArticoli> ContrattiArticolis { get; set; } = new List<ContrattiArticoli>();

    public virtual ContrattiRateOld? ContrattiRateOld { get; set; }

    public virtual ICollection<ContrattiScadenze> ContrattiScadenzes { get; set; } = new List<ContrattiScadenze>();
}
