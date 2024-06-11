using System;
using System.Collections.Generic;

namespace FileHelper.EntitiesKONGNEW;

public partial class Utenti
{
    public int ID { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public bool? Administrator { get; set; }

    public byte? Esercizio { get; set; }

    public DateOnly? UltimoCambioPassword { get; set; }

    public bool? PasswordSenzaScadenza { get; set; }

    public bool? IsActive { get; set; }

    public int? LivelloPassword { get; set; }

    public virtual ICollection<ApparatiAbilitazioni> ApparatiAbilitazionis { get; set; } = new List<ApparatiAbilitazioni>();

    public virtual ICollection<UtentiAccesso> UtentiAccessos { get; set; } = new List<UtentiAccesso>();

    public virtual ICollection<UtentiPassword> UtentiPasswords { get; set; } = new List<UtentiPassword>();
}
