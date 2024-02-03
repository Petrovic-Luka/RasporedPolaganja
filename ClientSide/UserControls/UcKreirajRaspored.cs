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

namespace ClientSide.UserControls
{
    public partial class UcKreirajRaspored : UserControl
    {
        public TerminPolaganja termin;
        public BindingList<Sala> Sale;
        public BindingList<Sala> OdabraneSale = new BindingList<Sala>();
        public List<PrijavaNaTerminPolaganja> prijave;
        public int brojDodatihMesta = 0;

        public UcKreirajRaspored(TerminPolaganja t)
        {
            InitializeComponent();
            termin = t;
        }

        private void UcKreirajRaspored_Load(object sender, EventArgs e)
        {
            dgwSale.DataSource = Sale;
            dgwDodateSale.DataSource = OdabraneSale;
        }
    }
}
