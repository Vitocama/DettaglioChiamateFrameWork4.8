namespace DettaglioChiamate
{
    partial class FrmFatturazione
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
            this.gbxPeriodo = new System.Windows.Forms.GroupBox();
            this.dtpDataFatturazione = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewListaClienti = new System.Windows.Forms.DataGridView();
            this.cmdEstrai = new System.Windows.Forms.Button();
            this.cmdesci = new System.Windows.Forms.Button();
            this.gbxPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPeriodo
            // 
            this.gbxPeriodo.Controls.Add(this.dtpDataFatturazione);
            this.gbxPeriodo.Controls.Add(this.label1);
            this.gbxPeriodo.Location = new System.Drawing.Point(12, 52);
            this.gbxPeriodo.Name = "gbxPeriodo";
            this.gbxPeriodo.Size = new System.Drawing.Size(250, 46);
            this.gbxPeriodo.TabIndex = 0;
            this.gbxPeriodo.TabStop = false;
            // 
            // dtpDataFatturazione
            // 
            this.dtpDataFatturazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFatturazione.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFatturazione.Location = new System.Drawing.Point(125, 16);
            this.dtpDataFatturazione.Name = "dtpDataFatturazione";
            this.dtpDataFatturazione.Size = new System.Drawing.Size(104, 21);
            this.dtpDataFatturazione.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data di Riferimento";
            // 
            // dataGridViewListaClienti
            // 
            this.dataGridViewListaClienti.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewListaClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaClienti.Location = new System.Drawing.Point(12, 121);
            this.dataGridViewListaClienti.Name = "dataGridViewListaClienti";
            this.dataGridViewListaClienti.Size = new System.Drawing.Size(710, 254);
            this.dataGridViewListaClienti.TabIndex = 2;
            this.dataGridViewListaClienti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmdEstrai
            // 
            this.cmdEstrai.Location = new System.Drawing.Point(12, 401);
            this.cmdEstrai.Name = "cmdEstrai";
            this.cmdEstrai.Size = new System.Drawing.Size(75, 37);
            this.cmdEstrai.TabIndex = 3;
            this.cmdEstrai.Text = "Estrai";
            this.cmdEstrai.UseVisualStyleBackColor = true;
            this.cmdEstrai.Click += new System.EventHandler(this.cmdEstrai_Click);
            // 
            // cmdesci
            // 
            this.cmdesci.Location = new System.Drawing.Point(647, 401);
            this.cmdesci.Name = "cmdesci";
            this.cmdesci.Size = new System.Drawing.Size(75, 37);
            this.cmdesci.TabIndex = 4;
            this.cmdesci.Text = "Esci";
            this.cmdesci.UseVisualStyleBackColor = true;
            // 
            // FrmFatturazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdesci);
            this.Controls.Add(this.cmdEstrai);
            this.Controls.Add(this.dataGridViewListaClienti);
            this.Controls.Add(this.gbxPeriodo);
            this.Name = "FrmFatturazione";
            this.Text = "Fatturazione";
            this.Load += new System.EventHandler(this.FormFrmFatturazione_Load);
            this.gbxPeriodo.ResumeLayout(false);
            this.gbxPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPeriodo;
        private System.Windows.Forms.DateTimePicker dtpDataFatturazione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewListaClienti;
        private System.Windows.Forms.Button cmdEstrai;
        private System.Windows.Forms.Button cmdesci;
    }
}