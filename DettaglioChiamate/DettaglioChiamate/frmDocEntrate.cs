using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace DettagliChiamate
{
    public partial class FormfrmDocEntrate : Form
    {

        // string connection = "Server=LAPTOP-8OH69FI3\\SQLEXPRESS01;Database=kongnew;Trusted_Connection=True;Encrypt=false";
        const string connection = "Server=VMWARE\\MSSQLSERVER2019;Database=kongNew;Trusted_Connection=True;Encrypt=false;";

        SQLControl tblufficio = new SQLControl();
        DataTable dt = new DataTable();
       

        public FormfrmDocEntrate()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown.Maximum = DateTime.Now.Year - 1;
            numericUpDown.Value = DateTime.Now.Year - 1;
            numericUpDown.Minimum = 2015;

            bpbBox.Visible = false;
            bntElabora.Visible = false;
            bntLog.Visible = false;
            bntCrea.Visible = false;
            File.Delete(pathDocument());

        }

        private void bpbBox_Enter(object sender, EventArgs e)
        {

        }

       

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            dt.Clear();

            bpbBox.Visible = false;
            bntLog.Visible = false;
        }

        private void bntEstrai_Click(object sender, EventArgs e)
        {
            bntCrea.Visible = false;
            bntLog.Visible = false;
            bntElabora.Visible = false;
            bntLog.Visible = false;
            bpbBox.Visible = false;
            estrai();
        }


        private bool estrai()
        {
            Cursor = Cursors.WaitCursor;
            //creazione di un dataTable e visibile in griglia
            DataTable dt = new DataTable();
            tblufficio = new SQLControl(connection);
            tblufficio.AddParam("@anno", numericUpDown.Value);
            tblufficio.ExecQuery("select * from voipdettaglio");


            if (tblufficio.HasException(true))
            {
                MessageBox.Show("La tabella Dettagli ha generato un errore");
                Cursor = Cursors.Default;
                return true;
            }

            dt = tblufficio.DBDT;

            if (dt.Rows.Count == 0)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("La tabella dettagli non sono presenti dati");
                return true;

            }

            dataGridView1.DataSource = dt;
            bntElabora.Visible = true;
            Cursor = Cursors.Default;
            return true;
        }

        private void bntElabora_Click(object sender, EventArgs e)
        {
            bntCrea.Visible = false;
            bntLog.Visible = false;
            bpbBox.Visible = false;
            elabora("sp_creazioneTabellaUfficio", "ufficio");
            creaFileLog();

        }


        private bool elabora(string procedure, string tabella)
        {
            Cursor = Cursors.WaitCursor;
            dt.Clear();
            tblufficio = new SQLControl(connection);
            tblufficio.AddParam("@anno", numericUpDown.Value);
            tblufficio.ExecStoredProcedure("sp_creazioneTabellaUfficio");



            if (tblufficio.HasException(true))
            {
                Cursor = Cursors.Default;
                MessageBox.Show("errore nella procedura");
                return true;

            }





            tblufficio = new SQLControl(connection);
            tblufficio.ExecQuery("select * from " + tabella);

            if (tblufficio.HasException(true))
            {
                MessageBox.Show("Errore di connessione alla tabella " + tabella);
                Cursor = Cursors.Default;
            }

            dt = tblufficio.DBDT;

            if (dt.Rows.Count == 0)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("la tabella non presenta dati al suo interno");
                return false;

            }




            Cursor = Cursors.Default;

            return true;
        }


        private void creaFileLog()
        {
            Cursor = Cursors.WaitCursor;
            string path = pathDocument();

            int rowCount = 0; // Contatore per le righe

            try
            {
                using (SqlConnection cnn = new SqlConnection(connection))
                {
                    cnn.Open();

                    // Esecuzione della stored procedure
                    using (SqlCommand command = new SqlCommand("sp_filediLog", cnn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Utilizzo SqlDataReader per leggere i dati restituiti dalla stored procedure
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // StreamWriter per scrivere i risultati in un file
                            using (StreamWriter writer = new StreamWriter(path, false)) // Imposta append a false per sovrascrivere il file esistente
                            {
                                while (reader.Read())
                                {

                                    writer.Write("Codice fiscale:");
                                    writer.Write(reader.GetValue(0).ToString());
                                    string erroreDati = reader.GetValue(9).ToString().Substring(0, reader.GetValue(9).ToString().Length - 1);

                                    writer.Write(" dati da correggere perchè non inseriti correttamente:" + erroreDati);



                                    writer.WriteLine(); // Passa alla nuova riga dopo ogni record
                                    rowCount++; // Incrementa il contatore di righe per ogni riga letta
                                }
                            }
                        }
                    }
                }

                // Messaggio di conferma sul numero di righe scritte nel file
                if (rowCount > 0)
                {
                    bntLog.Visible = true;
                    bpbBox.Visible = false;
                    bntElabora.Visible = false;
                    MessageBox.Show($"Sono state scritte {rowCount} righe nel file di log.", "Operazione completata", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Cursor = Cursors.Default;

                }
                else
                {
                    bpbBox.Visible = true;
                    bntElabora.Visible = false;
                    bntLog.Visible = false;
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                // Gestione delle eccezioni mostrando un messaggio di errore
                MessageBox.Show("Errore durante l'elaborazione: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }


        private string pathDocument()
        {




            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string pathLog = path + @"\log.txt";

            return pathLog;



        }

        private void bntLog_Click(object sender, EventArgs e)
        {
            bntCrea.Visible = false;
            string path = pathDocument();
            Cursor = Cursors.WaitCursor;
            if (File.Exists(path))
            {
                try
                {
                    Process.Start(new ProcessStartInfo("notepad.exe", path) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Non è possibile aprire il file di log: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Il file di log non esiste.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Default;
        }


        private void bntEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void bntPath_Click(object sender, EventArgs e)
        {
            bntCrea.Visible = true;



            SaveFileDialog path = new SaveFileDialog();
            if (path.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = path.FileName;
            }
        }



        private void bntCrea_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            string dataAll = data.ToString("yyyy-MM-dd");
            string fileTxt = textBox1.Text + numericUpDown.Value.ToString() + "(" + dataAll + ")" + ".txt";
            if (string.IsNullOrEmpty(textBox1.Text) == false)
            {
                creaFile();

            }
            else
            {
                MessageBox.Show("inserire un path nell'apposito spazio");
                bntCrea.Visible = false;
            }


        }



        private void creaFile()
        {
            Cursor = Cursors.WaitCursor;


            string testa = $"0TEL00220{creaSpazi(17)}01405980531{creaSpazi(5)}ETRURIAWIFI S.R.L.{creaSpazi(42)}CAPALBIO{creaSpazi(32)}GR{creaSpazi(95)}" + numericUpDown.Value + $"{creaSpazi(1554)}A";


            string coda = $"9TEL00220{creaSpazi(17)}01405980531{creaSpazi(5)}ETRURIAWIFI S.R.L.{creaSpazi(42)}CAPALBIO{creaSpazi(32)}GR{creaSpazi(95)}" + numericUpDown.Value + $"{creaSpazi(1554)}A";

            DateTime data = DateTime.Now;
            string dataAll = data.ToString("yyyy-MM-dd");
            string fileTxt = textBox1.Text + numericUpDown.Value.ToString() + "(" + dataAll + ")" + ".txt";


            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string query = "SELECT * FROM ufficio";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                StreamWriter writer = new StreamWriter(fileTxt);
                {

                    writer.Write(testa);
                    writer.WriteLine();
                    while (reader.Read())
                    {
                        int posizione = 1801;
                        for (int i = 0; i < reader.FieldCount - 1; i++)
                        {



                            if (posizione.Equals(i))
                            {
                                posizione = 0;
                                writer.WriteLine();
                                continue;
                            }

                            int numcolonna = reader.GetSchemaTable().Rows[i].Field<int>("ColumnSize");
                            string valoreCampo = reader[i].ToString().ToUpper();

                            writer.Write(valoreCampo.PadRight(numcolonna, ' '));


                        }

                        writer.WriteLine();
                    }

                    writer.Write(coda);
                    writer.Close();
                }

                bntCrea.Visible = false;

                Cursor = Cursors.Default;

                MessageBox.Show("Il file creato e' stato salvato correttamente");

            }




        }
        private string creaSpazi(int lunghezza)
        {
            return new string(' ', lunghezza);
        }

        private void bntElabora_Click_1(object sender, EventArgs e)
        {
            bntCrea.Visible = false;
            bntLog.Visible = false;
            bpbBox.Visible = false;
            elabora("sp_creazioneTabellaUfficio", "ufficio");
            creaFileLog();
        }

        private void bntLog_Click_1(object sender, EventArgs e)
        {

            bntCrea.Visible = false;
            string path = pathDocument();
            Cursor = Cursors.WaitCursor;
            if (File.Exists(path))
            {
                try
                {
                    Process.Start(new ProcessStartInfo("notepad.exe", path) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Non è possibile aprire il file di log: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Il file di log non esiste.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Default;
        }
    }
}
