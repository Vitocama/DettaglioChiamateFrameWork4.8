using DettagliChiamate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DettaglioChiamate
{
    public partial class FrmFatturazione : Form
    {

        // SqlConnection conn = new SqlConnection("Data Source=SERVER2019;Initial Catalog=Voip1;Persist Security Info=True;User ID=sa;Password=Caronte00;TrustServerCertificate=True;Encrypt=False");
        string connection = "Server=VMWARE\\MSSQLSERVER2019;Database=kongNew;Trusted_Connection=True;Encrypt=false;";
        // string connection = "Server=LAPTOP-8OH69FI3\\SQLEXPRESS01;Database=kongnew;Trusted_Connection=True;Encrypt=false";

        private int mesiDiFatturazione = 2;

        DataTable dt = new DataTable();

        //  string connection = System.Configuration.ConfigurationManager.ConnectionStrings["cnKong"].ConnectionString;
        SQLControl fatturazione = new SQLControl();
        string sql = "";
        DataTable dtofferta = new DataTable();
        public FrmFatturazione()
        {
            InitializeComponent();
        }

        private void FormFrmFatturazione_Load(object sender, EventArgs e)
        {
            dtpDataFatturazione.Value = DateTime.Now;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdEstrai_Click(object sender, EventArgs e)
        {
            Cursor cursor = Cursors.WaitCursor;
            estrazione();
            Cursor = Cursors.Default;
        }

        void estrazione()
        {
            fatturazione = new SQLControl(connection);
            /*
             *
             *Svuotamento dei dati della
             *tabella tmpTabellaFatturazione
             *
             *
             */

            


            if (PopolamentoTmpFatturazioneLista() != "")
            {
                return;
            }


            PopolamentoParzialeDiclone();
           


            if (ClnNchiamate() != "")
            {
                return;
            }

            if (ClnNchiamateAddebitabili() != "")
            {
                return;
            }

            if (ClnSecondiAddebitabili() != "")
            {
                return;
            }

            if (ClnOffertaScatto() != "")
            {
                return;
            }


            if (ClnLastFatturazione() != "")
            {
                return;
            }

            if (ClnTipo() != "")
            {
                return;
            }

            if (ClnImportoChiamate() != "")
            {
                return;
            }

            if (ClnDescrizione() != "")
            {
                return;
            }

            if (ClnOffertaScatto() != "")
            {

                return;

            }

            if (ClnLastdataConteggio() != "")
            {

                return;

            }


            if (ClnNmesiConteggio() != "")
            {

                return;

            }



            /*
             *
             *Dalla tabella voiptmpfatturazione creo un 
             *DataTable 
             *
             *
             */


            sql = "SELECT * FROM voiptmpfatturazione ";

            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella voiptmpfatturazione");
                return;
            }
            if (fatturazione.RecordCount == 0)
            {
                MessageBox.Show("La tabella risulta vuota");
                return;
            }
            dt = CalcolaSecondi();

            dataGridViewListaClienti.DataSource = dt;


        }

        private DataTable CalcolaSecondi()
        {


            sql = @"
            DELETE FROM voipConteggioSecondi ";

            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show(fatturazione.Exception);
                return dt = null;
            }
            if (fatturazione.RecordCount > 0)
            {
                MessageBox.Show(fatturazione.Exception);
                return dt = null;
            }


            sql = @"
INSERT INTO voipConteggioSecondi(
  contratto,
SommaDeiSecondi,
  tipo
)
SELECT 
  contratto,
 sum(datediff(second,'0:0:0',voiptmpfatturazione.durata)) AS sommaDeiSecondi,
 tipo
FROM 
  voiptmpfatturazione
  GROUP BY 
  contratto,
  tipo;
";
            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore nell'accesso alla tabella");
                return dt = null;
            }




            PopolamentoParzialeDiclone();


            ClnSecondiClone();

            ClnNChiamateclone();

            CLNnchiamateAddebitabiliClone();

            upOffertaclone();

            upSecondiAddebitabiliclone();

            ClnSecondiClone();

            upScattoclone();

            //TabOfferta();
            // TabTmpFatturazione();

            sql = "SELECT * FROM voiptmpfatturazioneclone";
            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
                return dt = null;

            dt = fatturazione.DBDT;






            sql = @"SELECT * 
                FROM   voiptmpfatturazioneclone
                ORDER by contratto
                ";

            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show(fatturazione.Exception);
                return dt = null;
            }
            if (fatturazione.RecordCount == 0)
            {
                MessageBox.Show("La tabella e' vuota");
                return dt = null;
            }


            dt = fatturazione.DBDT;

            




            return dt;
        }
        private string ClnOffertaScatto()
        {


            /*
             *
             *Query che popola la tabella Tmpfatturazione la colonna scatto
             *Se la tariffa del cliente prevede lo scatto alla risposta alla
             *verifica se esiste un importo diverso da 0.
             *Se l'importo risulta diverso 0 scrive lo scatto alla risposta altrimenti popola la tabella uguale a zero
             *
             */



            sql = @"
                                              UPDATE voiptmpfatturazione
SET voiptmpfatturazione.scatto =voipofferte.Scatto*nchiamateaddebitabili
FROM voipofferte 
JOIN voiptmpfatturazione ON voipofferte.idofferta = voiptmpfatturazione.offerta 
JOIN voipdettaglio ON voipdettaglio.id = voiptmpfatturazione.iddettaglio;

           ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }
            return "";
        }

        private string ClnNchiamate()
        {

            /*
             *La Query serve per popolare la colonna Nchiamate che e'
             *impostata a valore 1 servira' ad effetture la somma 
             *delle chiamate effettuate dall'utente
             *
             */
            sql = @"
                UPDATE voiptmpfatturazione
                SET nchiamate=1";
            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella voiptmpfatturazione");
                return fatturazione.Exception;
            }
            return "";
        }

        private string ClnNchiamateAddebitabili()
        {

            /*
             *Query che popola la colonna NchiamateAddebitabili
             *la query da valore 1 se la chiamata ha prodotto
             *un importo diverso maggiore 0 altrimenti popola la colonna 
             *con valore 0
             *
             */
            sql = @"

                          UPDATE voiptmpfatturazione
                SET     nchiamateaddebitabili=CASE 
                WHEN voiptmpfatturazione.importochiamata=0 THEN 0 ELSE 1 
                END
                FROM voiptmpfatturazione 
                JOIN voipdettaglio 
                ON voiptmpfatturazione.iddettaglio=voipdettaglio.id

            ";

            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella voiptmpfatturazione");
                return fatturazione.Exception;
            }
            return "";
        }


        private string ClnDescrizione()
        {



            /*
             * La query popola la colonna inserendo il dato 
             * descrizione chiamata.
             * 
             */



            sql = @"
UPDATE voiptmpfatturazione
SET descrizione= voiptipochiamate.descrizione
FROM voiptmpfatturazione JOIN
voiptipochiamate 
ON voiptmpfatturazione.tipo=voiptipochiamate.tipo
            ";
            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore nell'estrazine nell'elaborazione della fattura");
                return fatturazione.Exception;
            }

            return "";
        }


        private string ClnTipo()
        {
            sql = @"
            UPDATE voiptmpfatturazione
SET voiptmpfatturazione.tipo=VoiPdettaglio.tipo
FROM voiptmpfatturazione
JOIN VoiPdettaglio
ON VoiPdettaglio.id=voiptmpfatturazione.idDettaglio
where
voiptmpfatturazione.idDettaglio=VoiPdettaglio.iD

            ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                return fatturazione.Exception;
            }
            return "";
        }

        private string ClnLastdataConteggio()
        {
            sql = @"
            update voiptmpfatturazione
set LastdataConteggio=VoiPContratti.lastdata
from voiptmpfatturazione join VoiPContratti on voiptmpfatturazione.contratto=VoiPContratti.idContratto
            ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                return fatturazione.Exception;
            }
            return "";
        }

        private string ClnNmesiConteggio()
        {
            sql = @"
          
                    update voiptmpfatturazione
set nmesiconteggio=
case when  DATEDIFF(MONTH,LastDAtaConteggio, @data)>0 then 
DATEDIFF(MONTH,VoiPContratti.lastdata, @data) else 0 end
from voiptmpfatturazione join VoiPContratti on voiptmpfatturazione.contratto=VoiPContratti.idContratto
";

            fatturazione.Params.Clear();
            fatturazione.AddParam("@data", dtpDataFatturazione.Value.ToString("dd-MM-yyyy"));

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                return fatturazione.Exception;
            }
            return "";
        }





        private string ClnSecondiAddebitabili()
        {

            /*
             *Popolamento della colonna secondiFatturazione
             *
             *
             *
             */


            sql = @"
                     UPDATE voiptmpfatturazione
SET secondiAddebitabili=
CASE WHEN importochiamata=0 
THEN 0 ELSE secondi END
FROM voiptmpfatturazione JOIN voipdettaglio 
ON voiptmpfatturazione.iddettaglio=voipdettaglio.id
                    ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella voiptmpfatturazione");
                return fatturazione.Exception;
            }
            return "";


        }

        private string ClnLastFatturazione()
        {

            sql = @"
                        UPDATE voiptmpfatturazione
 SET voiptmpfatturazione.ultimafatturazione = voipContratti.lastdata
 FROM voiptmpfatturazione
 JOIN voipcontratti
 ON voiptmpfatturazione.contratto = voipcontratti.idContratto
 WHERE voipcontratti.fatturazione IS NOT NULL

             ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                return fatturazione.Exception;
            }


            return "";
        }





        private string ClnImportoChiamate()
        {


            sql = @"
             	   	               	   	   UPDATE voiptmpfatturazione
SET importochiamata=ROUND(Voipdettaglio.importo,2)
FROM voiptmpfatturazione JOIN voipdettaglio
on voiptmpfatturazione.iddettaglio=voipdettaglio.id
             ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                return fatturazione.Exception;
            }




            return "";
        }


        private string PopolamentoTmpFatturazioneLista()
        {

            fatturazione = new SQLControl(connection);
            Cursor = Cursors.WaitCursor;
            sql = "DELETE FROM voiptmpfatturazione  DBCC CHECKIDENT ('voiptmpfatturazione', RESEED, 0)";
            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore nella cancellazione dei dati dentro la tabella");
                Cursor = Cursors.Default;

            }

            /*
             Calcola il periodo di inizio mese e fine mese
             */
            int mesiDiFatturazione = 2; // Ad esempio, periodo di fatturazione di 3 mesi
            DateTime selectedDate = dtpDataFatturazione.Value;

            // Crea il primo giorno del mese corrente
            DateTime fine = new DateTime(selectedDate.Year, selectedDate.Month, 1);

            // Crea il primo giorno di 'mesiDiFatturazione' mesi prima
            DateTime inizio = fine.AddMonths(-mesiDiFatturazione);

            // Riduce la data di fine di un giorno per ottenere l'ultimo giorno del mese precedente
            fine = fine.AddDays(-1);

            // Output delle date per verifica





            fatturazione = new SQLControl(connection);

            /*
             *popolamente della tabella voiptmpfatturazione
             *
             */
            sql = @"


