using System;
using System.Collections.Generic;

namespace FileHelper.Entities;

public partial class DettaglioChiamate
{
    public string? IdContratto { get; set; }

    public string? Orachiamata { get; set; }

    public DateOnly? Data { get; set; }

    public string? Chiamante { get; set; }

    public string? Prefisso { get; set; }

    public string? Chiamato { get; set; }

    public string? Durata { get; set; }

    public string? Tipo { get; set; }

    public string? Nome { get; set; }

    public string? CodCli { get; set; }

    public int ID { get; set; }
}
