namespace ClientSide.Forms
{
    partial class FrmProfesor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ispitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajIspitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminiPolaganjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajTerminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dodajStudentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ispitToolStripMenuItem,
            this.terminiPolaganjaToolStripMenuItem,
            this.dodajStudentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ispitToolStripMenuItem
            // 
            this.ispitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajIspitToolStripMenuItem});
            this.ispitToolStripMenuItem.Name = "ispitToolStripMenuItem";
            this.ispitToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.ispitToolStripMenuItem.Text = "Ispit";
            // 
            // dodajIspitToolStripMenuItem
            // 
            this.dodajIspitToolStripMenuItem.Name = "dodajIspitToolStripMenuItem";
            this.dodajIspitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.dodajIspitToolStripMenuItem.Text = "DodajIspit";
            // 
            // terminiPolaganjaToolStripMenuItem
            // 
            this.terminiPolaganjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajTerminToolStripMenuItem});
            this.terminiPolaganjaToolStripMenuItem.Name = "terminiPolaganjaToolStripMenuItem";
            this.terminiPolaganjaToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.terminiPolaganjaToolStripMenuItem.Text = "TerminiPolaganja";
            this.terminiPolaganjaToolStripMenuItem.Click += new System.EventHandler(this.terminiPolaganjaToolStripMenuItem_Click);
            // 
            // kreirajTerminToolStripMenuItem
            // 
            this.kreirajTerminToolStripMenuItem.Name = "kreirajTerminToolStripMenuItem";
            this.kreirajTerminToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.kreirajTerminToolStripMenuItem.Text = "KreirajTermin";
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(12, 27);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(776, 411);
            this.pnlMain.TabIndex = 1;
            // 
            // dodajStudentaToolStripMenuItem
            // 
            this.dodajStudentaToolStripMenuItem.Name = "dodajStudentaToolStripMenuItem";
            this.dodajStudentaToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.dodajStudentaToolStripMenuItem.Text = "DodajStudenta";
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmProfesor";
            this.Text = "FrmProfesor";
            this.Load += new System.EventHandler(this.FrmProfesor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem ispitToolStripMenuItem;
        public System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem dodajIspitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminiPolaganjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajTerminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajStudentaToolStripMenuItem;
    }
}