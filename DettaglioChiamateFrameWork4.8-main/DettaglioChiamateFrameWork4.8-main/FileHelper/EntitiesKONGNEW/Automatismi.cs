using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class Automatismi
{
    public int Id { get; set; }

    public string? NomeSms { get; set; }

    public string? NomeLog { get; set; }

    public string? Psenza { get; set; }

    public string? Sospeso { get; set; }

    public string? MsgRitardo { get; set; }

    public string? MsgContratto { get; set; }

    public string? ContrattoScaduto { get; set; }

    public string? UserSms { get; set; }

    public string? PwdSms { get; set; }

    public string? UserSmsapi { get; set; }

    public string? PwdSmsapi { get; set; }

    public int? GiorniInProva { get; set; }

    public double? CostoSms { get; set; }

    public string? DisdettaSuUsermanKing { get; set; }

    public string? GetAllUsername { get; set; }

    public string? GetProfileUsername { get; set; }

    public string? SetProfileUsername { get; set; }

    public string? IndirizzoServerSmtp { get; set; }

    public string? NomeUtenteSmtp { get; set; }

    public string? PasswordSmtp { get; set; }

    public bool? Tlssmtp { get; set; }

    public int? Porta { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }

    public string? CodIvaSpesePostali { get; set; }

    public bool? ContrattiSuKong { get; set; }

    public string? RicaricabiliServer { get; set; }

    public string? RicaricabiliDatabase { get; set; }

    public string? RicaricabiliUser { get; set; }

    public string? RicaricabiliPassword { get; set; }

    public string? CodIva { get; set; }

    public string? ContoRicavo { get; set; }

    public string? AziendaKing { get; set; }
}
