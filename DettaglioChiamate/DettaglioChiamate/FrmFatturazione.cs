using DettagliChiamate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
             *Dalla tabella voiptmpFatturazione creo un 
             *DataTable 
             *
             *
             */


            sql = "SELECT * FROM voiptmpFatturazione ";

            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella voiptmpFatturazione");
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
            DELETE FROM voipConteggioSecondo ";

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
INSERT INTO voipConteggioSecondo(
  contratto,
SommaDeiSecondi,
  tipo
)
SELECT 
  contratto,
 sum(datediff(second,'0:0:0',voiptmpFatturazione.durata)) AS sommaDeiSecondi,
 tipo
FROM 
  voiptmpFatturazione
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

            sql = "SELECT * FROM voiptmpFatturazione";
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
                FROM   voiptmpfatturazioneClone
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
                       UPDATE voiptmpFatturazione
SET voiptmpFatturazione.scatto =voipofferte.Scatto*NchiamateAddebitabili
FROM voipofferte 
JOIN voiptmpFatturazione ON voipofferte.idofferta = voiptmpFatturazione.offerta 
JOIN voipdettaglio ON voipdettaglio.id = voiptmpFatturazione.idDettaglio;

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
                SET Nchiamate=1";
            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella voipTmpFatturazione");
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
            SET     NchiamateAddebitabili=case 
            WHEN importo=0 THEN 0 ELSE 1 
            END
            FROM voiptmpFatturazione 
            JOIN voipdettaglio 
            ON voiptmpFatturazione.iddettaglio=voipdettaglio.id

            ";

            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella voiptmpFatturazione");
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
UPDATE voiptmpFatturazione
SET descrizione= voipTipoChiamate.Descrizione
FROM voiptmpFatturazione JOIN
voipTipoChiamate 
ON voiptmpFatturazione.tipo=VoiPTipoChiamate.tipo
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
            UPDATE voiptmpFatturazione
SET voiptmpFatturazione.tipo=VoiPdettaglio.tipo
FROM VoiptmpFatturazione
JOIN VoiPdettaglio
ON VoiPdettaglio.id=voiptmpFatturazione.idDettaglio
where
VoiptmpFatturazione.idDettaglio=VoiPdettaglio.iD

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
                    UPDATE voiptmpFatturazione
 SET secondiAddebitabili=
 CASE WHEN importo=0 
 THEN 0 ELSE secondi END
 FROM voiptmpFatturazione JOIN voipdettaglio 
 ON voiptmpfatturazione.idDettaglio=voipdettaglio.id
                    ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella voiptmpFatturazione");
                return fatturazione.Exception;
            }
            return "";


        }

        private string ClnLastFatturazione()
        {

            sql = @"
            UPDATE voiptmpFatturazione
 SET voiptmpfatturazione.ultimaFatturazione=voipContratti.lastdata
 FROM voiptmpFatturazione 
 JOIN VoipContratti
 ON voiptmpFatturazione.contratto=VoipContratti.id
where VoipContratti.fatturazione  is not null
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
             UPDATE voiptmpfatturazione
 SET SpesaChimata=VoiPofferte.SpesaScatto* VoiptmpFatturazione.Scatto
 FROM VoiptmpFatturazione JOIN VoiPofferte
 on VoiptmpFatturazione.offerta=VoiPofferte.idofferta
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
            sql = "delete from voiptmpfatturazione";
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
             *popolamente della tabella voiptmpFatturazione
             *
             */
            sql = @"


INSERT INTO [dbo].[voiptmpFatturazione] (
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
    voipContratti.id AS [contratto],
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
    Contratti ON voipContratti.id = Contratti.IdContratto
WHERE 
 voipdettaglio.data >= @inizio AND voipdettaglio.data <= @fine 

";




            fatturazione.AddParam("@inizio", inizio);
            fatturazione.AddParam("@fine", fine);
            fatturazione.ExecQuery(sql);


            sql = @"
	INSERT INTO [dbo].[voiptmpFatturazione] (
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
    voipContratti.id AS [contratto],
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
    Contratti ON voipContratti.id = Contratti.IdContratto

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
            sql = @"DELETE FROM voiptmpfatturazioneClone";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }


            sql = @" DBCC CHECKIDENT ('voiptmpFatturazioneClone', RESEED, 0); ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }

            sql = @" 
            

            INSERT INTO voiptmpFatturazioneClone(contratto, Tipo, secondiaddebitabili, nome, CodCli, telefono, descrizione)
            SELECT
              
                contratto,
                Tipo,
                SUM(secondiaddebitabili) AS secondiaddebitabili,
                nome,
                CodCli,
                telefono,
                descrizione
            FROM
                voiptmpFatturazione
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
		UPDATE voiptmpFatturazioneClone
SET voiptmpFatturazioneClone.secondi = sec.secondi
FROM voiptmpFatturazioneClone
JOIN (
    SELECT 
        contratto, 
        Tipo, 
        SUM(secondi) AS secondi
    FROM 
        voiptmpFatturazione 
    GROUP BY 
        contratto, Tipo
)as sec ON voiptmpFatturazioneClone.contratto = sec.contratto AND voiptmpFatturazioneClone.Tipo = sec.Tipo;
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

            UPDATE voiptmpFatturazioneClone
            SET voiptmpFatturazioneClone.Nchiamate= chiamata.Nchiamate
            FROM voiptmpFatturazioneClone
            JOIN (
                SELECT
                    contratto, 
                    Tipo, 
                    SUM(Nchiamate) AS Nchiamate
                FROM 
                    voiptmpFatturazione 
                GROUP BY 
                    contratto, Tipo
            )as chiamata ON voiptmpFatturazioneClone.contratto = chiamata.contratto AND voiptmpFatturazioneClone.Tipo = chiamata.Tipo;
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

            UPDATE voiptmpFatturazioneClone
            SET voiptmpFatturazioneClone.NchiamateAddebitabili= chiamata.NchiamateAddebitabili
            FROM voiptmpFatturazioneClone
            JOIN (
                SELECT
                    contratto, 
                    Tipo, 
                    SUM(NchiamateAddebitabili) AS NchiamateAddebitabili
                FROM 
                    voiptmpFatturazione 
                GROUP BY 
                    contratto, Tipo
            ) chiamata ON voiptmpFatturazioneClone.contratto = chiamata.contratto AND voiptmpFatturazioneClone.Tipo = chiamata.Tipo;
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

            UPDATE voiptmpfatturazioneclone
            SET offerta=voiptmpFatturazione.offerta
            FROM voiptmpfatturazioneClone 
            JOIN voiptmpFatturazione 
            ON voiptmpFatturazione.contratto=voiptmpfatturazioneClone.contratto 
            AND voiptmpFatturazione.tipo=voiptmpfatturazioneClone.Tipo
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

                    UPDATE voiptmpFatturazione
        SET secondiAddebitabili=
        CASE WHEN importo=0 
        THEN 0 ELSE secondi END
        FROM voiptmpFatturazione JOIN voipdettaglio
        ON voiptmpfatturazione.idDettaglio=voipdettaglio.id";

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
                       UPDATE voiptmpFatturazioneClone
SET voiptmpFatturazioneclone.scatto =ROUND(VoiPofferte.Scatto*voiptmpfatturazioneClone.NchiamateAddebitabili,2)
FROM VoiPofferte
JOIN voiptmpFatturazioneclone ON VoiPofferte.idofferta = voiptmpFatturazioneclone.offerta
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
            sql = @"SELECT * FROM voiptmpFatturazione 
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
