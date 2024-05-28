namespace DettaglioChiamate
{
    partial class frmElencoChiamatePerCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataFatturazione = new System.Windows.Forms.DateTimePicker();
            this.dtpFine = new System.Windows.Forms.DateTimePicker();
            this.txtCli = new System.Windows.Forms.TextBox();
            this.dtpInizio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.chkseleziona = new System.Windows.Forms.CheckBox();
            this.gbxPeriodo = new System.Windows.Forms.GroupBox();
            this.cmdDati = new System.Windows.Forms.Button();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.chkListContratti = new System.Windows.Forms.CheckedListBox();
            this.dataGridViewListaClienti = new System.Windows.Forms.DataGridView();
            this.cmdEstrai = new System.Windows.Forms.Button();
            this.cmdEsci = new System.Windows.Forms.Button();
            this.gbxPeriodo.SuspendLayout();
            this.gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data di Riferimento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codice Cliente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpDataFatturazione
            // 
            this.dtpDataFatturazione.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFatturazione.Location = new System.Drawing.Point(148, 22);
            this.dtpDataFatturazione.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataFatturazione.Name = "dtpDataFatturazione";
            this.dtpDataFatturazione.Size = new System.Drawing.Size(99, 21);
            this.dtpDataFatturazione.TabIndex = 3;
            this.dtpDataFatturazione.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpFine
            // 
            this.dtpFine.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFine.Location = new System.Drawing.Point(536, 24);
            this.dtpFine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFine.Name = "dtpFine";
            this.dtpFine.Size = new System.Drawing.Size(104, 20);
            this.dtpFine.TabIndex = 4;
            this.dtpFine.ValueChanged += new System.EventHandler(this.dtpFine_ValueChanged);
            // 
            // txtCli
            // 
            this.txtCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtCli.Location = new System.Drawing.Point(121, 35);
            this.txtCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCli.Name = "txtCli";
            this.txtCli.Size = new System.Drawing.Size(93, 21);
            this.txtCli.TabIndex = 5;
            this.txtCli.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtpInizio
            // 
            this.dtpInizio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInizio.Location = new System.Drawing.Point(431, 24);
            this.dtpInizio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpInizio.Name = "dtpInizio";
            this.dtpInizio.Size = new System.Drawing.Size(101, 20);
            this.dtpInizio.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Periodo :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chkseleziona
            // 
            this.chkseleziona.AutoSize = true;
            this.chkseleziona.Location = new System.Drawing.Point(452, 134);
            this.chkseleziona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkseleziona.Name = "chkseleziona";
            this.chkseleziona.Size = new System.Drawing.Size(96, 17);
            this.chkseleziona.TabIndex = 8;
            this.chkseleziona.Text = "Seleziona tutto";
            this.chkseleziona.UseVisualStyleBackColor = true;
            // 
            // gbxPeriodo
            // 
            this.gbxPeriodo.Controls.Add(this.dtpDataFatturazione);
            this.gbxPeriodo.Controls.Add(this.label1);
            this.gbxPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPeriodo.Location = new System.Drawing.Point(61, 12);
            this.gbxPeriodo.Name = "gbxPeriodo";
            this.gbxPeriodo.Size = new System.Drawing.Size(271, 65);
            this.gbxPeriodo.TabIndex = 10;
            this.gbxPeriodo.TabStop = false;
            // 
            // cmdDati
            // 
            this.cmdDati.Location = new System.Drawing.Point(242, 32);
            this.cmdDati.Name = "cmdDati";
            this.cmdDati.Size = new System.Drawing.Size(57, 23);
            this.cmdDati.TabIndex = 11;
            this.cmdDati.Text = "...";
            this.cmdDati.UseVisualStyleBackColor = true;
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.chkListContratti);
            this.gbx.Controls.Add(this.txtCli);
            this.gbx.Controls.Add(this.cmdDati);
            this.gbx.Controls.Add(this.label3);
            this.gbx.Controls.Add(this.chkseleziona);
            this.gbx.Location = new System.Drawing.Point(33, 121);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(788, 160);
            this.gbx.TabIndex = 12;
            this.gbx.TabStop = false;
            // 
            // chkListContratti
            // 
            this.chkListContratti.FormattingEnabled = true;
            this.chkListContratti.Location = new System.Drawing.Point(442, 19);
            this.chkListContratti.Name = "chkListContratti";
            this.chkListContratti.Size = new System.Drawing.Size(120, 94);
            this.chkListContratti.TabIndex = 12;
            this.chkListContratti.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // dataGridViewListaClienti
            // 
            this.dataGridViewListaClienti.AllowUserToAddRows = false;
            this.dataGridViewListaClienti.AllowUserToDeleteRows = false;
            this.dataGridViewListaClienti.AllowUserToOrderColumns = true;
            this.dataGridViewListaClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaClienti.Location = new System.Drawing.Point(33, 316);
            this.dataGridViewListaClienti.Name = "dataGridViewListaClienti";
            this.dataGridViewListaClienti.ReadOnly = true;
            this.dataGridViewListaClienti.Size = new System.Drawing.Size(788, 288);
            this.dataGridViewListaClienti.TabIndex = 13;
            // 
            // cmdEstrai
            // 
            this.cmdEstrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEstrai.Location = new System.Drawing.Point(28, 630);
            this.cmdEstrai.Name = "cmdEstrai";
            this.cmdEstrai.Size = new System.Drawing.Size(86, 40);
            this.cmdEstrai.TabIndex = 14;
            this.cmdEstrai.Text = "Estrai";
            this.cmdEstrai.UseVisualStyleBackColor = true;
            // 
            // cmdEsci
            // 
            this.cmdEsci.Location = new System.Drawing.Point(746, 630);
            this.cmdEsci.Name = "cmdEsci";
            this.cmdEsci.Size = new System.Drawing.Size(75, 40);
            this.cmdEsci.TabIndex = 15;
            this.cmdEsci.Text = "Esci";
            this.cmdEsci.UseVisualStyleBackColor = true;
            // 
            // frmElencoChiamatePerCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 744);
            this.Controls.Add(this.cmdEsci);
            this.Controls.Add(this.cmdEstrai);
            this.Controls.Add(this.dataGridViewListaClienti);
            this.Controls.Add(this.gbx);
            this.Controls.Add(this.gbxPeriodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpInizio);
            this.Controls.Add(this.dtpFine);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmElencoChiamatePerCliente";
            this.Text = "Elenco fatture per Cliente";
            this.gbxPeriodo.ResumeLayout(false);
            this.gbxPeriodo.PerformLayout();
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataFatturazione;
        private System.Windows.Forms.DateTimePicker dtpFine;
        private System.Windows.Forms.TextBox txtCli;
        private System.Windows.Forms.DateTimePicker dtpInizio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkseleziona;
        private System.Windows.Forms.GroupBox gbxPeriodo;
        private System.Windows.Forms.Button cmdDati;
        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.CheckedListBox chkListContratti;
        private System.Windows.Forms.DataGridView dataGridViewListaClienti;
        private System.Windows.Forms.Button cmdEstrai;
        private System.Windows.Forms.Button cmdEsci;
    }
}