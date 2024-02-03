using ClientSide.Controllers;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Ispit> GetAllIspit()
        {
            try
            {
                if (!connectedToServer) throw new IOException("Niste konektovani na server");

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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string CreateIspit(Ispit ispit)
        {
            try
            {
                if (!connectedToServer) throw new IOException("Niste konektovani na server");

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
                return "Niste povezani na server molimo resetujte aplikaciju";
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string CreateTerminPolaganja(TerminPolaganja termin)
        {
            try
            {
                if (!connectedToServer) throw new IOException("Niste konektovani na server");

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
                return "Niste povezani na server molimo resetujte aplikaciju";
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<TerminPolaganja> GetAllTerminePolaganja()
        {
            try
            {
                if (!connectedToServer) throw new IOException("Niste konektovani na server");

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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TerminPolaganja> SearchTerminePolaganja(Ispit ispit)
        {
            try
            {
                if (!connectedToServer) throw new IOException("Niste konektovani na server");

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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string CreateStudent(Student student)
        {
            try
            {
                if (!connectedToServer) throw new IOException("Niste konektovani na server");

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
                return "Niste povezani na server molimo resetujte aplikaciju";
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string CreatePrijava(List<TerminPolaganja> termini, Student student)
        {
            try
            {
                if (!connectedToServer) throw new IOException("Niste konektovani na server");

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
                return "Niste povezani na server molimo resetujte aplikaciju";
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeletePrijava(List<TerminPolaganja>termini, Student student)
        {
            try
            {
                if (!connectedToServer) throw new IOException("Niste konektovani na server");

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
                return "Niste povezani na server molimo resetujte aplikaciju";
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Sala> GetAllSale()
        {
            try
            {
                if (!connectedToServer) throw new IOException("Niste konektovani na server");

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
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<PrijavaNaTerminPolaganja> GetPrijaveZaTermin(TerminPolaganja termin)
        {
            try
            {
                if (!connectedToServer) throw new IOException("Niste konektovani na server");

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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string CreateRaspored(Raspored raspored)
        {
            try
            {
                if (!connectedToServer) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.CreateRaspored
                };
                req.Body = raspored;
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                if (!res.Success) throw new Exception(res.Exception.Message);

                return res.Message;
            }
            catch (IOException ex)
            {
                return "Niste povezani na server molimo resetujte aplikaciju";
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Raspored> SearchRaspored(TerminPolaganja t)
        {
            try
            {
                if (!connectedToServer) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.SearchRaspored
                };
                req.Body = t;
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                List<Raspored> raspored = (List<Raspored>)res.Data;

                if (!res.Success) throw new Exception(res.Exception.Message);

                return raspored;
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
                if (!connectedToServer) throw new IOException("Niste konektovani na server");

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
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion
    }

}
