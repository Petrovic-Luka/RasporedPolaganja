using ClientSide.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientSide.Controllers
{
    public class IspitGuiController
    {
        UcIspit ucIspit;
        UcKreirajPredmet ucKreirajPredmet;

        public UcIspit CreateUcShowIspit()
        {
            ucIspit =new UcIspit();
            //ucIspit.btnAdd.Click
            ucIspit.dgvDisplay.DataSource = ClientCommunication.Instance.GetAllIspit();
            return ucIspit;
        }

        public UcKreirajPredmet CreateUcKreirajPredmet()
        {
            ucKreirajPredmet = new UcKreirajPredmet();
            ucKreirajPredmet.btnKreirajIspit.Click += CreateIspit;
            ucKreirajPredmet.comboBox1.Items.Add("4");
            ucKreirajPredmet.comboBox1.Items.Add("5");
            ucKreirajPredmet.comboBox1.Items.Add("6");
            ucKreirajPredmet.comboBox1.SelectedIndex = 0;
            return ucKreirajPredmet;
        }

        public void CreateIspit(object sender, EventArgs e)
        {
            Ispit ispit=new Ispit();
            ispit.Naziv = ucKreirajPredmet.textBox1.Text;
            ispit.Espb=Int32.Parse(ucKreirajPredmet.comboBox1.SelectedItem.ToString());
            if(!ValidateIspit(ispit))
            {
                ucKreirajPredmet.lblError.Visible = true;
                return;
            }
            var result=ClientCommunication.Instance.CreateIspit(ispit);
            MessageBox.Show(result);
            ucKreirajPredmet.Dispose();
        }

        private bool ValidateIspit(Ispit ispit)
        {
            if ( ispit == null ) { return false; }
            if(ispit.Naziv == null||ispit.Naziv.Length<2 ) { return false; }
            return true;
        }

        public List<Ispit> GetIspite()
        {
           return ClientCommunication.Instance.GetAllIspit();
        }
    }
}