INSERT INTO [dbo].[voiptmpfatturazione] (
    [orachiamata],
    [data],
    [idDettaglio],
    [contratto],
    [nome],
    [CodCli],
    [telefono],
    [offerta], 
    [durata],  
    [secondi]
)
SELECT 
    voipdettaglio.orachiamata,
    voipdettaglio.data,
    voipdettaglio.id,
    voipContratti.idContratto AS [contratto],
    voipContratti.nome,
    Contratti.CodCli,
    voipContratti.portabilita,
    voipContratti.offerta,
    voipdettaglio.durata,
    DATEDIFF(second, '0:0:0', voipdettaglio.durata) AS secondi
FROM 
    voipContratti
JOIN 
    voipdettaglio ON voipdettaglio.chiamante = voipContratti.portabilita
JOIN 
    Contratti ON voipContratti.idContratto = Contratti.IdContratto
WHERE 
 voipdettaglio.data >=@inizio AND voipdettaglio.data <= @fine  

";

            fatturazione.Params.Clear();
            fatturazione.AddParam("@inizio", inizio.ToString("dd-MM-yyyy"));
            fatturazione.AddParam("@fine", fine.ToString("dd-MM-yyyy"));
            fatturazione.ExecQuery(sql);


            sql = @"
	
	INSERT INTO [dbo].[voiptmpfatturazione] (
    [orachiamata],
    [data],
    [idDettaglio],
    [contratto],
    [nome],
    [CodCli],
    [telefono],
    [offerta], 
    [durata],  
    [secondi]
)
SELECT 
    voipdettaglio.orachiamata,
    voipdettaglio.data,
    voipdettaglio.id,
    voipContratti.idContratto AS [contratto],
    voipContratti.nome,
    Contratti.CodCli,
    voipContratti.voip,
    voipContratti.offerta,
    voipdettaglio.durata,
    DATEDIFF(second, '0:0:0', voipdettaglio.durata) AS secondi
