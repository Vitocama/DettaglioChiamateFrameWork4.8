using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class ApparatiAbilitazioni
{
    public int ID { get; set; }

    public int? IDutente { get; set; }

    public virtual Utenti? IDutenteNavigation { get; set; }
}
