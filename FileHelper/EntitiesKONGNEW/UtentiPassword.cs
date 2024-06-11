using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class UtentiPassword
{
    public int ID { get; set; }

    public int? IDutente { get; set; }

    public string? Password { get; set; }

    public DateOnly? DataPassword { get; set; }

    public virtual Utenti? IDutenteNavigation { get; set; }
}
