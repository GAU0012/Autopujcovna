namespace PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader Informace_o_vraceni;
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IdZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum_vypujceni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum_vraceni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Poskozeni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idObjednavky = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Informace_o_vraceni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Informace_o_vraceni
            // 
            Informace_o_vraceni.Text = "Informace_o_vraceni";
            Informace_o_vraceni.Width = 211;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(236, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seznám výpůjček, kde byl poškozen Automobil";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vyber";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(759, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Zpět";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdZ,
            this.Datum_vypujceni,
            this.Datum_vraceni,
            Informace_o_vraceni,
            this.Poskozeni,
            this.Cena,
            this.idObjednavky});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(66, 102);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(809, 244);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IdZ
            // 
            this.IdZ.Text = "idZakaznik";
            // 
            // Datum_vypujceni
            // 
            this.Datum_vypujceni.Text = "Datum_vypujceni";
            this.Datum_vypujceni.Width = 125;
            // 
            // Datum_vraceni
            // 
            this.Datum_vraceni.Text = "Datum_vraceni";
            this.Datum_vraceni.Width = 136;
            // 
            // Poskozeni
            // 
            this.Poskozeni.Text = "Poskozeni";
            this.Poskozeni.Width = 100;
            // 
            // Cena
            // 
            this.Cena.Text = "Cena";
            this.Cena.Width = 72;
            // 
            // idObjednavky
            // 
            this.idObjednavky.Text = "idObjednavky";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 531);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IdZ;
        private System.Windows.Forms.ColumnHeader Datum_vypujceni;
        private System.Windows.Forms.ColumnHeader Datum_vraceni;
        private System.Windows.Forms.ColumnHeader Poskozeni;
        private System.Windows.Forms.ColumnHeader Cena;
        private System.Windows.Forms.ColumnHeader idObjednavky;
    }
}

