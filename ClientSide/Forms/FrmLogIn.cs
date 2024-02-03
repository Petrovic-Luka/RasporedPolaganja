using System;
using System.Windows.Forms;

namespace ClientSide
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            try
            {
                ClientCommunication.Instance.Connect();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
