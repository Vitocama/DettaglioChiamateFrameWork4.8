using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;



namespace DettagliChiamate
{
    public partial class FrmListaDettaglio : Form
    {
        DataTable dt = new DataTable();


        //const string connectionString = "Server=LAPTOP-8OH69FI3\\SQLEXPRESS01;Database=voip;Trusted_Connection=True;Encrypt=false";
        //const string connection = "Server=VMWARE;Database=VOIP1;Trusted_Connection=True;Encrypt=false;";
        //private string connection = System.Configuration.ConfigurationManager.ConnectionStrings["cnKong"].ConnectionString;

        const string connection = "Server=VMWARE\\MSSQLSERVER2019;Database=kongNew;Trusted_Connection=True;Encrypt=false;";
        SQLControl Voip = new SQLControl();
        string Sql = "";
        public FrmListaDettaglio()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                MessageBox.Show("La data iniziale e' piu grande di quella finale");

                return;
            }


            if (string.IsNullOrEmpty(txtCodiceCliente.Text))
            {
                MessageBox.Show("inserire il codice cliente");
                return;
            }



            elaboraPerAnnoCodCli();

        }

        private void elaboraPerAnnoCodCli()
        {
            dt.Clear();
            Cursor = Cursors.WaitCursor;
            SQLControl controlloUtente = new SQLControl(connection);
            string sql = @"select  top 1* from contratti where CodCli=@codcli";
            controlloUtente.AddParam("@codcli", txtCodiceCliente.Text);
            controlloUtente.ExecQuery(sql);
            if (controlloUtente.HasException(true))
            {
                Cursor = Cursors.Default;
                MessageBox.Show("errore di connessione al dataBase");
                return;
            }
            if (controlloUtente.RecordCount == 0)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("utente non presente");
                return;
            }



            SQLControl Voip = new SQLControl(connection);





            Sql = @" DELETE FROM voipDettaglioChiamate";

            Voip.ExecQuery(Sql);

            if (Voip.HasException(true))
            {
                Cursor = Cursors.Default;
                MessageBox.Show("errore di connessione");
                return;
            }




            Sql = @"
        INSERT INTO voipDettaglioChiamate (orachiamata, data, chiamante, prefisso, chiamato, durata, tipo, idContratto, CodCli, Nome)
     SELECT voipdettaglio.orachiamata, voipdettaglio.data, voipdettaglio.chiamante, voipdettaglio.prefisso, voipdettaglio.chiamato, voipdettaglio.durata, voipdettaglio.tipo, Contratti.IdContratto, Contratti.CodCli, VoipContratti.nome
     FROM voipdettaglio 
     INNER JOIN voipContratti ON voipdettaglio.chiamante = voipContratti.voip 
     INNER JOIN Contratti ON VoipContratti.id = Contratti.IdContratto
        WHERE data BETWEEN @dataInizio AND @dataFine;
        ";


            Voip.AddParam("@dataInizio", dateTimePicker1.Value.Date);
            Voip.AddParam("@dataFine", dateTimePicker2.Value.Date);

            Voip.ExecQuery(Sql);

            if (Voip.HasException(true))
            {
                Cursor.Current = Cursors.Default;
                return;
            }








            Sql = @"
     INSERT INTO voipDettaglioChiamate (orachiamata, data, chiamante, prefisso, chiamato, durata, tipo, idContratto, CodCli, Nome)
SELECT voipdettaglio.orachiamata, voipdettaglio.data, voipdettaglio.chiamante, voipdettaglio.prefisso, voipdettaglio.chiamato, voipdettaglio.durata, voipdettaglio.tipo, Contratti.IdContratto, Contratti.CodCli, VoipContratti.nome
FROM voipdettaglio 
 JOIN voipContratti ON voipdettaglio.chiamante = voipContratti.portabilita
 JOIN Contratti ON VoipContratti.id = Contratti.IdContratto
        WHERE data BETWEEN @dataInizio AND @dataFine;
        ";

            Voip.AddParam("@dataInizio", dateTimePicker1.Value.Date);
            Voip.AddParam("@dataFine", dateTimePicker2.Value.Date);

            Voip.ExecQuery(Sql);

            if (Voip.HasException(true))
            {
                Cursor.Current = Cursors.Default;
                return;
            }

            Sql = @"
        DELETE FROM voipDettaglioChiamate WHERE CodCli <> @codCli;
    ";

            Voip.AddParam("@codCli", txtCodiceCliente.Text.ToUpper());


            Voip.ExecQuery(Sql);

            if (Voip.HasException(true))
            {
                Cursor.Current = Cursors.Default;
                return;
            }


            Cursor.Current = Cursors.Default;

            Sql = " Select * from voipDettaglioChiamate order by Data,OraChiamata";

            Voip.ExecQuery(Sql);

            if (Voip.HasException(true))
            {
                Cursor.Current = Cursors.Default;
                return;
            }

            if (Voip.RecordCount == 0)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Dati richiesti non presenti");
                return;

            }

            dt = Voip.DBDT;



            if (dt.Rows.Count > 0)
            {

                dataGridView1.DataSource = dt;

            }




        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListaDettaglio_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime datemin = new DateTime(2000, 12, 31);
            if (dateTimePicker1.MinDate == datemin)
            {
                return;
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {


            // Assegna la data formattata al TextBox

            DateTime datemin = new DateTime(2000, 12, 31);
            dateTimePicker2.MinDate = datemin;
            DateTime dataodierna = DateTime.Now;
            if (dateTimePicker2.Value.Date > dataodierna.Date)
            {

                MessageBox.Show("non è possibile impostare una data maggiore della data odierna");
                return;
            }


        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                MessageBox.Show("La data iniziale e' piu grande di quella finale");

                return;
            }


            if (string.IsNullOrEmpty(txtCodiceCliente.Text))
            {
                MessageBox.Show("inserire il codice cliente");
                return;
            }



            elaboraPerAnnoCodCli();

        }
    }
}

namespace System.Configuration
{
    class ConfigurationManager
    {
    }
}