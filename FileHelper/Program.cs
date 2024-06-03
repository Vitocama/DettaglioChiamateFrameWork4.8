using FileHelper.EntitiesKONGNEW;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FileHelpers;
using Microsoft.Data.SqlClient;
using System.Data;
using FileHelpers.Converters;
using System.Collections;

namespace FileHelper.Entities
{
    internal class Program
    {

       
        private static void Main(string[] args)
             { List<UfficioFILE> ufficioFileList;
            DataTable dt = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection("Server = VMWARE\\MSSQLSERVER2019; Database = kongnew; Trusted_Connection = True; Encrypt = false;"))
            { 
                sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM VoiPufficio", sqlConnection);
                sqlDataAdapter.Fill(dt);
            }

                // Recupera la lista di tutte le righe di VoiPufficio dal database
                ufficioFileList = (from DataRow  u in dt.Rows
                                            select new UfficioFILE
                                            {

                                                Tiporecord = u["Tiporecord"].ToString(),
                                                Cf = u["Cf"].ToString(),
                                                Cognome = u["Cognome"].ToString(),
                                                Nome = u["Nome"].ToString(),
                                                Sesso = u["Sesso"].ToString(),
                                                Dtnascita = u["Dtnascita"].ToString(),
                                                Luogonascita = u["Luogonascita"].ToString(),
                                                Prov = u["Prov"].ToString(),
                                                Denominazione = u["Denominazione"].ToString(),
                                                Comunedomicilio = u["Comunedomicilio"].ToString(),
                                                Siglacomunedomicilio = u["Siglacomunedomicilio"].ToString(),
                                                EstremiContratto = u["EstremiContratto"].ToString(),
                                                Tipotariffa = u["Tipotariffa"].ToString(),
                                                Destinazioneuso = u["Destinazioneuso"].ToString(),
                                                Tipocontratto = u["Tipocontratto"].ToString(),
                                                Tipologiautenza = u["Tipologiautenza"].ToString(),
                                                Datainizio = u["Datainizio"].ToString(),
                                                Numeroiniziale = u["Numeroiniziale"].ToString(),
                                                Numerofinale = u["Numerofinale"].ToString(),
                                                Indirizzo = u["Indirizzo"].ToString(),
                                                Codicecomune = u["Codicecomune"].ToString(),
                                                Mesifatturazione = u["Mesifatturazione"].ToString(),
                                                Costoannualericariche = u["Costoannualericariche"].ToString(),
                                                Trafficoannuo = u["Trafficoannuo"].ToString(),
                                                Ammontarefatturato =u["Ammontarefatturato"].ToString(),
                                                Filler = u["Filler"].ToString(),
                                                Caratteredicontrollo = u["Caratteredicontrollo"].ToString()
                                            }).ToList();



                // Scrive i dati su un file di testo

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Ufficio.txt");

                // Cancella il file se esiste già
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                // Utilizza FileHelpers per scrivere i dati su un file sul desktop
                var engine = new FileHelperEngine<UfficioFILE>();
               
               engine.WriteFile(filePath,ufficioFileList);

                // Aggiunge un nuovo riga dopo ogni record
               

                Console.WriteLine($"Dati scritti su {filePath}");
            }
        
    }
}
