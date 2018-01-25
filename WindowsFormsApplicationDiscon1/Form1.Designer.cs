namespace WindowsFormsApplicationDiscon1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDataAdapter = new System.Windows.Forms.Button();
            this.buttonDsRead = new System.Windows.Forms.Button();
            this.listBoxAusgabe = new System.Windows.Forms.ListBox();
            this.dataGridViewAusgabe = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonArtikel = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonDBSync = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAusgabe)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDataAdapter
            // 
            this.buttonDataAdapter.Location = new System.Drawing.Point(55, 31);
            this.buttonDataAdapter.Name = "buttonDataAdapter";
            this.buttonDataAdapter.Size = new System.Drawing.Size(230, 48);
            this.buttonDataAdapter.TabIndex = 0;
            this.buttonDataAdapter.Text = "DatenAdapter";
            this.buttonDataAdapter.UseVisualStyleBackColor = true;
            this.buttonDataAdapter.Click += new System.EventHandler(this.buttonDataAdapter_Click);
            // 
            // buttonDsRead
            // 
            this.buttonDsRead.Location = new System.Drawing.Point(55, 125);
            this.buttonDsRead.Name = "buttonDsRead";
            this.buttonDsRead.Size = new System.Drawing.Size(108, 53);
            this.buttonDsRead.TabIndex = 1;
            this.buttonDsRead.Text = "DataSet auslesen / Kunde auslesen";
            this.buttonDsRead.UseVisualStyleBackColor = true;
            this.buttonDsRead.Click += new System.EventHandler(this.buttonDsRead_Click);
            // 
            // listBoxAusgabe
            // 
            this.listBoxAusgabe.FormattingEnabled = true;
            this.listBoxAusgabe.Location = new System.Drawing.Point(315, 31);
            this.listBoxAusgabe.Name = "listBoxAusgabe";
            this.listBoxAusgabe.Size = new System.Drawing.Size(222, 134);
            this.listBoxAusgabe.TabIndex = 2;
            // 
            // dataGridViewAusgabe
            // 
            this.dataGridViewAusgabe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAusgabe.Location = new System.Drawing.Point(64, 229);
            this.dataGridViewAusgabe.Name = "dataGridViewAusgabe";
            this.dataGridViewAusgabe.Size = new System.Drawing.Size(508, 211);
            this.dataGridViewAusgabe.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(600, 270);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(129, 33);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonArtikel
            // 
            this.buttonArtikel.Location = new System.Drawing.Point(180, 125);
            this.buttonArtikel.Name = "buttonArtikel";
            this.buttonArtikel.Size = new System.Drawing.Size(105, 53);
            this.buttonArtikel.TabIndex = 5;
            this.buttonArtikel.Text = "Artikel auslesen";
            this.buttonArtikel.UseVisualStyleBackColor = true;
            this.buttonArtikel.Click += new System.EventHandler(this.buttonArtikel_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(573, 31);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(186, 40);
            this.buttonWrite.TabIndex = 6;
            this.buttonWrite.Text = "Write / Serialisieren";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(573, 91);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(186, 40);
            this.buttonRead.TabIndex = 7;
            this.buttonRead.Text = "Read / Deserialisieren";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonDBSync
            // 
            this.buttonDBSync.Location = new System.Drawing.Point(579, 160);
            this.buttonDBSync.Name = "buttonDBSync";
            this.buttonDBSync.Size = new System.Drawing.Size(179, 30);
            this.buttonDBSync.TabIndex = 8;
            this.buttonDBSync.Text = "Datenbank synchronisieren";
            this.buttonDBSync.UseVisualStyleBackColor = true;
            this.buttonDBSync.Click += new System.EventHandler(this.buttonDBSync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 501);
            this.Controls.Add(this.buttonDBSync);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonArtikel);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dataGridViewAusgabe);
            this.Controls.Add(this.listBoxAusgabe);
            this.Controls.Add(this.buttonDsRead);
            this.Controls.Add(this.buttonDataAdapter);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAusgabe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDataAdapter;
        private System.Windows.Forms.Button buttonDsRead;
        private System.Windows.Forms.ListBox listBoxAusgabe;
        private System.Windows.Forms.DataGridView dataGridViewAusgabe;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonArtikel;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonDBSync;
    }
}

