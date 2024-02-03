using ClientSide.Forms;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSide.Controllers
{
    public class MainCoordinator
    {
        public Student loggedInStudent;
        public Profesor loggedInProfesor;

        //forms
        public FrmLogIn frmLogIn;
        public FrmStudent frmStudent;
        public FrmProfesor frmProfesor;

        //controllers
        private StudentGuiController studentGuiController;
        private IspitGuiController ispitGuiKontroler;
        private TerminPolaganjaGuiController terminPolaganjaGuiController;
        private RasporedGuiController rasporedGuiController;

        private static MainCoordinator instance;

        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null) instance = new MainCoordinator();
                return instance;
            }
        }
        private MainCoordinator()
        {
            studentGuiController = new StudentGuiController();
            ispitGuiKontroler=new IspitGuiController();
            terminPolaganjaGuiController=new TerminPolaganjaGuiController();
            rasporedGuiController = new RasporedGuiController();
        }

        public void CreateLogIn()
        {
            studentGuiController.CreateFormLogIn(this.frmLogIn);
        }

        public void showFrmStudent()
        {
            frmLogIn.Visible = false;
            frmStudent = new FrmStudent();
            studentGuiController.CreateFormStudent(this.frmStudent);
            try
            {
                frmStudent.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            frmLogIn.Visible = true;
        }

        public void showFrmProfesor()
        {
            frmLogIn.Visible = false;
            frmProfesor = new FrmProfesor();
            try
            {
                frmProfesor.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            frmLogIn.Visible = true;
        }

        public void ShowPrikaziIspite()
        {
            frmProfesor.ChangePanel(ispitGuiKontroler.CreateUcShowIspit());
        }

        public void ShowDodajIspit()
        {
            frmProfesor.ChangePanel(ispitGuiKontroler.CreateUcKreirajPredmet());
        }

        public void ShowTerminePolaganjaProfesor()
        {
            frmProfesor.ChangePanel(terminPolaganjaGuiController.CreateUcShowTerminePolaganja());
        }

        public void ShowKreirajTerminPolaganja()
        {
            frmProfesor.ChangePanel(terminPolaganjaGuiController.ShowUcKreirajTerminPolaganja());
        }

        public void ShowDodajStudenta()
        {
            frmProfesor.ChangePanel(studentGuiController.ShowUcKreirajStudenta());
        }

        public void LoadCmbIspiti()
        {
            frmStudent.cmbIspit.DataSource = ispitGuiKontroler.GetIspite();
        }

        public void SearchIspite()
        {
            frmStudent.dgwTermini.DataSource = terminPolaganjaGuiController.SearchIspite((Ispit)frmStudent.cmbIspit.SelectedItem);
        }

        public void CreatePrijava()
        {
            terminPolaganjaGuiController.CreatePrijava(frmStudent.zadatiTermini.ToList<TerminPolaganja>(), loggedInStudent);
            frmStudent.dgwPrijavljeni.DataSource = ClientCommunication.Instance.SearchPrijavljeneStudent(MainCoordinator.Instance.loggedInStudent);
        }

        public void DeletePrijava()
        {
            terminPolaganjaGuiController.DeletePrijava(frmStudent.zadatiTermini.ToList<TerminPolaganja>(), loggedInStudent);
            frmStudent.dgwPrijavljeni.DataSource = ClientCommunication.Instance.SearchPrijavljeneStudent(MainCoordinator.Instance.loggedInStudent);
        }

        public void ShowCreateRaspored(TerminPolaganja t)
        {
            frmProfesor.ChangePanel(rasporedGuiController.CreateUcKreirajRaspored(t));
        }

        public void ShowRaspored(TerminPolaganja t)
        {
            frmProfesor.ChangePanel(rasporedGuiController.CreateUcShowRaspored(t));
        }
    }
}
