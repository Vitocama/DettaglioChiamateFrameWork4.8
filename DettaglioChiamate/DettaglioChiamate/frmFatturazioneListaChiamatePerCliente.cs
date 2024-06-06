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


    public partial class frmFatturazioneListaChiamatePerCliente : Form
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
        public frmFatturazioneListaChiamatePerCliente()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            chkseleziona.Visible = false;
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

            sql = @"delete from  VoiptmpListaChiamate 
                  DBCC CHECKIDENT ('VoiptmpListaChiamate', RESEED, 0);
                  DELETE FROM  VoiptmpListaChiamateClone 
                  DBCC CHECKIDENT ('voiptmpFatturazioneClone', RESEED, 0)";
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

            if (PplTmpFattClient() != "")
            {
                Cursor = Cursors.Default;
                return;
            }

            /*------------------------
             inserisce lo scatto alla risposta
            se previsto dall'offerta
            --------------------------*/





            sql = "SELECT * FROM VoiptmpListaChiamate ";

            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella  VoiptmpListaChiamate");
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


        private void btnFatturazioneListaPerClienti_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            /*
           *
           *Svuotamento dei dati della
           *tabella tmpTabellaFatturazione
           *
           *
           */

            sql = "delete from   DBCC CHECKIDENT ('VoiptmpListaChiamate', RESEED, 0);";
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

            if (PplTmpFattClient() != "")
            {
                Cursor = Cursors.Default;
                return;
            }

           

            PplClnListCall();


            sql = "SELECT * FROM  VoiptmpListaChiamate ";

            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella  VoiptmpListaChiamate");
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
                     sum(datediff(second,'0:0:0',VoiptmpListaChiamate.durata)) AS sommaDeiSecondi,
                     tipo
                    FROM 
                       VoiptmpListaChiamate
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



            sql = @"
                  INSERT INTO VoiptmpListaChiamateClone(
            contratto, 
            Tipo, 
            secondiaddebitabili, 
            nome, 
            CodCli, 
            telefono, 
            descrizione)
                  SELECT
                      contratto,
                      Tipo,
                      SUM(secondiaddebitabili) AS secondiaddebitabili,
                      nome,
                      CodCli,
                      telefono,
                      descrizione
                  FROM
                      VoiptmpListaChiamate
                  GROUP BY
                      contratto, Tipo, nome, CodCli, telefono, descrizione;
         
                ";

            fatturazione.ExecQuery(sql);

            sql = "select * from VoiptmpListaChiamateClone";

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

            PplClnFattForClientClone();

            dt = fatturazione.DBDT;

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
        private string ClnImportoScatto()
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


