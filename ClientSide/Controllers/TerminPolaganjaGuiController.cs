using ClientSide.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSide.Controllers
{
    public class TerminPolaganjaGuiController
    {
        public UcShowTerminePolaganja ucShowTerminePolaganja;

        public UcKreirajTerminPolaganja kreirajTerminPolaganja;

        public UcShowTerminePolaganja CreateUcShowTerminePolaganja()
        {
            ucShowTerminePolaganja = new UcShowTerminePolaganja();
            ucShowTerminePolaganja.cmbIspit.DataSource = ClientCommunication.Instance.GetAllIspit();
            ucShowTerminePolaganja.dgvPrikaz.DataSource = ClientCommunication.Instance.GetAllTerminePolaganja();
            ucShowTerminePolaganja.btnPretrazi.Click += BtnPretraziTermine_Click;
            ucShowTerminePolaganja.btnRaspored.Click += BtnRasporedClick;
            ucShowTerminePolaganja.btnShowRaspored.Click += BtnShowRaspored_Click;
            return ucShowTerminePolaganja;
        }

        private void BtnShowRaspored_Click(object sender, EventArgs e)
        {
            TerminPolaganja t= ucShowTerminePolaganja.dgvPrikaz.SelectedRows[0].DataBoundItem as TerminPolaganja;
            MainCoordinator.Instance.ShowRaspored(t);
        }

        private void BtnRasporedClick(object sender, EventArgs e)
        {
            TerminPolaganja t = ucShowTerminePolaganja.dgvPrikaz.SelectedRows[0].DataBoundItem as TerminPolaganja;
            MainCoordinator.Instance.ShowCreateRaspored(t);
        }

        public UcKreirajTerminPolaganja ShowUcKreirajTerminPolaganja()
        {
            kreirajTerminPolaganja = new UcKreirajTerminPolaganja();
            kreirajTerminPolaganja.cmbPredmet.DataSource= ClientCommunication.Instance.GetAllIspit();
            kreirajTerminPolaganja.btnKreiraj.Click += BtnKreiraj_Click;

            return kreirajTerminPolaganja;
        }

        public List<TerminPolaganja> SearchIspite(Ispit ispit)
        {
            return ClientCommunication.Instance.SearchTerminePolaganja(ispit);
        }

        private void BtnKreiraj_Click(object sender, EventArgs e)
        {
            //validacija
            //pokupi podatke sa forme
            //TODO zavrsi
            TerminPolaganja termin=new TerminPolaganja();
            termin.Ispit =(Ispit) kreirajTerminPolaganja.cmbPredmet.SelectedItem;
            termin.IspitId = termin.Ispit.IspitId;
            termin.PrijavaDo = kreirajTerminPolaganja.datePrijave.Value;
            termin.Datum = kreirajTerminPolaganja.dateOdrzavanje.Value;
            termin.PotrebanRacunar = kreirajTerminPolaganja.chbRacunar.Checked;
            termin.Tip=kreirajTerminPolaganja.txtTip.Text;
            if (termin.Datum <= termin.PrijavaDo)
            {
                MessageBox.Show("Prijava mora biti bar jedan dan pre odrzavanja");
                return;
            }
            if(termin.Datum < System.DateTime.Now || termin.PrijavaDo <System.DateTime.Now)
            {
                MessageBox.Show("Termini ne mogu biti u proslosti");
                return;
            }
            var result = ClientCommunication.Instance.CreateTerminPolaganja(termin);
            MessageBox.Show(result);
        }


        private void BtnPretraziTermine_Click(object sender, EventArgs e)
        {
            Ispit ispit=(Ispit)ucShowTerminePolaganja.cmbIspit.SelectedItem;
            ucShowTerminePolaganja.dgvPrikaz.DataSource = ClientCommunication.Instance.SearchTerminePolaganja(ispit);
        }

        public void CreatePrijava(List<TerminPolaganja> termini, Student student)
        {
            foreach(var termin in termini)
            {
                if(termin.PrijavaDo.Date<System.DateTime.Now.Date)
                {
                    MessageBox.Show($"Za {termin.Ispit} je istekao rok prijave");
                    return;
                }
            }
            if(termini.Count<1)
            {
                MessageBox.Show("Niste odabrali termin");
                return;
            }
            var result = ClientCommunication.Instance.CreatePrijava(termini, student);
            MessageBox.Show(result);
        }

        public void DeletePrijava(List<TerminPolaganja> termini, Student student)
        {
            if (termini.Count < 1)
            {
                MessageBox.Show("Niste odabrali termin");
                return;
            }
            var result = ClientCommunication.Instance.DeletePrijava(termini, student);
            MessageBox.Show(result);
        }
    }
}
