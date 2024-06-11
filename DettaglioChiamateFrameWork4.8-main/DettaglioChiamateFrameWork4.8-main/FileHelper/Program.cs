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
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

            string res = string.Join(Environment.NewLine,
    dt.Rows.OfType<DataRow>().Select(x => string.Join("", x.ItemArray)));

            var specialCharacters = res.Where(ch => !char.IsLetterOrDigit(ch) && !char.IsWhiteSpace(ch)).ToArray();

            HashSet<char> specialChars = new HashSet<char>(specialCharacters);

            if (specialChars.Any())
            {
                Console.WriteLine("La stringa contiene i seguenti caratteri speciali:");
                foreach (var chi in specialChars)
                {
                    Console.WriteLine(chi);
                }
            }
            else
            {
                Console.WriteLine("La stringa non contiene caratteri speciali.");
            }

     

            // Recupera la lista di tutte le righe di VoiPufficio dal database
            ufficioFileList = (from DataRow  u in dt.Rows
                                            select new UfficioFILE
                                            {

                                                Tiporecord = u["Tiporecord"].ToString().ToUpper(),
                                                Cf = u["Cf"].ToString().ToUpper(),
                                                Cognome = u["Cognome"].ToString().ToUpper(),
                                                Nome = u["Nome"].ToString().ToUpper(),
                                                Sesso = u["Sesso"].ToString().ToUpper(),
                                                Dtnascita = u["Dtnascita"].ToString().ToUpper(),
                                                Luogonascita = u["Luogonascita"].ToString().ToUpper(),
                                                Prov = u["Prov"].ToString().ToUpper(),
                                                Denominazione = u["Denominazione"].ToString().ToUpper(),
                                                Comunedomicilio = u["Comunedomicilio"].ToString().ToUpper(),
                                                Siglacomunedomicilio = u["Siglacomunedomicilio"].ToString().ToUpper(),
                                                EstremiContratto = u["EstremiContratto"].ToString().ToUpper(),
                                                Tipotariffa = u["Tipotariffa"].ToString().ToUpper(),
                                                Destinazioneuso = u["Destinazioneuso"].ToString().ToUpper(),
                                                Tipocontratto = u["Tipocontratto"].ToString().ToUpper(),
                                                Tipologiautenza = u["Tipologiautenza"].ToString().ToUpper(),
                                                Datainizio = u["Datainizio"].ToString().ToUpper(),
                                                Numeroiniziale = u["Numeroiniziale"].ToString().ToUpper(),
                                                Numerofinale = u["Numerofinale"].ToString().ToUpper(),
                                                Indirizzo = u["Indirizzo"].ToString().ToUpper(),
                                                Codicecomune = u["Codicecomune"].ToString().ToUpper(),
                                                Mesifatturazione = u["Mesifatturazione"].ToString().ToUpper(),
                                                Costoannualericariche = u["Costoannualericariche"].ToString().ToUpper(),
                                                Trafficoannuo = u["Trafficoannuo"].ToString().ToUpper(),
                                                Ammontarefatturato =u["Ammontarefatturato"].ToString().ToUpper(),
                                                Filler = u["Filler"].ToString().ToUpper(),
                                                Caratteredicontrollo = u["Caratteredicontrollo"].ToString().ToUpper()
                                            }).ToList();

            int numericUpDown/*.Value*/= 2023;


            string testa = $"0TEL00220{creaSpazi(17)}01405980531{creaSpazi(5)}ETRURIAWIFI S.R.L.{creaSpazi(42)}CAPALBIO{creaSpazi(32)}GR{creaSpazi(95)}" + numericUpDown/*.Value*/ + $"{creaSpazi(1554)}A";


            string coda = $"9TEL00220{creaSpazi(17)}01405980531{creaSpazi(5)}ETRURIAWIFI S.R.L.{creaSpazi(42)}CAPALBIO{creaSpazi(32)}GR{creaSpazi(95)}" + numericUpDown/*.Value*/ + $"{creaSpazi(1554)}A";


            // Scrive i dati su un file di testo

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Ufficio.txt");

          
                File.OpenWrite(filePath).Close();
                File.WriteAllText(filePath, string.Empty);

          
                var engine = new FileHelperEngine<UfficioFILE>();


            int a = engine.ReadFile(filePath).Length;
              
               File.AppendAllText(filePath, "à".ToUpper());
            
               File.AppendAllText(filePath,testa );

               engine.AppendToFile(filePath,ufficioFileList);
               
            filePath = Path.Combine(desktopPath, "dt.txt");
            List<UfficioFILE>oggetto=engine.ReadFileAsList(filePath);
          
           




            Console.WriteLine($"Dati scritti su {filePath}");
            }
          static  private string creaSpazi(int lunghezza)
        {
            return new string(' ', lunghezza);
    }
  
        }
}
