using ClientSide.Controllers;
using Common.Domain;
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
    public partial class FrmStudent : Form
    {
        public BindingList<TerminPolaganja> zadatiTermini;

        public FrmStudent()
        {
            InitializeComponent();
            btnPretrazi.Click += (s, e) => MainCoordinator.Instance.SearchIspite();
            btnPrijavi.Click += (s, e) => MainCoordinator.Instance.CreatePrijava();
            btnOdjavi.Click += (s, e) => MainCoordinator.Instance.DeletePrijava();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            MainCoordinator.Instance.LoadCmbIspiti();
        }

        private void btnPrijavi_Click(object sender, EventArgs e)
        {

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {

        }
    }
}
