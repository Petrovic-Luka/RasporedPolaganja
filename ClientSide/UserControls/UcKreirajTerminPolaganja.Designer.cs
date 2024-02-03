namespace ClientSide.UserControls
{
    partial class UcKreirajTerminPolaganja
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
            this.cmbPredmet = new System.Windows.Forms.ComboBox();
            this.datePrijave = new System.Windows.Forms.DateTimePicker();
            this.dateOdrzavanje = new System.Windows.Forms.DateTimePicker();
            this.chbRacunar = new System.Windows.Forms.CheckBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPredmet
            // 
            this.cmbPredmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPredmet.FormattingEnabled = true;
            this.cmbPredmet.Location = new System.Drawing.Point(133, 80);
            this.cmbPredmet.Name = "cmbPredmet";
            this.cmbPredmet.Size = new System.Drawing.Size(121, 21);
            this.cmbPredmet.TabIndex = 0;
            // 
            // datePrijave
            // 
            this.datePrijave.Location = new System.Drawing.Point(110, 224);
            this.datePrijave.Name = "datePrijave";
            this.datePrijave.Size = new System.Drawing.Size(200, 20);
            this.datePrijave.TabIndex = 1;
            // 
            // dateOdrzavanje
            // 
            this.dateOdrzavanje.Location = new System.Drawing.Point(110, 158);
            this.dateOdrzavanje.Name = "dateOdrzavanje";
            this.dateOdrzavanje.Size = new System.Drawing.Size(200, 20);
            this.dateOdrzavanje.TabIndex = 2;
            // 
            // chbRacunar
            // 
            this.chbRacunar.AutoSize = true;
            this.chbRacunar.Location = new System.Drawing.Point(133, 268);
            this.chbRacunar.Name = "chbRacunar";
            this.chbRacunar.Size = new System.Drawing.Size(113, 17);
            this.chbRacunar.TabIndex = 3;
            this.chbRacunar.Text = "Potreban Racunar";
            this.chbRacunar.UseVisualStyleBackColor = true;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(133, 334);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(121, 20);
            this.txtTip.TabIndex = 4;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(169, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(46, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Predmet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datum Odrzavanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prijave do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tip";
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(133, 378);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(121, 23);
            this.btnKreiraj.TabIndex = 9;
            this.btnKreiraj.Text = "Kreiraj Termin";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            // 
            // UcKreirajTerminPolaganja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.chbRacunar);
            this.Controls.Add(this.dateOdrzavanje);
            this.Controls.Add(this.datePrijave);
            this.Controls.Add(this.cmbPredmet);
            this.Name = "UcKreirajTerminPolaganja";
            this.Size = new System.Drawing.Size(391, 483);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbPredmet;
        public System.Windows.Forms.DateTimePicker datePrijave;
        public System.Windows.Forms.DateTimePicker dateOdrzavanje;
        public System.Windows.Forms.CheckBox chbRacunar;
        public System.Windows.Forms.TextBox txtTip;
        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnKreiraj;
    }
}
