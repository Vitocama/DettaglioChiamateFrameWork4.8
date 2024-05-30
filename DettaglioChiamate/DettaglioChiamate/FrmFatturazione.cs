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




            if (PopolamentoTmpFatturazione() != "")
            {
                return;
            }



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

            if (ClnSpeseChiamate() != "")
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
            /*
             *
             *Dalla tabella voiptmpFatturazioneALL creo un 
             *DataTable 
             *
             *
             */


            sql = "SELECT * FROM voiptmpFatturazioneALL ";

            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella voiptmpFatturazioneALL");
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
 sum(datediff(second,'0:0:0',voiptmpFatturazioneALL.durata)) AS sommaDeiSecondi,
 tipo
FROM 
  voiptmpFatturazioneALL
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




            PopolamentoParzialeDiClone();


            UpSecondiClone();

            UpNChiamateClone();

            upNchiamateAddebitabiliClone();

            upOffertaClone();

            upSecondiAddebitabiliClone();

            UpSecondiClone();

            upScattoClone();

            //TabOfferta();
            // TabTmpFatturazione();

            sql = "SELECT * FROM voiptmpFatturazioneALL";
            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
                return dt = null;

            dt = fatturazione.DBDT;


            //foreach (DataRow row in dt.Rows)
            //{
            //    string offerta = row["offerta"].ToString();

            //    string allInclusive=ControlloAllInclusive(offerta);



            //}



            sql = @"SELECT    
               
                contratto, 
                nome, 
                CodCli,  
                telefono,  
                offerta, 
                Tipo, 
                descrizione,  
                secondi, 
                secondiAddebitabili, 
                Nchiamate, 
                NchiamateAddebitabili, 
                Scatto,  spesa 
                FROM   voiptmpfatturazioneCloneALL
                order by contratto
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
                       UPDATE voiptmpFatturazioneALL
SET voiptmpFatturazioneALL.scatto =voipofferte.Scatto*NchiamateAddebitabili
FROM voipofferte 
JOIN voiptmpFatturazioneALL ON voipofferte.idofferta = voiptmpFatturazioneALL.offerta 
JOIN voipdettaglio ON voipdettaglio.id = voiptmpFatturazioneALL.idDettaglio;

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
                UPDATE voiptmpfatturazioneALL
                SET Nchiamate=1";
            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella voiptmpFatturazioneALL");
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

            UPDATE voiptmpfatturazioneALL
            SET     NchiamateAddebitabili=case 
            WHEN importo=0 THEN 0 ELSE 1 
            END
            FROM voiptmpFatturazioneALL 
            JOIN voipdettaglio 
            ON voiptmpFatturazioneALL.iddettaglio=voipdettaglio.id

            ";

            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella voiptmpFatturazioneALL");
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
UPDATE voiptmpFatturazioneALL
SET descrizione= voipTipoChiamate.Descrizione
FROM voiptmpFatturazioneALL JOIN
voipTipoChiamate 
ON voiptmpFatturazioneALL.tipo=VoiPTipoChiamate.tipo
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
            UPDATE voiptmpFatturazioneALL
