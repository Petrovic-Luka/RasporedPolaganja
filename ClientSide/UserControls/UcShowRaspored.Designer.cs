namespace ClientSide.UserControls
{
    partial class UcShowRaspored
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
            this.dgwRaspored = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRaspored)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRaspored
            // 
            this.dgwRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRaspored.Location = new System.Drawing.Point(38, 41);
            this.dgwRaspored.Name = "dgwRaspored";
            this.dgwRaspored.Size = new System.Drawing.Size(547, 406);
            this.dgwRaspored.TabIndex = 0;
            // 
            // UcShowRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgwRaspored);
            this.Name = "UcShowRaspored";
            this.Size = new System.Drawing.Size(612, 499);
            this.Load += new System.EventHandler(this.UcShowRaspored_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRaspored)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgwRaspored;
    }
}
