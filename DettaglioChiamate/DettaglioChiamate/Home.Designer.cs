namespace DettagliChiamate
{
    partial class FrHome
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.elencoChiamateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ufficioDelleEntrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaChiamatePerClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fatturazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elencoChiamateToolStripMenuItem,
            this.ufficioDelleEntrateToolStripMenuItem,
            this.listaChiamatePerClienteToolStripMenuItem,
            this.fatturazioneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // elencoChiamateToolStripMenuItem
            // 
            this.elencoChiamateToolStripMenuItem.Name = "elencoChiamateToolStripMenuItem";
            this.elencoChiamateToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.elencoChiamateToolStripMenuItem.Text = "Elenco Chiamate";
            this.elencoChiamateToolStripMenuItem.Click += new System.EventHandler(this.elencoChiamateToolStripMenuItem_Click);
            // 
            // ufficioDelleEntrateToolStripMenuItem
            // 
            this.ufficioDelleEntrateToolStripMenuItem.Name = "ufficioDelleEntrateToolStripMenuItem";
            this.ufficioDelleEntrateToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.ufficioDelleEntrateToolStripMenuItem.Text = "Ufficio delle Entrate";
            this.ufficioDelleEntrateToolStripMenuItem.Click += new System.EventHandler(this.ufficioDelleEntrateToolStripMenuItem_Click);
            // 
            // listaChiamatePerClienteToolStripMenuItem
            // 
            this.listaChiamatePerClienteToolStripMenuItem.Name = "listaChiamatePerClienteToolStripMenuItem";
            this.listaChiamatePerClienteToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.listaChiamatePerClienteToolStripMenuItem.Text = "Lista Chiamate per Cliente";
            this.listaChiamatePerClienteToolStripMenuItem.Click += new System.EventHandler(this.listaChiamatePerClienteToolStripMenuItem_Click);
            // 
            // fatturazioneToolStripMenuItem
            // 
            this.fatturazioneToolStripMenuItem.Name = "fatturazioneToolStripMenuItem";
            this.fatturazioneToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.fatturazioneToolStripMenuItem.Text = "Fatturazione";
            // 
            // FrHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrHome";
            this.Text = "Dettagli Chiama";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem elencoChiamateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ufficioDelleEntrateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaChiamatePerClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fatturazioneToolStripMenuItem;
    }
}

