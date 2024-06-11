namespace DettagliChiamate
{
    partial class FormfrmDocEntrate
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
            this.lblAnno = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bpbBox = new System.Windows.Forms.GroupBox();
            this.bntPath = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bntCrea = new System.Windows.Forms.Button();
            this.bntEsci = new System.Windows.Forms.Button();
            this.bntLog = new System.Windows.Forms.Button();
            this.bntElabora = new System.Windows.Forms.Button();
            this.bntEstrai = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.bpbBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnno
            // 
            this.lblAnno.AutoSize = true;
            this.lblAnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnno.Location = new System.Drawing.Point(29, 32);
            this.lblAnno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnno.Name = "lblAnno";
            this.lblAnno.Size = new System.Drawing.Size(159, 20);
            this.lblAnno.TabIndex = 0;
            this.lblAnno.Text = "SELEZIONE ANNO:";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(252, 26);
            this.numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(160, 26);
            this.numericUpDown.TabIndex = 1;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // bpbBox
            // 
            this.bpbBox.Controls.Add(this.bntPath);
            this.bpbBox.Controls.Add(this.textBox1);
            this.bpbBox.Location = new System.Drawing.Point(771, 26);
            this.bpbBox.Margin = new System.Windows.Forms.Padding(4);
            this.bpbBox.Name = "bpbBox";
            this.bpbBox.Padding = new System.Windows.Forms.Padding(4);
            this.bpbBox.Size = new System.Drawing.Size(424, 97);
            this.bpbBox.TabIndex = 3;
            this.bpbBox.TabStop = false;
            this.bpbBox.Text = "SALVATAGGIO FILE";
            this.bpbBox.Enter += new System.EventHandler(this.bpbBox_Enter);
            // 
            // bntPath
            // 
            this.bntPath.Location = new System.Drawing.Point(277, 31);
            this.bntPath.Margin = new System.Windows.Forms.Padding(4);
            this.bntPath.Name = "bntPath";
            this.bntPath.Size = new System.Drawing.Size(100, 28);
            this.bntPath.TabIndex = 1;
            this.bntPath.Text = " ...";
            this.bntPath.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 0;
            // 
            // bntCrea
            // 
            this.bntCrea.Location = new System.Drawing.Point(1261, 46);
            this.bntCrea.Margin = new System.Windows.Forms.Padding(4);
            this.bntCrea.Name = "bntCrea";
            this.bntCrea.Size = new System.Drawing.Size(112, 62);
            this.bntCrea.TabIndex = 4;
            this.bntCrea.Text = "CREA";
            this.bntCrea.UseVisualStyleBackColor = true;
            // 
            // bntEsci
            // 
            this.bntEsci.Location = new System.Drawing.Point(1261, 587);
            this.bntEsci.Margin = new System.Windows.Forms.Padding(4);
            this.bntEsci.Name = "bntEsci";
            this.bntEsci.Size = new System.Drawing.Size(112, 62);
            this.bntEsci.TabIndex = 5;
            this.bntEsci.Text = "ESCI";
            this.bntEsci.UseVisualStyleBackColor = true;
            // 
            // bntLog
            // 
            this.bntLog.Location = new System.Drawing.Point(375, 567);
            this.bntLog.Margin = new System.Windows.Forms.Padding(4);
            this.bntLog.Name = "bntLog";
            this.bntLog.Size = new System.Drawing.Size(112, 62);
            this.bntLog.TabIndex = 6;
            this.bntLog.Text = "LOG";
            this.bntLog.UseVisualStyleBackColor = true;
            this.bntLog.Click += new System.EventHandler(this.bntLog_Click_1);
            // 
            // bntElabora
            // 
            this.bntElabora.Location = new System.Drawing.Point(184, 567);
            this.bntElabora.Margin = new System.Windows.Forms.Padding(4);
            this.bntElabora.Name = "bntElabora";
            this.bntElabora.Size = new System.Drawing.Size(140, 62);
            this.bntElabora.TabIndex = 7;
            this.bntElabora.Text = "ELEBORAZIONE";
            this.bntElabora.UseVisualStyleBackColor = true;
            this.bntElabora.Click += new System.EventHandler(this.bntElabora_Click_1);
            // 
            // bntEstrai
            // 
            this.bntEstrai.Location = new System.Drawing.Point(33, 567);
            this.bntEstrai.Margin = new System.Windows.Forms.Padding(4);
            this.bntEstrai.Name = "bntEstrai";
            this.bntEstrai.Size = new System.Drawing.Size(112, 62);
            this.bntEstrai.TabIndex = 8;
            this.bntEstrai.Text = "ESTRAI";
            this.bntEstrai.UseVisualStyleBackColor = true;
            this.bntEstrai.Click += new System.EventHandler(this.bntEstrai_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-176, 153);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1549, 391);
            this.dataGridView1.TabIndex = 9;
            // 
            // FormfrmDocEntrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bntEstrai);
            this.Controls.Add(this.bntElabora);
            this.Controls.Add(this.bntLog);
            this.Controls.Add(this.bntEsci);
            this.Controls.Add(this.bntCrea);
            this.Controls.Add(this.bpbBox);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.lblAnno);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormfrmDocEntrate";
            this.Text = "FileDocumentoEntrate";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.bpbBox.ResumeLayout(false);
            this.bpbBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnno;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.GroupBox bpbBox;
        private System.Windows.Forms.Button bntPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bntCrea;
        private System.Windows.Forms.Button bntEsci;
        private System.Windows.Forms.Button bntLog;
        private System.Windows.Forms.Button bntElabora;
        private System.Windows.Forms.Button bntEstrai;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}