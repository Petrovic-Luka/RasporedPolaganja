namespace ClientSide.UserControls
{
    partial class UcKreirajStudenta
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIndeks = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblErrorIndeks = new System.Windows.Forms.Label();
            this.lblErrorIme = new System.Windows.Forms.Label();
            this.lblErrorPrezime = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorSifra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(159, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(66, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Broj Indeksa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sifra";
            // 
            // txtIndeks
            // 
            this.txtIndeks.Location = new System.Drawing.Point(144, 51);
            this.txtIndeks.Name = "txtIndeks";
            this.txtIndeks.Size = new System.Drawing.Size(100, 20);
            this.txtIndeks.TabIndex = 5;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(144, 109);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 6;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(144, 166);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 242);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(144, 309);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(100, 20);
            this.txtSifra.TabIndex = 9;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(144, 364);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Napravi nalog";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // lblErrorIndeks
            // 
            this.lblErrorIndeks.AutoSize = true;
            this.lblErrorIndeks.Location = new System.Drawing.Point(129, 74);
            this.lblErrorIndeks.Name = "lblErrorIndeks";
            this.lblErrorIndeks.Size = new System.Drawing.Size(128, 13);
            this.lblErrorIndeks.TabIndex = 11;
            this.lblErrorIndeks.Text = "nepravilan format indeksa";
            this.lblErrorIndeks.Visible = false;
            // 
            // lblErrorIme
            // 
            this.lblErrorIme.AutoSize = true;
            this.lblErrorIme.Location = new System.Drawing.Point(129, 132);
            this.lblErrorIme.Name = "lblErrorIme";
            this.lblErrorIme.Size = new System.Drawing.Size(141, 13);
            this.lblErrorIme.TabIndex = 12;
            this.lblErrorIme.Text = "Ime mora biti bar 2 karaktera";
            this.lblErrorIme.Visible = false;
            // 
            // lblErrorPrezime
            // 
            this.lblErrorPrezime.AutoSize = true;
            this.lblErrorPrezime.Location = new System.Drawing.Point(118, 189);
            this.lblErrorPrezime.Name = "lblErrorPrezime";
            this.lblErrorPrezime.Size = new System.Drawing.Size(161, 13);
            this.lblErrorPrezime.TabIndex = 13;
            this.lblErrorPrezime.Text = "Prezime mora biti bar 2 karaktera";
            this.lblErrorPrezime.Visible = false;
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Location = new System.Drawing.Point(129, 265);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(124, 13);
            this.lblErrorEmail.TabIndex = 14;
            this.lblErrorEmail.Text = "nepravilan format email-a";
            this.lblErrorEmail.Visible = false;
            // 
            // lblErrorSifra
            // 
            this.lblErrorSifra.AutoSize = true;
            this.lblErrorSifra.Location = new System.Drawing.Point(118, 332);
            this.lblErrorSifra.Name = "lblErrorSifra";
            this.lblErrorSifra.Size = new System.Drawing.Size(145, 13);
            this.lblErrorSifra.TabIndex = 15;
            this.lblErrorSifra.Text = "Sifra mora biti bar 4 karaktera";
            this.lblErrorSifra.Visible = false;
            // 
            // UcKreirajStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblErrorSifra);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.lblErrorPrezime);
            this.Controls.Add(this.lblErrorIme);
            this.Controls.Add(this.lblErrorIndeks);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtIndeks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Name = "UcKreirajStudenta";
            this.Size = new System.Drawing.Size(432, 418);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtIndeks;
        public System.Windows.Forms.TextBox txtIme;
        public System.Windows.Forms.TextBox txtPrezime;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtSifra;
        public System.Windows.Forms.Button btnDodaj;
        public System.Windows.Forms.Label lblErrorIndeks;
        public System.Windows.Forms.Label lblErrorIme;
        public System.Windows.Forms.Label lblErrorPrezime;
        public System.Windows.Forms.Label lblErrorEmail;
        public System.Windows.Forms.Label lblErrorSifra;
    }
}
