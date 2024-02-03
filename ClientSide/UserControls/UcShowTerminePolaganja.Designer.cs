namespace ClientSide.UserControls
{
    partial class UcShowTerminePolaganja
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
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            this.cmbIspit = new System.Windows.Forms.ComboBox();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnRaspored = new System.Windows.Forms.Button();
            this.btnShowRaspored = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrikaz
            // 
            this.dgvPrikaz.AllowUserToAddRows = false;
            this.dgvPrikaz.AllowUserToDeleteRows = false;
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.Location = new System.Drawing.Point(62, 109);
            this.dgvPrikaz.MultiSelect = false;
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.ReadOnly = true;
            this.dgvPrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikaz.Size = new System.Drawing.Size(526, 197);
            this.dgvPrikaz.TabIndex = 0;
            // 
            // cmbIspit
            // 
            this.cmbIspit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIspit.FormattingEnabled = true;
            this.cmbIspit.Location = new System.Drawing.Point(62, 60);
            this.cmbIspit.Name = "cmbIspit";
            this.cmbIspit.Size = new System.Drawing.Size(169, 21);
            this.cmbIspit.TabIndex = 1;
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Location = new System.Drawing.Point(89, 34);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(46, 13);
            this.lblPredmet.TabIndex = 2;
            this.lblPredmet.Text = "Predmet";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(257, 58);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 5;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // btnRaspored
            // 
            this.btnRaspored.Location = new System.Drawing.Point(62, 345);
            this.btnRaspored.Name = "btnRaspored";
            this.btnRaspored.Size = new System.Drawing.Size(106, 23);
            this.btnRaspored.TabIndex = 8;
            this.btnRaspored.Text = "Kreiraj Raspored ";
            this.btnRaspored.UseVisualStyleBackColor = true;
            // 
            // btnShowRaspored
            // 
            this.btnShowRaspored.Location = new System.Drawing.Point(186, 345);
            this.btnShowRaspored.Name = "btnShowRaspored";
            this.btnShowRaspored.Size = new System.Drawing.Size(107, 23);
            this.btnShowRaspored.TabIndex = 9;
            this.btnShowRaspored.Text = "Prikazi Raspored";
            this.btnShowRaspored.UseVisualStyleBackColor = true;
            // 
            // UcShowTerminePolaganja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowRaspored);
            this.Controls.Add(this.btnRaspored);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblPredmet);
            this.Controls.Add(this.cmbIspit);
            this.Controls.Add(this.dgvPrikaz);
            this.Name = "UcShowTerminePolaganja";
            this.Size = new System.Drawing.Size(658, 566);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvPrikaz;
        public System.Windows.Forms.ComboBox cmbIspit;
        public System.Windows.Forms.Label lblPredmet;
        public System.Windows.Forms.Button btnPretrazi;
        public System.Windows.Forms.Button btnRaspored;
        public System.Windows.Forms.Button btnShowRaspored;
    }
}