SET voiptmpFatturazioneALL.tipo=VoiPdettaglio.tipo
FROM voiptmpFatturazioneALL
JOIN VoiPdettaglio
ON VoiPdettaglio.id=voiptmpFatturazioneALL.idDettaglio
where
voiptmpFatturazioneALL.idDettaglio=VoiPdettaglio.iD

            ";

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
                    UPDATE voiptmpFatturazioneALL
 SET secondiAddebitabili=
 CASE WHEN importo=0 
 THEN 0 ELSE secondi END
 FROM voiptmpFatturazioneALL JOIN voipdettaglio 
 ON voiptmpFatturazioneALL.idDettaglio=voipdettaglio.id
                    ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella voiptmpFatturazioneALL");
                return fatturazione.Exception;
            }
            return "";


        }

        private string ClnLastFatturazione()
        {

sql=@"
            UPDATE voiptmpFatturazioneALL
 SET voiptmpFatturazioneALL.ultimaFatturazione = voipContratti.lastdata
 FROM voiptmpFatturazioneALL
 JOIN VoipContratti
 ON voiptmpFatturazioneALL.contratto = VoipContratti.idContratto
where VoipContratti.fatturazione is not null

             ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                return fatturazione.Exception;
            }


            return "";
        }





        private string ClnSpeseChiamate()
        {


            sql = @"
             	   
	   UPDATE voiptmpFatturazioneALL
SET SpesaChimata=VoiPofferte.CostoScatto* voiptmpFatturazioneALL.Scatto
FROM voiptmpFatturazioneALL JOIN VoiPofferte
on voiptmpFatturazioneALL.offerta=VoiPofferte.idofferta
             ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                return fatturazione.Exception;
            }




            return "";
        }


        private string PopolamentoTmpFatturazione()
        {

            fatturazione = new SQLControl(connection);
            Cursor = Cursors.WaitCursor;
            sql = "delete from voiptmpFatturazioneALL";
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
             *popolamente della tabella voiptmpFatturazioneALL
             *
             */
            sql = @"


INSERT INTO [dbo].[voiptmpFatturazioneALL] (
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


            //string inizioFormatted = inizio.ToString("dd/MM/yyyy");
            //string fineFormatted = fine.ToString("dd/MM/yyyy");
            fatturazione.AddParam("@inizio", inizio);
            fatturazione.AddParam("@fine", fine );
            fatturazione.ExecQuery(sql);


            sql = @"
	
	INSERT INTO [dbo].[voiptmpFatturazioneALL] (
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





            fatturazione.AddParam("@inizio", inizio);
            fatturazione.AddParam("@fine", fine);
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



            return "";
        }
        private string PopolamentoParzialeDiClone()
        {
            sql = @"DELETE FROM voiptmpFatturazioneCLONEALL";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }


            sql = @" DBCC CHECKIDENT ('voiptmpFatturazioneCLONEALL', RESEED, 0); ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }

            sql = @" 
            

            INSERT INTO voiptmpFatturazioneCLONEALL(contratto, Tipo, secondiaddebitabili, nome, CodCli, telefono, descrizione)
            SELECT
              
                contratto,
                Tipo,
                SUM(secondiaddebitabili) AS secondiaddebitabili,
                nome,
                CodCli,
                telefono,
                descrizione
            FROM
                voiptmpFatturazioneALL
            GROUP BY
                contratto, Tipo, nome, CodCli, telefono, descrizione;
            ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }
            return "";

        }

        private string UpSecondiClone()
        {
            /*
             *Popolamento della colonna secondi 
             *dove vengono inseriti le somme sei secondi per contrattto 
             *e per tipologia
             *
             */
            sql = @"
		UPDATE voiptmpFatturazioneCLONEALL
SET voiptmpFatturazioneCLONEALL.secondi = sec.secondi
FROM voiptmpFatturazioneCLONEALL
JOIN (
    SELECT 
        contratto, 
        Tipo, 
        SUM(secondi) AS secondi
    FROM 
        voiptmpFatturazioneALL 
    GROUP BY 
        contratto, Tipo
)as sec ON voiptmpFatturazioneCLONEALL.contratto = sec.contratto AND voiptmpFatturazioneCLONEALL.Tipo = sec.Tipo;
";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }
            return "";

        }


        private string UpNChiamateClone()
        {

            sql = @"

            UPDATE voiptmpFatturazioneCLONEALL
            SET voiptmpFatturazioneCLONEALL.Nchiamate= chiamata.Nchiamate
            FROM voiptmpFatturazioneCLONEALL
            JOIN (
                SELECT
                    contratto, 
                    Tipo, 
                    SUM(Nchiamate) AS Nchiamate
                FROM 
                    voiptmpFatturazioneALL 
                GROUP BY 
                    contratto, Tipo
            )as chiamata ON voiptmpFatturazioneCLONEALL.contratto = chiamata.contratto AND voiptmpFatturazioneCLONEALL.Tipo = chiamata.Tipo;
";


            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }


            return "";
        }

        private string upNchiamateAddebitabiliClone()
        {
            sql = @"

            UPDATE voiptmpFatturazioneCLONEALL
            SET voiptmpFatturazioneCLONEALL.NchiamateAddebitabili= chiamata.NchiamateAddebitabili
            FROM voiptmpFatturazioneCLONEALL
            JOIN (
                SELECT
                    contratto, 
                    Tipo, 
                    SUM(NchiamateAddebitabili) AS NchiamateAddebitabili
                FROM 
                    voiptmpFatturazioneALL 
                GROUP BY 
                    contratto, Tipo
            ) chiamata ON voiptmpFatturazioneCLONEALL.contratto = chiamata.contratto AND voiptmpFatturazioneCLONEALL.Tipo = chiamata.Tipo;
            ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }

            return "";
        }

        private string upOffertaClone()
        {
            sql = @"

            UPDATE voiptmpFatturazioneCLONEALL
            SET offerta=voiptmpFatturazioneALL.offerta
            FROM voiptmpFatturazioneCLONEALL 
            JOIN voiptmpFatturazioneALL 
            ON voiptmpFatturazioneALL.contratto=voiptmpFatturazioneCLONEALL.contratto 
            AND voiptmpFatturazioneALL.tipo=voiptmpFatturazioneCLONEALL.Tipo
";
            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }


            return "";
        }

        private string upSecondiAddebitabiliClone()
        {
            sql = @"

                    UPDATE voiptmpFatturazioneALL
        SET secondiAddebitabili=
        CASE WHEN importo=0 
        THEN 0 ELSE secondi END
        FROM voiptmpFatturazioneALL JOIN voipdettaglio
        ON voiptmpFatturazioneALL.idDettaglio=voipdettaglio.id";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }


            return "";
        }

        private string upScattoClone()
        {
            sql = @"
                       UPDATE voiptmpFatturazioneCLONEALL
SET voiptmpFatturazioneCLONEALL.scatto =ROUND(VoiPofferte.Scatto*voiptmpFatturazioneCLONEALL.NchiamateAddebitabili,2)
FROM VoiPofferte
JOIN voiptmpFatturazioneCLONEALL ON VoiPofferte.idofferta = voiptmpFatturazioneCLONEALL.offerta
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
            sql = @"SELECT * FROM voiptmpFatturazioneALL 
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
    }
}
