using ClientSide.Forms;
using ClientSide.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSide.Controllers
{
    public class StudentGuiController
    {
        public FrmLogIn frmLogIn;
        public FrmStudent frmStudent;
        public UcKreirajStudenta ucKreirajStudenta;
        public void CreateFormLogIn(FrmLogIn frmLogIn)
        {
            this.frmLogIn= frmLogIn;
            frmLogIn.btnLogIn.Click += BtnLogInOnClick;
        }

        public void CreateFormStudent(FrmStudent frmS)
        {
            frmStudent= frmS;
            frmStudent.zadatiTermini = new System.ComponentModel.BindingList<TerminPolaganja>();
            frmStudent.dgwDodati.DataSource=frmStudent.zadatiTermini;
            frmStudent.btnDodaj.Click += (s, e) => DodajPrijavu();
            frmStudent.btnUkloni.Click += (s, e) => UkloniPrijavu();
            SetDgwPrijavljeni();
        }
        private void SetDgwPrijavljeni()
        {
            frmStudent.dgwPrijavljeni.DataSource = ClientCommunication.Instance.SearchPrijavljeneStudent(MainCoordinator.Instance.loggedInStudent);
            frmStudent.dgwPrijavljeni.Columns["SalaId"].Visible = false;
            frmStudent.dgwPrijavljeni.Columns["BrojIndeksa"].Visible = false;
            frmStudent.dgwPrijavljeni.Columns["Sala"].Visible = false;
            frmStudent.dgwPrijavljeni.Columns["Izasao"].Visible = false;
        }


        public void BtnLogInOnClick(object sender, EventArgs e)
        {
            //validacija
            try
            {
                if (!frmLogIn.cbProfesor.Checked)
                {
                    Student s = CreateStudentFromForm();
                    s = ClientCommunication.Instance.LogInStudent(s);
                    if (s == null)
                    {
                        MessageBox.Show("Korisnik sa zadatim kredencijalima nije pronadjen");
                        return;
                    }
                    MainCoordinator.Instance.loggedInStudent = s;
                    MainCoordinator.Instance.showFrmStudent();
                }
                else
                {
                    Profesor p = CreateProfesorFromForm();
                    p = ClientCommunication.Instance.LogInProfesor(p);
                    if (p == null)
                    {
                        MessageBox.Show("Korisnik sa zadatim kredencijalima nije pronadjen");
                        return;
                    }
                    MainCoordinator.Instance.loggedInProfesor = p;
                    MainCoordinator.Instance.showFrmProfesor();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private Student CreateStudentFromForm()
        {
            Student student = new Student();
            student.Email = frmLogIn.txtEmail.Text;
            student.Sifra = frmLogIn.txtPassword.Text;
            return student;
        }

        private Profesor CreateProfesorFromForm()
        {
            Profesor profesor = new Profesor();
            profesor.Email = frmLogIn.txtEmail.Text;
            profesor.Sifra = frmLogIn.txtPassword.Text;
            return profesor;
        }

        public UcKreirajStudenta ShowUcKreirajStudenta()
        {
            ucKreirajStudenta=new UcKreirajStudenta();
            ucKreirajStudenta.btnDodaj.Click += BtnDodaj_Click;
            return ucKreirajStudenta;
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            Student student=new Student();
            student.BrojIndeksa=ucKreirajStudenta.txtIndeks.Text;
            student.Ime=ucKreirajStudenta.txtIme.Text;
            student.Prezime=ucKreirajStudenta.txtPrezime.Text;
            student.Email=ucKreirajStudenta.txtEmail.Text;
            student.Sifra=ucKreirajStudenta.txtSifra.Text;
            if(!ValidateStudent(student))
            {
                return;
            }
            var result = ClientCommunication.Instance.CreateStudent(student);
            MessageBox.Show(result);
            ucKreirajStudenta.txtIndeks.Text = "";
            ucKreirajStudenta.txtIme.Text = "";
            ucKreirajStudenta.txtPrezime.Text = "";
            ucKreirajStudenta.txtEmail.Text = "";
            ucKreirajStudenta.txtSifra.Text = "";
        }

        private bool ValidateStudent(Student student)
        {
            Regex indeks = new Regex("\\d{4}/\\d{4}$");
            Regex email = new Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");
            ucKreirajStudenta.lblErrorIndeks.Visible = false;
            ucKreirajStudenta.lblErrorIme.Visible = false;
            ucKreirajStudenta.lblErrorPrezime.Visible = false;
            ucKreirajStudenta.lblErrorSifra.Visible = false;
            ucKreirajStudenta.lblErrorEmail.Visible = false;
            var output = true;
            if(!indeks.IsMatch(student.BrojIndeksa))
            {
                ucKreirajStudenta.lblErrorIndeks.Visible = true;
                output=false;
            }
            if(student.Ime==null||student.Ime.Length<2)
            {
                ucKreirajStudenta.lblErrorIme.Visible = true;
                output = false;
            }
            if (student.Prezime == null || student.Prezime.Length < 2)
            {
                ucKreirajStudenta.lblErrorPrezime.Visible = true;
                output = false;
            }
            if (student.Sifra == null || student.Sifra.Length < 4)
            {
                ucKreirajStudenta.lblErrorSifra.Visible = true;
                output = false;
            }
            if (!email.IsMatch(student.Email))
            {
                ucKreirajStudenta.lblErrorEmail.Visible = true;
                output = false;
            }

            return output;

        }

        public void DodajPrijavu()
        {
            try
            {
                TerminPolaganja t = frmStudent.dgwTermini.SelectedRows[0].DataBoundItem as TerminPolaganja;
                if (frmStudent.zadatiTermini.Contains(t))
                {
                    MessageBox.Show("Termin vec zadat");
                    return;
                }
                frmStudent.zadatiTermini.Add(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nije odabran termin");
            }
        }
        public void UkloniPrijavu()
        {
            try
            {
                TerminPolaganja t = frmStudent.dgwDodati.SelectedRows[0].DataBoundItem as TerminPolaganja;
                frmStudent.zadatiTermini.Remove(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nije odabran termin");
            }
        }

    }
}
