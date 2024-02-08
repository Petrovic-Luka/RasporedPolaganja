using ClientSide.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSide.Forms
{
    public partial class FrmProfesor : Form
    {
        public FrmProfesor()
        {
            InitializeComponent();
            this.ispitToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPrikaziIspite();
            this.dodajIspitToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowDodajIspit();
            this.terminiPolaganjaToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowTerminePolaganjaProfesor();
            this.kreirajTerminToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowKreirajTerminPolaganja();
            this.dodajStudentaToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowDodajStudenta();

        }

        public void ChangePanel(Control control)
        {
            try
            {
                pnlMain.Controls.Clear();
                control.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(control);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {

        }

        private void terminiPolaganjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
