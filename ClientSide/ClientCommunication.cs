using ClientSide.Controllers;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ClientSide
{

    public class ClientCommunication
    {
        private Socket socket;
        private Sender sender;
        private Receiver receiver;
        private bool connectedToServer = false;

        public static ClientCommunication instance;
        private ClientCommunication()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public static ClientCommunication Instance
        {
            get
            {
                if (instance == null) instance = new ClientCommunication();
                return instance;
            }
        }

        public void Connect()
        {
            try
            {
                int port = Int32.Parse(ConfigurationManager.AppSettings["port"]);
                string ip = ConfigurationManager.AppSettings["ip"];
                socket.Connect(ip, port);
                sender = new Sender(socket);
                receiver = new Receiver(socket);

                connectedToServer = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #region Student
        public Student LogInStudent(Student student)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request req = new Request()
                {
                    Body = student,
                    Operation = Operation.LogInStudent
                };
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                student = (Student)res.Data;
                return student;
            }
            catch (IOException ex)
            {
                CloseApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Profesor
        public Profesor LogInProfesor(Profesor profesor)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request req = new Request()
                {
                    Body = profesor,
                    Operation = Operation.LogInProfesor
                };
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                profesor = (Profesor)res.Data;

                return profesor;
            }
            catch (IOException ex)
            {
                CloseApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Ispit> GetAllIspit()
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.GetAllIspit
                };
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                List<Ispit> ispiti = (List<Ispit>)res.Data;

                if (!res.Success) throw new Exception(res.Exception.Message);

                return ispiti;
            }
            catch (IOException ex)
            {
                CloseApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string CreateIspit(Ispit ispit)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.CreateIspit
                };
                req.Body = ispit;
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                if (!res.Success) throw new Exception(res.Exception.Message);

                return res.Message;
            }
            catch (IOException ex)
            {
                CloseApp();
                throw ex;
            }

            catch (Exception ex)
            {
                return "Kreiranje ispita nije uspelo";
            }
        }

        public string CreateTerminPolaganja(TerminPolaganja termin)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.CreateTerminPolaganja
                };
                req.Body = termin;
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                if (!res.Success) throw new Exception(res.Exception.Message);

                return res.Message;
            }
            catch (IOException ex)
            {
                CloseApp();
                throw ex;
            }

            catch (Exception ex)
            {
                return "Kreiranje termina polaganja nije uspelo";
            }
        }

        public List<TerminPolaganja> GetAllTerminePolaganja()
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.GetAllTerminePolaganja
                };
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                List<TerminPolaganja> termini = (List<TerminPolaganja>)res.Data;

                if (!res.Success) throw new Exception(res.Exception.Message);

                return termini;
            }
            catch (IOException ex)
            {
                CloseApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TerminPolaganja> SearchTerminePolaganja(Ispit ispit)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.SearchTerminePolaganja
                };
                req.Body = ispit;
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                List<TerminPolaganja> termini = (List<TerminPolaganja>)res.Data;

                if (!res.Success) throw new Exception(res.Exception.Message);

                return termini;
            }
            catch (IOException ex)
            {
                CloseApp();
                throw ex;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string CreateStudent(Student student)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.CreateStudent
                };
                req.Body = student;
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                if (!res.Success) throw new Exception(res.Exception.Message);

                return res.Message;
            }
            catch (IOException ex)
            {
                CloseApp();
                throw ex;
            }

            catch (Exception ex)
            {
                return "Kreiranje naloga nije uspelo";
            }
        }

        public string CreatePrijava(List<TerminPolaganja> termini, Student student)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.CreatePrijava
                };
                List<PrijavaNaTerminPolaganja> prijave = new List<PrijavaNaTerminPolaganja>();
                foreach (TerminPolaganja termin in termini)
                {
                    PrijavaNaTerminPolaganja prijava=new PrijavaNaTerminPolaganja();
                    prijava.BrojIndeksa = student.BrojIndeksa;
                    prijava.TerminId = termin.TerminPolaganjaId;
                    prijava.DatumPrijave = System.DateTime.Now;
                    prijave.Add(prijava);
                }
                req.Body = prijave;
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                if (!res.Success) throw res.Exception;

                return res.Message;
            }
            catch (IOException ex)
            {
                CloseApp();
                throw ex;
            }

            catch (Exception ex)
            {
                return "Kreiranje prijave nije uspelo";
            }
        }

        public string DeletePrijava(List<TerminPolaganja>termini, Student student)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.DeletePrijava
                };

                List<PrijavaNaTerminPolaganja> prijave = new List<PrijavaNaTerminPolaganja>();
                foreach (TerminPolaganja termin in termini)
                {
                    PrijavaNaTerminPolaganja prijava = new PrijavaNaTerminPolaganja();
                    prijava.BrojIndeksa = student.BrojIndeksa;
                    prijava.TerminId = termin.TerminPolaganjaId;
                    prijava.DatumPrijave = System.DateTime.Now;
                    prijave.Add(prijava);
                }
                req.Body = prijave;
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                if (!res.Success) throw new Exception(res.Exception.Message);

                return res.Message;
            }
            catch (IOException ex)
            {
                CloseApp();
                throw ex;
            }

            catch (Exception ex)
            {
                return "Brisanje prijave nije uspelo";
            }
        }

        public List<Sala> GetAllSale()
        {
            try
            {
                if (!SocketConnected()) throw new IOException();

                Request req = new Request()
                {
                    Operation = Operation.GetAllSale
                };
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                List<Sala> sale = (List<Sala>)res.Data;

                if (!res.Success) throw new Exception(res.Exception.Message);

                return sale;
            }
            catch (IOException ex)
            {
                CloseApp();
                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<PrijavaNaTerminPolaganja> GetPrijaveZaTermin(TerminPolaganja termin)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.SearchPrijaveNaTerminPolaganja
                };
                req.Body = termin;
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                List<PrijavaNaTerminPolaganja> prijave = (List<PrijavaNaTerminPolaganja>)res.Data;

                if (!res.Success) throw new Exception(res.Exception.Message);

                return prijave;
            }
            catch (IOException ex)
            {
                CloseApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string CreateRaspored(List<PrijavaNaTerminPolaganja> prijave)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.CreateRaspored
                };
                req.Body = prijave;
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                if (!res.Success) throw new Exception(res.Exception.Message);

                return res.Message;
            }
            catch (IOException ex)
            {
                CloseApp();
                throw ex;
            }

            catch (Exception ex)
            {
                return "Kreiranje rasporeda nije uspelo";
            }
        }

        public List<PrijavaNaTerminPolaganja> SearchRaspored(TerminPolaganja t)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.SearchRaspored
                };
                req.Body = t;
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                List<PrijavaNaTerminPolaganja> prijave = (List<PrijavaNaTerminPolaganja>)res.Data;

                if (!res.Success) throw new Exception(res.Exception.Message);

                return prijave;
            }
            catch (IOException ex)
            {
                CloseApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BindingList<PrijavaNaTerminPolaganja> SearchPrijavljeneStudent(Student student)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.SearchPrijaveNaTerminPolaganjaStudent
                };
                req.Body = student;
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                List<PrijavaNaTerminPolaganja> raspored = (List<PrijavaNaTerminPolaganja>)res.Data;

                if (!res.Success) throw new Exception(res.Exception.Message);

                return new BindingList<PrijavaNaTerminPolaganja>(raspored);
            }
            catch (IOException ex)
            {
                CloseApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SocketConnected()
        {
            if (!connectedToServer) return false;
            if (socket == null) return false;
            if (socket.Connected == false) return false;
            bool part1 = socket.Poll(1000, SelectMode.SelectRead);
            bool part2 = (socket.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }

        public void CloseApp()
        {
            MessageBox.Show("Niste povezani na server resetovanje aplikacije");
            MainCoordinator.Instance.frmLogIn.Close();
        }
        #endregion
    }

}
