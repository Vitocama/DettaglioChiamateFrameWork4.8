
using DettaglioChiamate;
using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;




namespace DettagliChiamate
{
    public partial class FrHome : Form
    {



        public FrHome()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void elencoChiamateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaDettaglio list = new FrmListaDettaglio();
            list.Show();
        }

        private void ufficioDelleEntrateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormfrmDocEntrate doc = new FormfrmDocEntrate();
            doc.Show();
           

        }

        private void listaChiamatePerClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmElencoChiamatePerCliente _ElencoChiamatePerCliente = new frmElencoChiamatePerCliente();
            _ElencoChiamatePerCliente.Show();
        }
    }

    internal class FrmdocEntrate
    {
    }
}
