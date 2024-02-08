using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerSide
{
    public partial class FrmServer : Form
    {
        public BindingList<ClientHandler> ClientHandlers = new BindingList<ClientHandler>();

        public FrmServer()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Server.Instance.isServerOn)
                {
                    Server.Instance.StartServer();

                    btnStartServer.Enabled = false;
                    btnStopServer.Enabled = true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (Server.Instance.isServerOn)
                {
                    Server.Instance.StopServer();
                    btnStartServer.Enabled = true;
                    btnStopServer.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            try
            {
                Server.Instance.StartServer();
                btnStartServer.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
