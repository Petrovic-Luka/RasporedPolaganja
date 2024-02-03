using ClientSide.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSide.Controllers
{
    public class RasporedGuiController
    {
        UcKreirajRaspored ucKreirajRaspored;
        UcShowRaspored ucShowRaspored;
        public UcKreirajRaspored CreateUcKreirajRaspored(TerminPolaganja termin)
        {
            ucKreirajRaspored = new UcKreirajRaspored(termin);
            var sale=ClientCommunication.Instance.GetAllSale();
            if(ucKreirajRaspored.termin.PotrebanRacunar==true)
            {
                ucKreirajRaspored.Sale = new BindingList<Sala>(sale.Where(x => x.Rc).ToList());
            }
            else
            {
                ucKreirajRaspored.Sale = new BindingList<Sala>(sale.Where(x => !x.Rc).ToList());
            }
            ucKreirajRaspored.prijave = ClientCommunication.Instance.GetPrijaveZaTermin(ucKreirajRaspored.termin);

            ucKreirajRaspored.btnDodajSalu.Click += btnDodajSaluClick;
            ucKreirajRaspored.btnUkloniSalu.Click += BtnUkloniSalu_Click;
            ucKreirajRaspored.lblPrijave.Text = $"Broj prijava {ucKreirajRaspored.prijave.Count()}";

            ucKreirajRaspored.btnKreirajRaspored.Click += BtnKreirajRaspored_Click;
            return ucKreirajRaspored;
        }

        private void BtnKreirajRaspored_Click(object sender, EventArgs e)
        {
            Raspored raspored= new Raspored();
            raspored.prijave = ucKreirajRaspored.prijave;
            raspored.ZadateSale = ucKreirajRaspored.OdabraneSale.ToList<Sala>();
            var response = ClientCommunication.Instance.CreateRaspored(raspored);
            MessageBox.Show(response);
        }

        private void BtnUkloniSalu_Click(object sender, EventArgs e)
        {
            Sala s = ucKreirajRaspored.dgwDodateSale.SelectedRows[0].DataBoundItem as Sala;
            ucKreirajRaspored.Sale.Add(s);
            ucKreirajRaspored.OdabraneSale.Remove(s);
            ucKreirajRaspored.brojDodatihMesta -= s.BrojMesta;
            ucKreirajRaspored.lblMesta.Text = $"Odabrano mesta {ucKreirajRaspored.brojDodatihMesta}";
        }

        private void btnDodajSaluClick(object sender, EventArgs e)
        {
            Sala s= ucKreirajRaspored.dgwSale.SelectedRows[0].DataBoundItem as Sala;
            ucKreirajRaspored.OdabraneSale.Add(s);
            ucKreirajRaspored.Sale.Remove(s);
            ucKreirajRaspored.brojDodatihMesta += s.BrojMesta;
            ucKreirajRaspored.lblMesta.Text = $"Odabrano mesta {ucKreirajRaspored.brojDodatihMesta}";
        }

        public UcShowRaspored CreateUcShowRaspored(TerminPolaganja t)
        {
            UcShowRaspored ucShowRaspored = new UcShowRaspored();
            ucShowRaspored.raspored = new BindingList<Raspored>(ClientCommunication.Instance.SearchRaspored(t));
            ucShowRaspored.dgwRaspored.DataSource = ucShowRaspored.raspored;
            return ucShowRaspored;
        }
    }
}
