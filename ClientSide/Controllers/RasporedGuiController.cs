using ClientSide.Forms;
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
            var prijave = ucKreirajRaspored.prijave;
            var sale = ucKreirajRaspored.OdabraneSale.ToList<Sala>();
            int mesta = 0;
            foreach(var i in sale)
            {
                mesta += i.BrojMesta;
            }
            if(prijave.Count()>mesta)
            {
                MessageBox.Show("Nema dovoljno mesta u salama");
                return;
            }
            int brojacSala = 0;
            int brojacMesta = 0;
            foreach (PrijavaNaTerminPolaganja p in prijave)
            {
                p.SalaId = sale[brojacSala].SalaId;
                brojacMesta++;
                if (brojacMesta >= sale[brojacSala].BrojMesta)
                {
                    brojacSala++;
                    brojacMesta = 0;
                }
            }
            var response = ClientCommunication.Instance.CreateRaspored(prijave);
            MessageBox.Show(response);
        }

        private void BtnUkloniSalu_Click(object sender, EventArgs e)
        {
            try
            {
                Sala s = ucKreirajRaspored.dgwDodateSale.SelectedRows[0].DataBoundItem as Sala;
                ucKreirajRaspored.Sale.Add(s);
                ucKreirajRaspored.OdabraneSale.Remove(s);
                ucKreirajRaspored.brojDodatihMesta -= s.BrojMesta;
                ucKreirajRaspored.lblMesta.Text = $"Odabrano mesta {ucKreirajRaspored.brojDodatihMesta}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nije odabrana sala");
            }
           
        }

        private void btnDodajSaluClick(object sender, EventArgs e)
        {
            try
            {
                Sala s = ucKreirajRaspored.dgwSale.SelectedRows[0].DataBoundItem as Sala;
                ucKreirajRaspored.OdabraneSale.Add(s);
                ucKreirajRaspored.Sale.Remove(s);
                ucKreirajRaspored.brojDodatihMesta += s.BrojMesta;
                ucKreirajRaspored.lblMesta.Text = $"Odabrano mesta {ucKreirajRaspored.brojDodatihMesta}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nije odabrana sala");
            }
        }

        public UcShowRaspored CreateUcShowRaspored(TerminPolaganja t)
        {
            UcShowRaspored ucShowRaspored = new UcShowRaspored();
            ucShowRaspored.raspored = new BindingList<PrijavaNaTerminPolaganja>(ClientCommunication.Instance.SearchRaspored(t));
            ucShowRaspored.dgwRaspored.DataSource = ucShowRaspored.raspored;
            ucShowRaspored.dgwRaspored.Columns["SalaId"].Visible = false;
            ucShowRaspored.dgwRaspored.Columns["Predmet"].Visible = false;
            ucShowRaspored.dgwRaspored.Columns["Tip"].Visible = false;
            ucShowRaspored.dgwRaspored.Columns["Izasao"].Visible = false;
            ucShowRaspored.dgwRaspored.Columns["DatumOdrzavanja"].Visible=false;
            return ucShowRaspored;
        }
    }
}
