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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwTermini = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnPrijavi = new System.Windows.Forms.Button();
            this.btnOdjavi = new System.Windows.Forms.Button();
            this.cmbIspit = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgwDodati = new System.Windows.Forms.DataGridView();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.dgwPrijavljeni = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTermini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDodati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrijavljeni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTermini
            // 
            this.dgwTermini.AllowUserToAddRows = false;
            this.dgwTermini.AllowUserToDeleteRows = false;
            this.dgwTermini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTermini.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgwTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwTermini.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgwTermini.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dgwTermini.Location = new System.Drawing.Point(12, 116);
            this.dgwTermini.MultiSelect = false;
            this.dgwTermini.Name = "dgwTermini";
            this.dgwTermini.ReadOnly = true;
            this.dgwTermini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTermini.Size = new System.Drawing.Size(729, 157);
            this.dgwTermini.TabIndex = 0;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(211, 69);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(87, 30);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnPrijavi
            // 
            this.btnPrijavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijavi.Location = new System.Drawing.Point(304, 69);
            this.btnPrijavi.Name = "btnPrijavi";
            this.btnPrijavi.Size = new System.Drawing.Size(116, 30);
            this.btnPrijavi.TabIndex = 4;
            this.btnPrijavi.Text = "Prijavi izlazaske";
            this.btnPrijavi.UseVisualStyleBackColor = true;
            this.btnPrijavi.Click += new System.EventHandler(this.btnPrijavi_Click);
            // 
            // btnOdjavi
            // 
            this.btnOdjavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjavi.Location = new System.Drawing.Point(426, 69);
            this.btnOdjavi.Name = "btnOdjavi";
            this.btnOdjavi.Size = new System.Drawing.Size(118, 30);
            this.btnOdjavi.TabIndex = 5;
            this.btnOdjavi.Text = "Odjavi izlaske";
            this.btnOdjavi.UseVisualStyleBackColor = true;
            // 
            // cmbIspit
            // 
            this.cmbIspit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIspit.FormattingEnabled = true;
            this.cmbIspit.Location = new System.Drawing.Point(29, 75);
            this.cmbIspit.Name = "cmbIspit";
            this.cmbIspit.Size = new System.Drawing.Size(165, 24);
            this.cmbIspit.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(16, 289);
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
            this.dgwDodati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDodati.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgwDodati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDodati.Location = new System.Drawing.Point(12, 318);
            this.dgwDodati.MultiSelect = false;
            this.dgwDodati.Name = "dgwDodati";
            this.dgwDodati.ReadOnly = true;
            this.dgwDodati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDodati.Size = new System.Drawing.Size(729, 126);
            this.dgwDodati.TabIndex = 9;
            // 
            // btnUkloni
            // 
            this.btnUkloni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloni.Location = new System.Drawing.Point(97, 289);
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
            this.dgwPrijavljeni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPrijavljeni.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgwPrijavljeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrijavljeni.Location = new System.Drawing.Point(12, 500);
            this.dgwPrijavljeni.Name = "dgwPrijavljeni";
            this.dgwPrijavljeni.ReadOnly = true;
            this.dgwPrijavljeni.Size = new System.Drawing.Size(729, 150);
            this.dgwPrijavljeni.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Prijavljeni";
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(762, 671);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwPrijavljeni);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.dgwDodati);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbIspit);
            this.Controls.Add(this.btnOdjavi);
            this.Controls.Add(this.btnPrijavi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgwTermini);
            this.Name = "FrmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTermini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDodati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrijavljeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgwTermini;
        public System.Windows.Forms.Button btnPretrazi;
        public System.Windows.Forms.Button btnPrijavi;
        public System.Windows.Forms.Button btnOdjavi;
        public System.Windows.Forms.ComboBox cmbIspit;
        public System.Windows.Forms.Button btnDodaj;
        public System.Windows.Forms.DataGridView dgwDodati;
        public System.Windows.Forms.Button btnUkloni;
        public System.Windows.Forms.DataGridView dgwPrijavljeni;
        private System.Windows.Forms.Label label1;
    }
}