using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class Apparati
{
    public int ID { get; set; }

    public string? Descrizione { get; set; }

    public string? Note { get; set; }

    public string? Apparato { get; set; }

    public string? LuogoApparato { get; set; }

    public string? IndirizzoIp { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public DateOnly? DataInstallazione { get; set; }

    public int Tipo { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataModifica { get; set; }

    public virtual ApparatiTipi TipoNavigation { get; set; } = null!;
}