UPDATE  VoiptmpListaChiamate
SET ImportoScatto=VoiPofferte.Scatto*
VoiptmpListaChiamate.NchiamateAddebitabili
*
VoiPofferte.spesascatto
FROM  VoiptmpListaChiamate JOIN VoiPofferte
on  VoiptmpListaChiamate.offerta=VoiPofferte.idofferta

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
                UPDATE  VoiptmpListaChiamate
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

            UPDATE  VoiptmpListaChiamate
            SET     NchiamateAddebitabili=case 
            WHEN importo=0 THEN 0 ELSE 1 
            END
            FROM  VoiptmpListaChiamate 
            JOIN voipdettaglio 
            ON  VoiptmpListaChiamate.iddettaglio=voipdettaglio.id

            ";

            fatturazione.ExecQuery(sql);

            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella  VoiptmpListaChiamate");
                return fatturazione.Exception;
            }
            return "";
        }

        private string ClnTipo()
        {
            sql = @"
            update VoiptmpListaChiamate
SET  VoiptmpListaChiamate.tipo=VoiPdettaglio.tipo
FROM  VoiptmpListaChiamate
JOIN VoiPdettaglio
ON VoiPdettaglio.id=VoiptmpListaChiamate.idDettaglio
where
VoiptmpListaChiamate.idDettaglio=VoiPdettaglio.iD

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
            UPDATE  VoiptmpListaChiamate
            SET descrizione= voipTipoChiamate.Descrizione
            FROM  VoiptmpListaChiamate JOIN
            voipTipoChiamate 
            ON  VoiptmpListaChiamate.Tipo=voipTipoChiamate.tipo
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
                                                  UPDATE  VoiptmpListaChiamate
SET ImportoChiamata=Voipdettaglio.importo
FROM  VoiptmpListaChiamate JOIN Voipdettaglio
on  VoiptmpListaChiamate.idDettaglio=Voipdettaglio.iD
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
                       UPDATE  VoiptmpListaChiamate
SET  VoiptmpListaChiamate.ultimaFatturazione=voipContratti.lastdata
FROM  VoiptmpListaChiamate 
JOIN VoipContratti
ON  VoiptmpListaChiamate.contratto=VoipContratti.idContratto
where VoipContratti.fatturazione  is not null
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
                    UPDATE  VoiptmpListaChiamate
 SET secondiAddebitabili=
 CASE WHEN importo=0 
 THEN 0 ELSE secondi END
 FROM  VoiptmpListaChiamate JOIN voipdettaglio 
 ON  VoiptmpListaChiamate.idDettaglio=voipdettaglio.id
                    ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {
                MessageBox.Show("Errore alla tabella  VoiptmpListaChiamate");
                return fatturazione.Exception;
            }
            return "";


        }



        private string PplTmpFattClient()
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
INSERT INTO [dbo].[VoiptmpListaChiamate] (
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
        VoipContratti.idContratto AS [contratto],
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
        Contratti ON VoipContratti.idContratto = Contratti.IdContratto 
    WHERE
       voipdettaglio.data >= @inizio AND voipdettaglio.data <= @fine
";

            sql += " AND  voipcontratti.idcontratto IN (";

            foreach (string item in listaClienti)
            {
                sql += "'" + item + "',";

            }
            sql = sql.Substring(0, sql.Length - 1);
            sql += ")";
            fatturazione.Params.Clear();

       

            fatturazione.AddParam("@inizio", dtpInizio.Value.ToString("dd/MM/yyyy"));
            fatturazione.AddParam("@fine", dtpFine.Value.ToString("dd/MM/yyyy"));
            fatturazione.ExecQuery(sql);

            sql = @"
INSERT INTO [dbo].[VoiptmpListaChiamate] (
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
        VoipContratti.idContratto AS [contratto],
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
        Contratti ON VoipContratti.idContratto = Contratti.IdContratto 

    WHERE 
       voipdettaglio.data >= @inizio AND voipdettaglio.data <= @fine ";

            sql += " AND  voipcontratti.idcontratto IN (";

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





            fatturazione.AddParam("@inizio", dtpInizio.Value.ToString("dd/MM/yyyy"));
            fatturazione.AddParam("@fine", dtpFine.Value.ToString("dd/MM/yyyy"));
            fatturazione.ExecQuery(sql);


            /*
             *
             *controlla se tutti i contratti tra quelli estratti hanno 
             *inserito un valore che li associa a un offerta
             *
             */

            PplClnListCall();


            if (controlloEsistenzaOfferta() == true)
            {
                MessageBox.Show("Alcuni contratti non hanno l'offerta giusta inserita");
                return " ";
            }



            return "";
        }

        private void PplClnListCall()
        {
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

            if (ClnImportoScatto() != "")
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

            if (ClnImportoScatto() != "")
            {
                Cursor = Cursors.Default;
                return;

            }


           



        }



        private string PplTabFattClientClone()
        {
           

            sql = @" 
            

            INSERT INTO  VoiptmpListaChiamateClone(contratto, Tipo, secondiaddebitabili, nome, CodCli, telefono, descrizione)
            SELECT
              
                contratto,
                Tipo,
                SUM(secondiaddebitabili) AS secondiaddebitabili,
                nome,
                CodCli,
                telefono,
                descrizione
            FROM
                 VoiptmpListaChiamate
            GROUP BY
                contratto, Tipo, nome, CodCli, telefono, descrizione;
            ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }

            PplClnFattForClientClone();
            return "";

        }

        private void PplClnFattForClientClone()
        {


            ClnSecondiClone();

            ClnNChiamateClone();

            ClnNchiamateAddebitabiliClone();

            ClnOffertaClone();

            ClnSecondiAddebitabiliClone();

            
            ClnScattoClone();

            ClnSpesaAddebitabileClone();



        }

        private string ClnSpesaAddebitabileClone()
        {

            sql = @"";

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
		UPDATE  VoiptmpListaChiamateClone
SET  VoiptmpListaChiamateClone.secondi = sec.secondi
FROM  VoiptmpListaChiamateClone
JOIN (
    SELECT 
        contratto, 
        Tipo, 
        SUM(secondi) AS secondi
    FROM 
         VoiptmpListaChiamate 
    GROUP BY 
        contratto, Tipo
)as sec ON  VoiptmpListaChiamateClone.contratto = sec.contratto AND  VoiptmpListaChiamateClone.Tipo = sec.Tipo;
";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }
            return "";

        }


        private string ClnNChiamateClone()
        {

            sql = @"

            UPDATE  VoiptmpListaChiamateClone
            SET  VoiptmpListaChiamateClone.Nchiamate= chiamata.Nchiamate
            FROM  VoiptmpListaChiamateClone
            JOIN (
                SELECT
                    contratto, 
                    Tipo, 
                    SUM(Nchiamate) AS Nchiamate
                FROM 
                     VoiptmpListaChiamate 
                GROUP BY 
                    contratto, Tipo
            )as chiamata ON  VoiptmpListaChiamateClone.contratto = chiamata.contratto AND  VoiptmpListaChiamateClone.Tipo = chiamata.Tipo;
";


            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }


            return "";
        }

        private string ClnNchiamateAddebitabiliClone()
        {
            sql = @"

            UPDATE  VoiptmpListaChiamateClone
            SET  VoiptmpListaChiamateClone.NchiamateAddebitabili= chiamata.NchiamateAddebitabili
            FROM  VoiptmpListaChiamateClone
            JOIN (
                SELECT
                    contratto, 
                    Tipo, 
                    SUM(NchiamateAddebitabili) AS NchiamateAddebitabili
                FROM 
                     VoiptmpListaChiamate 
                GROUP BY 
                    contratto, Tipo
            ) chiamata ON  VoiptmpListaChiamateClone.contratto = chiamata.contratto AND  VoiptmpListaChiamateClone.Tipo = chiamata.Tipo;
            ";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }

            return "";
        }

        private string ClnOffertaClone()
        {
            sql = @"
            		             UPDATE  VoiptmpListaChiamateclone
SET offerta=VoiptmpListaChiamate.offerta
FROM  VoiptmpListaChiamateClone 
JOIN  VoiptmpListaChiamate 
ON  VoiptmpListaChiamate.contratto=VoiptmpListaChiamateclone.contratto 
AND  VoiptmpListaChiamate.tipo=VoiptmpListaChiamateclone.Tipo
";
            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }


            return "";
        }

        private string ClnSecondiAddebitabiliClone()
        {
            sql = @"

                    UPDATE  VoiptmpListaChiamate
        SET secondiAddebitabili=
        CASE WHEN importo=0 
        THEN 0 ELSE secondi END
        FROM  VoiptmpListaChiamate JOIN voipdettaglio
        ON  VoiptmpListaChiamate.idDettaglio=voipdettaglio.id";

            fatturazione.ExecQuery(sql);
            if (fatturazione.HasException(true))
            {

                return fatturazione.Exception;
            }


            return "";
        }

        private string ClnScattoClone()
        {
            sql = @"
            UPDATE  VoiptmpListaChiamateClone
SET  VoiptmpListaChiamateclone.importoChiamata =ROUND(VoiPofferte.Scatto* VoiptmpListaChiamateClone.NchiamateAddebitabili,2)
FROM VoiPofferte
JOIN  VoiptmpListaChiamateclone ON VoiPofferte.idofferta =  VoiptmpListaChiamateclone.offerta 
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
            sql = @"SELECT * FROM  VoiptmpListaChiamate 
                   WHERE offerta=0";
            fatturazione.ExecQuery(sql);
            if (fatturazione.RecordCount > 0)
            {
                return true;
            }
            return false;
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

