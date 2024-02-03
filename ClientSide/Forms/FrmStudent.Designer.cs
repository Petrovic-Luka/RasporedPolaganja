namespace ClientSide.Forms
{
    partial class FrmStudent
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
            this.dgwTermini = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnPrijavi = new System.Windows.Forms.Button();
            this.btnOdjavi = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.cmbIspit = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgwDodati = new System.Windows.Forms.DataGridView();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.dgwPrijavljeni = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTermini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDodati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrijavljeni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTermini
            // 
            this.dgwTermini.AllowUserToAddRows = false;
            this.dgwTermini.AllowUserToDeleteRows = false;
            this.dgwTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTermini.Location = new System.Drawing.Point(84, 96);
            this.dgwTermini.MultiSelect = false;
            this.dgwTermini.Name = "dgwTermini";
            this.dgwTermini.ReadOnly = true;
            this.dgwTermini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTermini.Size = new System.Drawing.Size(671, 157);
            this.dgwTermini.TabIndex = 0;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(223, 65);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnPrijavi
            // 
            this.btnPrijavi.Location = new System.Drawing.Point(304, 65);
            this.btnPrijavi.Name = "btnPrijavi";
            this.btnPrijavi.Size = new System.Drawing.Size(104, 23);
            this.btnPrijavi.TabIndex = 4;
            this.btnPrijavi.Text = "Prijavi izlazaske";
            this.btnPrijavi.UseVisualStyleBackColor = true;
            this.btnPrijavi.Click += new System.EventHandler(this.btnPrijavi_Click);
            // 
            // btnOdjavi
            // 
            this.btnOdjavi.Location = new System.Drawing.Point(414, 65);
            this.btnOdjavi.Name = "btnOdjavi";
            this.btnOdjavi.Size = new System.Drawing.Size(96, 23);
            this.btnOdjavi.TabIndex = 5;
            this.btnOdjavi.Text = "Odjavi izlaske";
            this.btnOdjavi.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(679, 67);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // cmbIspit
            // 
            this.cmbIspit.FormattingEnabled = true;
            this.cmbIspit.Location = new System.Drawing.Point(84, 67);
            this.cmbIspit.Name = "cmbIspit";
            this.cmbIspit.Size = new System.Drawing.Size(133, 21);
            this.cmbIspit.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(85, 269);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // dgwDodati
            // 
            this.dgwDodati.AllowUserToAddRows = false;
            this.dgwDodati.AllowUserToDeleteRows = false;
            this.dgwDodati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDodati.Location = new System.Drawing.Point(84, 298);
            this.dgwDodati.MultiSelect = false;
            this.dgwDodati.Name = "dgwDodati";
            this.dgwDodati.ReadOnly = true;
            this.dgwDodati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDodati.Size = new System.Drawing.Size(670, 126);
            this.dgwDodati.TabIndex = 9;
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(175, 269);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(75, 23);
            this.btnUkloni.TabIndex = 10;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            // 
            // dgwPrijavljeni
            // 
            this.dgwPrijavljeni.AllowUserToAddRows = false;
            this.dgwPrijavljeni.AllowUserToDeleteRows = false;
            this.dgwPrijavljeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrijavljeni.Location = new System.Drawing.Point(85, 480);
            this.dgwPrijavljeni.Name = "dgwPrijavljeni";
            this.dgwPrijavljeni.ReadOnly = true;
            this.dgwPrijavljeni.Size = new System.Drawing.Size(669, 150);
            this.dgwPrijavljeni.TabIndex = 11;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 671);
            this.Controls.Add(this.dgwPrijavljeni);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.dgwDodati);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbIspit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnOdjavi);
            this.Controls.Add(this.btnPrijavi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgwTermini);
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTermini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDodati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrijavljeni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgwTermini;
        public System.Windows.Forms.Button btnPretrazi;
        public System.Windows.Forms.Button btnPrijavi;
        public System.Windows.Forms.Button btnOdjavi;
        public System.Windows.Forms.Button btnLogOut;
        public System.Windows.Forms.ComboBox cmbIspit;
        public System.Windows.Forms.Button btnDodaj;
        public System.Windows.Forms.DataGridView dgwDodati;
        public System.Windows.Forms.Button btnUkloni;
        public System.Windows.Forms.DataGridView dgwPrijavljeni;
    }
}