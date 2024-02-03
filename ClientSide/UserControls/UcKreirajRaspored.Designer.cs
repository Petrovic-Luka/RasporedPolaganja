namespace ClientSide.UserControls
{
    partial class UcKreirajRaspored
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgwDodateSale = new System.Windows.Forms.DataGridView();
            this.dgwSale = new System.Windows.Forms.DataGridView();
            this.btnDodajSalu = new System.Windows.Forms.Button();
            this.btnUkloniSalu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrijave = new System.Windows.Forms.Label();
            this.lblMesta = new System.Windows.Forms.Label();
            this.btnKreirajRaspored = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDodateSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sala";
            // 
            // dgwDodateSale
            // 
            this.dgwDodateSale.AllowUserToAddRows = false;
            this.dgwDodateSale.AllowUserToDeleteRows = false;
            this.dgwDodateSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDodateSale.Location = new System.Drawing.Point(12, 219);
            this.dgwDodateSale.Name = "dgwDodateSale";
            this.dgwDodateSale.ReadOnly = true;
            this.dgwDodateSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDodateSale.Size = new System.Drawing.Size(358, 112);
            this.dgwDodateSale.TabIndex = 2;
            // 
            // dgwSale
            // 
            this.dgwSale.AllowUserToAddRows = false;
            this.dgwSale.AllowUserToDeleteRows = false;
            this.dgwSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSale.Location = new System.Drawing.Point(12, 84);
            this.dgwSale.Name = "dgwSale";
            this.dgwSale.ReadOnly = true;
            this.dgwSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSale.Size = new System.Drawing.Size(358, 108);
            this.dgwSale.TabIndex = 3;
            // 
            // btnDodajSalu
            // 
            this.btnDodajSalu.Location = new System.Drawing.Point(376, 109);
            this.btnDodajSalu.Name = "btnDodajSalu";
            this.btnDodajSalu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSalu.TabIndex = 4;
            this.btnDodajSalu.Text = "Dodaj";
            this.btnDodajSalu.UseVisualStyleBackColor = true;
            // 
            // btnUkloniSalu
            // 
            this.btnUkloniSalu.Location = new System.Drawing.Point(376, 262);
            this.btnUkloniSalu.Name = "btnUkloniSalu";
            this.btnUkloniSalu.Size = new System.Drawing.Size(75, 23);
            this.btnUkloniSalu.TabIndex = 5;
            this.btnUkloniSalu.Text = "Ukloni";
            this.btnUkloniSalu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Odabrane Sale";
            // 
            // lblPrijave
            // 
            this.lblPrijave.AutoSize = true;
            this.lblPrijave.Location = new System.Drawing.Point(165, 351);
            this.lblPrijave.Name = "lblPrijave";
            this.lblPrijave.Size = new System.Drawing.Size(60, 13);
            this.lblPrijave.TabIndex = 7;
            this.lblPrijave.Text = "Broj Prijava";
            // 
            // lblMesta
            // 
            this.lblMesta.AutoSize = true;
            this.lblMesta.Location = new System.Drawing.Point(285, 351);
            this.lblMesta.Name = "lblMesta";
            this.lblMesta.Size = new System.Drawing.Size(94, 13);
            this.lblMesta.TabIndex = 8;
            this.lblMesta.Text = "Odabrano mesta 0";
            // 
            // btnKreirajRaspored
            // 
            this.btnKreirajRaspored.Location = new System.Drawing.Point(12, 351);
            this.btnKreirajRaspored.Name = "btnKreirajRaspored";
            this.btnKreirajRaspored.Size = new System.Drawing.Size(111, 23);
            this.btnKreirajRaspored.TabIndex = 9;
            this.btnKreirajRaspored.Text = "Napravi raspored";
            this.btnKreirajRaspored.UseVisualStyleBackColor = true;
            // 
            // UcKreirajRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKreirajRaspored);
            this.Controls.Add(this.lblMesta);
            this.Controls.Add(this.lblPrijave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUkloniSalu);
            this.Controls.Add(this.btnDodajSalu);
            this.Controls.Add(this.dgwSale);
            this.Controls.Add(this.dgwDodateSale);
            this.Controls.Add(this.label1);
            this.Name = "UcKreirajRaspored";
            this.Size = new System.Drawing.Size(725, 443);
            this.Load += new System.EventHandler(this.UcKreirajRaspored_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDodateSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgwDodateSale;
        public System.Windows.Forms.DataGridView dgwSale;
        public System.Windows.Forms.Button btnDodajSalu;
        public System.Windows.Forms.Button btnUkloniSalu;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblPrijave;
        public System.Windows.Forms.Label lblMesta;
        public System.Windows.Forms.Button btnKreirajRaspored;
    }
}