FROM 
    voipContratti
JOIN 
    voipdettaglio ON voipdettaglio.chiamante = voipContratti.voip
JOIN 
    Contratti ON voipContratti.idcontratto = Contratti.IdContratto
WHERE 
    voipdettaglio.data >= @inizio AND voipdettaglio.data <= @fine 
";




            fatturazione.Params.Clear();
            fatturazione.AddParam("@inizio", inizio.ToString("dd-MM-yyyy"));
            fatturazione.AddParam("@fine", fine.ToString("dd-MM-yyyy"));
            fatturazione.ExecQuery(sql);


            /*
             *
             *controlla se tutti i contratti tra quelli estratti hanno 
             *inserito un valore che li associa a un offerta
             *
             */
            if (controlloEsistenzaOfferta() == true)
            {
                MessageBox.Show("Alcuni contratti non hanno l'offerta giusta inserita");
                return " ";
            }


            Ppl_Cln_Fatt();



            sql = @"
                    DELETE FROM voiptmpfatturazione
WHERE contratto NOT IN (
    SELECT contratto
    FROM voiptmpfatturazione
    WHERE nmesiconteggio >= 2 )--AND lastdataconteggio <= @data);
                  ";
            fatturazione.Params.Clear();
            fatturazione.AddParam("@Data", fine.ToString("dd-MM-yyyy"));
            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore nel calcolo della lista di fatturazione");
                return "";
            }

            sql = "   SELECT TOP 1 * FROM voiptmpfatturazione";
            fatturazione.ExecQuery(sql);
            if (fatturazione.RecordCount ==0) {
                MessageBox.Show("La tabella ha prodotto 0 risultati");
                return "";
            }


            return "";
        }
        private string PopolamentoParzialeDiclone()
        {
            sql = @"DELETE FROM voiptmpfatturazioneclone";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }


            sql = @" DBCC CHECKIDENT ('voiptmpfatturazioneclone', RESEED, 0); ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }

            sql = @" 
            

            INSERT INTO voiptmpfatturazioneclone(contratto, tipo, secondiaddebitabili, nome, codCli, telefono, descrizione)
            SELECT
              
                contratto,
                tipo,
                SUM(secondiaddebitabili) AS secondiaddebitabili,
                nome,
                codCli,
                telefono,
                descrizione
            FROM
                voiptmpfatturazione
            GROUP BY
                contratto, tipo, nome, codCli, telefono, descrizione;
            ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }
            return "";

        }

        private string ClnSecondiClone()
        {
            /*
             *Popolamento della colonna secondi 
             *dove vengono inseriti le somme sei secondi per contrattto 
             *e per tipologia
             *
             */
            sql = @"
		UPDATE voiptmpfatturazioneclone
SET voiptmpfatturazioneclone.secondi = sec.secondi
FROM voiptmpfatturazioneclone
JOIN (
    SELECT 
        contratto, 
        tipo, 
        SUM(secondi) AS secondi
    FROM 
        voiptmpfatturazione 
    GROUP BY 
        contratto, tipo
)as sec ON voiptmpFatturazioneclone.contratto = sec.contratto AND voiptmpfatturazioneclone.tipo = sec.Tipo;
";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }
            return "";

        }


        private string ClnNChiamateclone()
        {

            sql = @"

            UPDATE VoiPtmpFatturazioneclone
            SET voiptmpfatturazioneclone.nchiamate= chiamata.nchiamate
            FROM voiptmpFatturazioneclone
            JOIN (
                SELECT
                    contratto, 
                    tipo, 
                    SUM(nchiamate) AS nchiamate
                FROM 
                    voiptmpfatturazione 
                GROUP BY 
                    contratto, tipo
            )as chiamata ON voiptmpfatturazioneclone.contratto = chiamata.contratto AND voiPtmpfatturazioneclone.tipo = chiamata.tipo;
";


            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }


            return "";
        }

        private string CLNnchiamateAddebitabiliClone()
        {
            sql = @"

            UPDATE voiptmpfatturazioneclone
            SET voiptmpfatturazioneclone.nchiamateAddebitabili= chiamata.nchiamateaddebitabili
            FROM voiptmpfatturazioneclone
            JOIN (
                SELECT
                    contratto, 
                    tipo, 
                    SUM(nchiamateaddebitabili) AS nchiamateaddebitabili
                FROM 
                    voiptmpfatturazione 
                GROUP BY 
                    contratto, tipo
            ) chiamata ON voiptmpFatturazioneclone.contratto = chiamata.contratto AND voiptmpfatturazioneclone.tipo = chiamata.tipo;
            ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }

            return "";
        }

        private string upOffertaclone()
        {
            sql = @"

            UPDATE VoiPtmpFatturazioneclone
            SET offerta=voiptmpfatturazione.offerta
            FROM VoiPtmpFatturazioneclone 
            JOIN voiptmpfatturazione 
            ON voiptmpfatturazione.contratto=VoiPtmpFatturazioneclone.contratto 
            AND voiptmpfatturazione.tipo=VoiPtmpFatturazioneclone.Tipo
";
            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }


            return "";
        }

        private string upSecondiAddebitabiliclone()
        {
            sql = @"

         
UPDATE voiptmpfatturazioneClone
        SET importochiamata = ROUND(tmpfatt.import,2) 
       FROM(
	   SELECT contratto,tipo,SUM(ImportoChiamata)AS import
	   FROM VoiPtmpFatturazione
	   GROUP BY contratto,tipo
	   ) AS tmpfatt
		WHERE voiptmpfatturazioneclone.contratto=tmpfatt.contratto AND  voiptmpfatturazioneclone.tipo=tmpfatt.tipo";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }


            return "";
        }

        private string upScattoclone()
        {
            sql = @"
                       UPDATE VoiPtmpFatturazioneclone
SET VoiPtmpFatturazioneclone.scatto =ROUND(VoiPofferte.Scatto*VoiPtmpFatturazioneclone.NchiamateAddebitabili,2)
FROM VoiPofferte
JOIN VoiPtmpFatturazioneclone ON VoiPofferte.idofferta = VoiPtmpFatturazioneclone.offerta
             ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                return fatturazione.Exception;
            }


            return "";


        }



        private bool controlloEsistenzaOfferta()
        {
            sql = @"SELECT * FROM voiptmpfatturazione 
                   WHERE offerta=0";
            fatturazione.ExecQuery(sql);
            if (fatturazione.RecordCount > 0)
            {
                return true;
            }
            return false;
        }






        private void cmdEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string ControlloAllInclusive(string offerta)
        {

            int tariffa = int.Parse(offerta);




            return "";



        }

        private void cmdesci_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ppl_Cln_Fatt()
        {
           

            if (ClnNchiamate() != "")
            {
                return;
            }

            if (ClnNchiamateAddebitabili() != "")
            {
                return;
            }

            if (ClnSecondiAddebitabili() != "")
            {
                return;
            }

            if (ClnOffertaScatto() != "")
            {
                return;
            }


            if (ClnLastFatturazione() != "")
            {
                return;
            }

            if (ClnTipo() != "")
            {
                return;
            }

            if (ClnImportoChiamate() != "")
            {
                return;
            }

            if (ClnDescrizione() != "")
            {
                return;
            }

            if (ClnOffertaScatto() != "")
            {

                return;

            }

            if (ClnLastdataConteggio() != "")
            {

                return;

            }

            if (ClnNmesiConteggio() != "")
            {

                return;

            }


        }
    }
}
