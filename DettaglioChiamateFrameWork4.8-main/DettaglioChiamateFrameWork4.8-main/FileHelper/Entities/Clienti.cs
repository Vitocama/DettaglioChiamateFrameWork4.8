using System;
using System.Collections.Generic;

namespace FileHelper.Entities;

public partial class Clienti
{
    public string CodCli { get; set; } = null!;

    public string? Societa { get; set; }

    public string? Denom { get; set; }

    public string? Ind { get; set; }

    public string? Prov { get; set; }

    public string? Loc { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public string? Telex { get; set; }

    public string? Modem { get; set; }

    public string? PreInt { get; set; }

    public string? Piva { get; set; }

    public string? Cf { get; set; }

    public bool AllegatoCf { get; set; }

    public bool PersonaFis { get; set; }

    public bool Valuta { get; set; }

    public string? CodNaz { get; set; }

    public string? DsNaz { get; set; }

    public string? Iso { get; set; }

    public string? Sesso { get; set; }

    public DateTime? DtNascita { get; set; }

    public string? LuogoNascita { get; set; }

    public string? ProvNascita { get; set; }

    public string? Note { get; set; }

    public bool FlagAnnullo { get; set; }

    public DateTime? DataUltAgg { get; set; }

    public string? CodCliFatt { get; set; }

    public bool CliPrivato { get; set; }

    public bool IvaSosp { get; set; }

    public float? Pda { get; set; }

    public float? PdaMedia { get; set; }

    public string? CodTipo { get; set; }

    public DateTime? DataValuta { get; set; }

    public string? Tel2 { get; set; }

    public string? CodTessera { get; set; }

    public string? NoteRecCrd { get; set; }

    public string? Stato { get; set; }

    public DateTime? DataInf { get; set; }

    public string? Riferim { get; set; }

    public string? Cellulare { get; set; }

    public string? Altro { get; set; }

    public bool? Flagescstat { get; set; }

    public string? Zona { get; set; }

    public DateTime? Datapconda { get; set; }

    public DateTime? Datapcona { get; set; }

    public string? Civaestero { get; set; }

    public string? UNumeroVoip { get; set; }

    public bool? AutorizzoEmail { get; set; }

    public string? CodClass { get; set; }

    public bool? FlagNoRivalsa { get; set; }

    public bool? SpesEscluso { get; set; }

    public string? AutorizzoPubbSito { get; set; }

    public string? PassWord { get; set; }

    public string? StatoModulo { get; set; }

    public string? CodCliPadre { get; set; }

    public string? UFaldone { get; set; }

    public string? OpeRespCli { get; set; }

    public string? CodLing { get; set; }

    public bool? FlgStpScad { get; set; }

    public bool? FlgBlackList { get; set; }

    public string? CodRapprLegBl { get; set; }

    public DateTime? DataInser { get; set; }

    public bool? ScollegaDaAnaCom { get; set; }

    public short? IdUteCreaz { get; set; }

    public short? IdUteUltMod { get; set; }

    public bool? FlgRiepilogativo { get; set; }

    public string? UUserNameVoip { get; set; }

    public string? UPasswordVoip { get; set; }

    public short TipoDiPubblicazione { get; set; }

    public bool? NotificaViaMail { get; set; }

    public bool? NotificaViaSms { get; set; }

    public string? PaCoduff { get; set; }

    public string? OraStdInizio { get; set; }

    public string? OraStdFine { get; set; }

    public string? OraNottInizio { get; set; }

    public string? OraNottFine { get; set; }

    public bool? FlgSplitPaymentPa { get; set; }

    public string? Cap { get; set; }

    public bool? FlgCfcedente { get; set; }

    public bool? PaNoEsigIva { get; set; }

    public bool? UEscludiScadenziario { get; set; }

    public string? StatoContab { get; set; }

    public DateTime? DataStatoContab { get; set; }

    public string? RespCredito { get; set; }

    public bool FlagEscludiFactoring { get; set; }

    public string? Sollecito { get; set; }

    public DateTime? DataSollecito { get; set; }

    public string? Nome { get; set; }

    public string? Cognome { get; set; }

    public bool? SoanaPrinc { get; set; }

    public string? Soindirizzo { get; set; }

    public string? Sonciv { get; set; }

    public string? Socap { get; set; }

    public string? Socomune { get; set; }

    public string? Soprov { get; set; }

    public string? Sonaz { get; set; }

    public string? Rfnaz { get; set; }

    public string? Rfcodice { get; set; }

    public string? Rfdenom { get; set; }

    public string? Rfnome { get; set; }

    public string? Rfcognome { get; set; }

    public string? Titolo { get; set; }

    public string? SollecitoS { get; set; }

    public DateTime? DatasollecitoS { get; set; }

    public string? B2bPortale { get; set; }

    public string? B2bPec { get; set; }

    public bool? RwflgAddViagg { get; set; }

    public short? RwnumReport { get; set; }

    public string? Rwemail { get; set; }

    public short? Fitosog { get; set; }

    public string? Email { get; set; }

    public bool? NomeCognXml { get; set; }

    public bool? FlgIndCliente { get; set; }

    public bool? UAvvocato { get; set; }

    public DateTime? UDataConsegnaAvvocato { get; set; }

    public string? UCellulareSms { get; set; }

    public bool? Bollettino2Mail { get; set; }

    public string? EmailComm { get; set; }

    public string? EmailMan { get; set; }

    public string? EmailAmm { get; set; }

    public string? EmailCred { get; set; }

    public string? PecAmm { get; set; }

    public bool? Semestrale2Mail { get; set; }

    public bool? Manutenzione2Mail { get; set; }

    public bool? Biennale2Mail { get; set; }

    public bool? RipAttRic2Mail { get; set; }

    public short? DasDestTipo { get; set; }

    public string? DasDestCodAccisa { get; set; }

    public string? DasCodUffAdm { get; set; }

    public bool? FlgForzaPartIvaErr { get; set; }

    public bool? FlgForzaCodFisErr { get; set; }

    public string? OraOrdInizioSab { get; set; }

    public string? OraOrdFineSab { get; set; }

    public string? OraStraInizioSab { get; set; }

    public string? OraStraFineSab { get; set; }

    public string? OraFestInizioSab { get; set; }

    public string? OraFestFineSab { get; set; }

    public string? OraNottInizioSab { get; set; }

    public string? OraNottFineSab { get; set; }

    public string? Rating { get; set; }

    public int? Ggritardo { get; set; }

    public string? VoceFin { get; set; }

    public string? CapoGruppo { get; set; }

    public string? CtoTratGar { get; set; }
}
