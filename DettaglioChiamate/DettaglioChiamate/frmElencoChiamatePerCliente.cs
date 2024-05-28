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


    public partial class frmElencoChiamatePerCliente : Form
    {


        // apre una connessione con il database

        // SqlConnection conn = new SqlConnection("Data Source=SERVER2019;Initial Catalog=Voip1;Persist Security Info=True;User ID=sa;Password=Caronte00;TrustServerCertificate=True;Encrypt=False");

        string cnKong = " Server=VMWARE\\MSSQLSERVER2019;Database=kongNew;Trusted_Connection=True;Encrypt=false;";


        SQLControl fatturazione = new SQLControl("Server = VMWARE\\MSSQLSERVER2019; Database=kongNew;Trusted_Connection=True;Encrypt=false;");

        //SQLControl fatturazione = new SQLControl("Data Source=SERVER2019;Initial Catalog=Voip1;Persist Security Info=True;User ID=sa;Password=Caronte00;TrustServerCertificate=True;Encrypt=False"); 

        DataTable dt = new DataTable();





        //SQLControl fatturazione = new SQLControl();
        string sql = "";
        DataTable dtofferta = new DataTable();
        public frmElencoChiamatePerCliente()
        {
            InitializeComponent();
        }

        private void frmElencoChiamatePerCliente_load(object sender, EventArgs e)
        {
            gbxPeriodo.Visible = true;
            dtpDataFatturazione.Value = DateTime.Now;
            gbx.Visible = true;
            cmdEsci.Visible = true;
            cmdEstrai.Visible = true;
            txtCli.Text = "c2779";
            gbx.Visible = true;
            DateTime minimo = new DateTime(2015, 01, 01);
            dtpInizio.MinDate = minimo;
            dtpInizio.MaxDate = DateTime.Now;
            dtpFine.MinDate = minimo;
            dtpFine.MaxDate = DateTime.Now;
            chkListContratti.Visible = true;
            dtpInizio.Value = minimo;
            chkseleziona.Visible = false;

        }

        private bool controlla()
        {

            bool r = true;

            if (dtpDataFatturazione.Value > DateTime.Now)
            {
                MessageBox.Show(" La data di fatturazione non può essere maggiore della data di sistema.");
                r = false;
                return r;
            }
            if (dtpInizio.Value.Date > dtpFine.Value.Date)
            {
                MessageBox.Show("La data di inzio non può essere maggiore della data finale.");
                r = false;

            }

            if (txtCli.Text == "")
            {
                MessageBox.Show("Il codice cliente non può essere vuoto.");
                r = false;
                return r;
            }

            else
            {
                if (TrovaCliente() == false)

                {

                    MessageBox.Show("Il codice cliende non esiste.");
                    r = false;
                    return r;
                }

            }

            return r;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            chkseleziona.Visible = false;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpFine_ValueChanged(object sender, EventArgs e)
        {

        }


        private bool TrovaCliente()
        {

            DataTable dt = new DataTable();

            string SQL =
            @"SELECT CodCli,Denom 
            FROM Clienti 
            WHERE clienti.CodCli='" + txtCli.Text + "'";

            //fatturazione = new SQLControl(connection);
            fatturazione.ExecQuery(SQL);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show(" Si è verificato un errore nell'estrazione del cliente.");
                return false;
            }

            dt = fatturazione.DBDT;

            if (fatturazione.RecordCount > 0)
            {

                return true;
            }

            else
            {

                return false;
            }
        }



        private void btnFatturazione_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            /*
           *
           *Svuotamento dei dati della
           *tabella tmpTabellaFatturazione
           *
           *
           */

            sql = "delete from voiptmpfatturazione DBCC CHECKIDENT ('voiptmpFatturazione', RESEED, 0);";
            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore nella cancellazione dei dati dentro la tabella");
                Cursor = Cursors.Default;
                return;
            }

            /*--------------------------------------
              popola la tabella tmpFatturazione
              con i dati estratti dalla tabella dettaglio
              e dalla tabella cliente
             ----------------------------------------*/

            if (PopolamentoTmpFatturazione() != "")
            {
                Cursor = Cursors.Default;
                return;
            }

            /*------------------------
             inserisce lo scatto alla risposta
            se previsto dall'offerta
            --------------------------*/



            if (ClnNchiamate() != "")
            {
                Cursor = Cursors.Default;
                return;
            }




            if (ClnNchiamateAddebitabili() != "")
            {
                Cursor = Cursors.Default;
                return;
            }


            if (ClnOffertaScatto() != "")
            {
                Cursor = Cursors.Default;
                return;

            }


            if (ClnTipo() != "")
            {
                Cursor = Cursors.Default;
                return;
            }


            if (ClnDescrizione() != "")
            {
                Cursor = Cursors.Default;
                return;
            }



            if (ClnSecondiAddebitabili() != "")
            {
                Cursor = Cursors.Default;
                return;
            }

            if (ClnOffertaScatto() != "")
            {
                Cursor = Cursors.Default;
                return;
            }

            if (ClnSpeseChiamate() != "")
            {
                Cursor = Cursors.Default;
                return;
            }

            if (ClnLastFatturazione() != "")
            {
                Cursor = Cursors.Default;
                return;
            }


            sql = "SELECT * FROM voiptmpFatturazione ";

            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella voipTmpFatturazione");
                Cursor = Cursors.Default;
                return;
            }
            if (fatturazione.RecordCount == 0)
            {
                MessageBox.Show("La tabella risulta vuota");
                Cursor = Cursors.Default;
                return;
            }






            dt = CalcolaSecondi();


            dataGridViewListaClienti.DataSource = dt;



            Cursor = Cursors.Default;
        }





        private void cmdEsci_Click(object sender, EventArgs e)
        {
            this.Close();
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


            dt.Columns.Remove("spesa");
            dt.Columns.Remove("scatto");



            return dt;
        }


        private void txtCli_TextChanged(object sender, EventArgs e)
        {
            chkseleziona.Visible = false;




        }



        private void cmdDati_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridViewListaClienti.DataSource = dt;
            chkseleziona.Text = "Seleziona tutto";
            chkseleziona.Checked = false;
            this.Cursor = Cursors.WaitCursor;
            if (chkseleziona.Text.Equals("Deseleziona tutto"))
                chkseleziona.Text = "Seleziona tutto";

            chkseleziona.Checked = false;

            if (controlla() == false)
            {
                return;
            }
            trovaContratto(txtCli.Text);
            this.Cursor = Cursors.Default;
            chkseleziona.Visible = true;

        }
        private void chkseleziona_CheckedChanged(object sender, EventArgs e)
        {
            if (chkseleziona.Text == "Seleziona tutto")
            {

                chkseleziona.Text = "Deseleziona tutto";
                for (int i = 0; i < chkListContratti.Items.Count; i++)
                {
                    chkListContratti.SetItemChecked(i, true);
                }
            }
            else
            {
                chkseleziona.Text = "Seleziona tutto";
                for (int i = 0; i < chkListContratti.Items.Count; i++)
                {
                    chkListContratti.SetItemChecked(i, false);
                }

            }
        }


        private void trovaContratto(string cliente)
        {

            //fatturazione = new SQLControl(connection);

            string sql = @"SELECT * FROM Kongnew.dbo.contratti WHERE tipocontr='voip' and codCli='" + cliente + "' ORDER BY idContratto";
            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore nella connessione alla tabella");
                return;
            }

            if (fatturazione.RecordCount == 0)
            {
                MessageBox.Show("Nessun contratto trovato");
                return;
            }

            chkListContratti.Items.Clear();
            foreach (DataRow row in fatturazione.DBDT.Rows)
            {
                chkListContratti.Items.Add(row["idcontratto"]);

            }





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
SET voiptmpFatturazione.scatto =VoiPofferte.Scatto*NchiamateAddebitabili
FROM VoiPofferte 
JOIN voiptmpFatturazione ON VoiPofferte.idofferta = voiptmpFatturazione.offerta 
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
                MessageBox.Show("Errore alla tabella TmpFatturazione");
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
                MessageBox.Show("Errore alla tabella voipTmpFatturazione");
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
            ON voiptmpFatturazione.Tipo=voipTipoChiamate.tipo
            ";
            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore nell'estrazine nell'elaborazione della fattura");
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

        private string ClnLastFatturazione()
        {

            sql = @"
            UPDATE voiptmpFatturazione
 SET voiptmpfatturazione.ultimaFatturazione=voipContratti.lastdata
 FROM voiptmpFatturazione 
 JOIN VoipContratti
 ON voiptmpFatturazione.contratto=VoipContratti.id
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
                MessageBox.Show("Errore alla tabella voipTmpFatturazione");
                return fatturazione.Exception;
            }
            return "";


        }



        private string PopolamentoTmpFatturazione()
        {



            /*
             *
             *Parametrizza i contratti selezionati dall'utente
             *
             */
            List<string> listaClienti = new List<string>();

            foreach (int index in chkListContratti.CheckedIndices)
            {
                listaClienti.Add(chkListContratti.Items[index].ToString());

            }
            if (listaClienti.Count == 0)
            {

                return fatturazione.Exception;
            }

            if (listaClienti.Count == 0)
            {
                return fatturazione.Exception;
            }

            /*
             *popolamente della tabella tmpFatturazione
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
        VoipContratti.id AS [contratto],
        VoipContratti.nome,
        Contratti.CodCli,
        VoipContratti.voip,
        VoipContratti.offerta,
        voipdettaglio.durata,
        DATEDIFF(second,'0:0:0',voipdettaglio.durata) AS secondi
		

    FROM 
        VoipContratti 
    JOIN 
        voipdettaglio ON voipdettaglio.chiamante = VoipContratti.portabilita 
    JOIN 
        Contratti ON VoipContratti.id = Contratti.IdContratto 
    WHERE
       voipdettaglio.data >= @inizio AND voipdettaglio.data <= @fine
";

            sql += " AND idcontratto IN (";

            foreach (string item in listaClienti)
            {
                sql += "'" + item + "',";

            }
            sql = sql.Substring(0, sql.Length - 1);
            sql += ")";

            fatturazione.AddParam("@inizio", dtpInizio.Value.Date);
            fatturazione.AddParam("@fine", dtpFine.Value.Date);
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
        VoipContratti.id AS [contratto],
        VoipContratti.nome,
        Contratti.CodCli,
        VoipContratti.voip,
        VoipContratti.offerta,
        voipdettaglio.durata,
        DATEDIFF(second,'0:0:0',voipdettaglio.durata) AS secondi
   
		

    FROM 
        VoipContratti 
    JOIN 
        voipdettaglio ON voipdettaglio.chiamante = VoipContratti.voip
    JOIN 
        Contratti ON VoipContratti.id = Contratti.IdContratto 

    WHERE 
       voipdettaglio.data >= @inizio AND voipdettaglio.data <= @fine ";

            sql += " AND idcontratto IN (";

            /*
            *
            *Parametrizza i contratti selezionati dall'utente
            *
            */

            foreach (string item in listaClienti)
            {
                sql += "'" + item + "',";

            }
            sql = sql.Substring(0, sql.Length - 1);
            sql += ")";



            fatturazione.AddParam("@inizio", dtpInizio.Value.Date);
            fatturazione.AddParam("@fine", dtpFine.Value.Date);
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

            UPDATE VoiptmpFatturazioneClone
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

        private void cmdEstrai_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            /*
           *
           *Svuotamento dei dati della
           *tabella tmpTabellaFatturazione
           *
           *
           */

            sql = "delete from voiptmpfatturazione DBCC CHECKIDENT ('voiptmpFatturazione', RESEED, 0);";
            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore nella cancellazione dei dati dentro la tabella");
                Cursor = Cursors.Default;
                return;
            }

            /*--------------------------------------
              popola la tabella tmpFatturazione
              con i dati estratti dalla tabella dettaglio
              e dalla tabella cliente
             ----------------------------------------*/

            if (PopolamentoTmpFatturazione() != "")
            {
                Cursor = Cursors.Default;
                return;
            }

            /*------------------------
             inserisce lo scatto alla risposta
            se previsto dall'offerta
            --------------------------*/



            if (ClnNchiamate() != "")
            {
                Cursor = Cursors.Default;
                return;
            }




            if (ClnNchiamateAddebitabili() != "")
            {
                Cursor = Cursors.Default;
                return;
            }


            if (ClnOffertaScatto() != "")
            {
                Cursor = Cursors.Default;
                return;

            }


            if (ClnTipo() != "")
            {
                Cursor = Cursors.Default;
                return;
            }


            if (ClnDescrizione() != "")
            {
                Cursor = Cursors.Default;
                return;
            }



            if (ClnSecondiAddebitabili() != "")
            {
                Cursor = Cursors.Default;
                return;
            }

            if (ClnOffertaScatto() != "")
            {
                Cursor = Cursors.Default;
                return;
            }

            if (ClnSpeseChiamate() != "")
            {
                Cursor = Cursors.Default;
                return;
            }

            if (ClnLastFatturazione() != "")
            {
                Cursor = Cursors.Default;
                return;
            }


            sql = "SELECT * FROM voiptmpFatturazione ";

            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella voipTmpFatturazione");
                Cursor = Cursors.Default;
                return;
            }
            if (fatturazione.RecordCount == 0)
            {
                MessageBox.Show("La tabella risulta vuota");
                Cursor = Cursors.Default;
                return;
            }






            dt = CalcolaSecondi();


            dataGridViewListaClienti.DataSource = dt;



            Cursor = Cursors.Default;
        }

        private void cmdDati_Click_1(object sender, EventArgs e)
        {


            dt.Clear();
            dataGridViewListaClienti.DataSource = dt;
            chkseleziona.Text = "Seleziona tutto";
            chkseleziona.Checked = false;
            this.Cursor = Cursors.WaitCursor;
            if (chkseleziona.Text.Equals("Deseleziona tutto"))
                chkseleziona.Text = "Seleziona tutto";

            chkseleziona.Checked = false;

            if (controlla() == false)
            {
                return;
            }
            trovaContratto(txtCli.Text);
            this.Cursor = Cursors.Default;
            chkseleziona.Visible = true;



        }

        private void cmdEsci_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkseleziona_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkseleziona.Text == "Seleziona tutto")
            {

                chkseleziona.Text = "Deseleziona tutto";
                for (int i = 0; i < chkListContratti.Items.Count; i++)
                {
                    chkListContratti.SetItemChecked(i, true);
                }
            }
            else
            {
                chkseleziona.Text = "Seleziona tutto";
                for (int i = 0; i < chkListContratti.Items.Count; i++)
                {
                    chkListContratti.SetItemChecked(i, false);
                }

            }
        }
    }

}

