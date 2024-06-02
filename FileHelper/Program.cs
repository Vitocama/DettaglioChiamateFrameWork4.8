using FileHelper.EntitiesKONGNEW;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FileHelpers;

namespace FileHelper.Entities
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (KongnewContext context = new KongnewContext())
            {
                // Recupera la lista di tutte le righe di VoiPufficio dal database
                List<VoiPufficio> uffici = context.VoiPufficios.ToList();

                // Converte la lista di VoiPufficio in una lista di UfficioFILE
                var ufficioFileList = uffici.Select(u => new UfficioFILE
                {
                    Tiporecord = u.Tiporecord,
                    Cf = u.Cf,
                    Cognome = u.Cognome,
                    Nome = u.Nome,
                    Sesso = u.Sesso,
                    Dtnascita = u.Dtnascita,
                    Luogonascita = u.Luogonascita,
                    Prov = u.Prov,
                    Denominazione = u.Denominazione,
                    Comunedomicilio = u.Comunedomicilio,
                    Siglacomunedomicilio = u.Siglacomunedomicilio,
                    EstremiContratto = u.EstremiContratto,
                    Tipotariffa = u.Tipotariffa,
                    Destinazioneuso = u.Destinazioneuso,
                    Tipocontratto = u.Tipocontratto,
                    Tipologiautenza = u.Tipologiautenza,
                    Datainizio = u.Datainizio,
                    Numeroiniziale = u.Numeroiniziale,
                    Numerofinale = u.Numerofinale,
                    Indirizzo = u.Indirizzo,
                    Codicecomune = u.Codicecomune,
                    Mesifatturazione = u.Mesifatturazione,
                    Costoannualericariche = u.Costoannualericariche,
                    Trafficoannuo = u.Trafficoannuo,
                    Ammontarefatturato = u.Ammontarefatturato,
                    Filler = u.Filler,
                    Caratteredicontrollo = u.Caratteredicontrollo,
                }).ToList();

                // Ottiene il percorso del desktop
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Ufficio.txt");

                // Cancella il file se esiste già
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                // Utilizza FileHelpers per scrivere i dati su un file sul desktop
                var engine = new FileHelperEngine<UfficioFILE>();
               
                engine.WriteFile(filePath, ufficioFileList);

                // Aggiunge un nuovo riga dopo ogni record
                using (var writer = new StreamWriter(filePath, true))
                {
                    foreach (var record in ufficioFileList)
                    {
                        writer.WriteLine($"{record.Tiporecord}{record.Cf}{record.Cognome}{record.Nome}{record.Sesso}{record.Dtnascita}{record.Luogonascita}{record.Prov}" +
                                         $"{record.Denominazione}{record.Comunedomicilio}{record.Siglacomunedomicilio}{record.EstremiContratto}{record.Tipotariffa}{record.Destinazioneuso}" +
                                         $"{record.Tipocontratto}{record.Tipologiautenza}{record.Datainizio}{record.Numeroiniziale}{record.Numerofinale}{record.Indirizzo}{record.Codicecomune}" +
                                         $"{record.Mesifatturazione}{record.Costoannualericariche}{record.Trafficoannuo}{record.Ammontarefatturato}{record.Filler}{record.Caratteredicontrollo}");
                    }
                }

                Console.WriteLine($"Dati scritti su {filePath}");
            }
        }
    }
}
