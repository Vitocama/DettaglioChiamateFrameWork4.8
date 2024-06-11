using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class UtentiAccesso
{
    public int IDaccesso { get; set; }

    public int? IDutente { get; set; }

    public DateTime? DataAccesso { get; set; }

    public virtual Utenti? IDutenteNavigation { get; set; }
}
