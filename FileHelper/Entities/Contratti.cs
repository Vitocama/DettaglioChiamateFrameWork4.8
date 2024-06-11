using System;
using System.Collections.Generic;

namespace FileHelper.Entities;

public partial class Contratti
{
    public string IdContratto { get; set; } = null!;

    public string? CodCli { get; set; }

    public string? CodLu { get; set; }

    public string? TipoContr { get; set; }

    public string? Fstato { get; set; }

    public DateTime? DataDec { get; set; }

    public DateTime? DataScad { get; set; }

    public short? DurMesi { get; set; }

    public bool RinnAuto { get; set; }

    public short? AnniRinn { get; set; }

    public string? CodPag { get; set; }

    public string? CodBanca { get; set; }

    public string? Note { get; set; }

    public double? TotContr { get; set; }

    public bool DaFat { get; set; }

    public double? TotIvaContr { get; set; }

    public DateTime? DataStip { get; set; }

    public string? DivDest { get; set; }

    public double? NrKilometri { get; set; }

    public double? CostoKm { get; set; }

    public double? DirChiamata { get; set; }

    public DateTime? DataInser { get; set; }

    public DateTime? DataDecIniz { get; set; }

    public DateTime? DataScadFin { get; set; }

    public bool? FlagManGrat { get; set; }

    public DateTime? DataDisdetta { get; set; }

    public DateTime? DataInSosp { get; set; }

    public DateTime? DataFinSosp { get; set; }

    public bool? FlagVoceFatt { get; set; }

    public DateTime? DataChius { get; set; }

    public bool? FlagRateo { get; set; }

    public bool? FlagAmmSuContr { get; set; }

    public string? CodAmmSuContr { get; set; }

    public DateTime? DataDecManu { get; set; }

    public string? Zona { get; set; }

    public bool? FlagRinegoz { get; set; }

    public string? ContrStatusCode { get; set; }

    public bool? FlagChFermoImp { get; set; }

    public bool? FlagAssEnteIsp { get; set; }

    public string? GruAum { get; set; }

    public bool? FlagIntr { get; set; }

    public bool? FlagRepCompl { get; set; }

    public bool? FlagFattRich { get; set; }

    public string? UUserName { get; set; }

    public string? UTecnico { get; set; }

    public bool? FlagSim { get; set; }

    public string? UIppubblicoCpe { get; set; }

    public string? OraStdInizio { get; set; }

    public string? OraStdFine { get; set; }

    public string? OraNottInizio { get; set; }

    public string? OraNottFine { get; set; }

    public string? UCodiceMigrazione { get; set; }

    public string? UValoreCpe { get; set; }

    public string? UUbicazione { get; set; }

    public string? UGps { get; set; }

    public string? USsid { get; set; }

    public string? PaIddoc { get; set; }

    public DateTime? PaData { get; set; }

    public string? PaCup { get; set; }

    public string? PaCig { get; set; }

    public bool? URicaricabile { get; set; }

    public string? StatoComm { get; set; }

    public DateTime? DataStatoComm { get; set; }

    public string? OraOrdInizioSab { get; set; }

    public string? OraOrdFineSab { get; set; }

    public string? OraStraInizioSab { get; set; }

    public string? OraStraFineSab { get; set; }

    public string? OraFestInizioSab { get; set; }

    public string? OraFestFineSab { get; set; }

    public string? OraNottInizioSab { get; set; }

    public string? OraNottFineSab { get; set; }

    public string? ContrattoRinegoz { get; set; }

    public string? Commessa { get; set; }

    public string? XmlCommessa { get; set; }

    public string? UNote { get; set; }
}
