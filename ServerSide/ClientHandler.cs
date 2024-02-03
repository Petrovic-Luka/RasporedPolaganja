using Common.Communication;
using Common.Domain;
using RasporedPolaganjaSystemOperations;
using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace ServerSide
{
    public class ClientHandler
    {
        private Socket socket;
        private Sender sender;
        private Receiver receiver;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        public void HandleRequests()
        {
            try
            {
                while (Server.Instance.isServerOn)
                {
                    Request req = receiver.Receive<Request>();
                    Response response = ProcessRequest(req);
                    sender.Send(response);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Server.Instance.clients.Remove(this);
            }
        }

        private Response ProcessRequest(Request req)
        {
            Response response = new Response();
            response.Success = true;
            try
            {
                if (req.Operation == Operation.LogInStudent)
                {
                    Student s = (Student)req.Body;
                    var a = Controller.Instance.LogInStudent(s);
                    response.Data = a;
                    response.Message = "Uspesan log in";
                }
                else if (req.Operation == Operation.LogInProfesor)
                {
                    Profesor p = (Profesor)req.Body;
                    var a = Controller.Instance.LogInProfesor(p);
                    response.Data = a;
                    response.Message = "Uspesan log in";
                }
                else if(req.Operation==Operation.GetAllIspit)
                {
                    response.Data = Controller.Instance.GetAllIspiti();
                    response.Message = "Vraceni su svi ispiti";
                }
                else if(req.Operation==Operation.CreateIspit)
                {
                    Ispit ispit=(Ispit)req.Body;
                    Controller.Instance.CreateIspit(ispit);
                    response.Message = "Ispit uspesno dodat";
                }
                else if (req.Operation == Operation.CreateTerminPolaganja)
                {
                    TerminPolaganja termin=(TerminPolaganja)req.Body;
                    Controller.Instance.CreateTerminPolaganja(termin);
                    response.Message = "Termin uspesno kreiran";
                }
                else if(req.Operation==Operation.GetAllTerminePolaganja)
                {
                    response.Data = Controller.Instance.GetAllTerminePolaganja();
                    response.Message = "Vraceni svi termini polganja";
                }
                else if(req.Operation==Operation.SearchTerminePolaganja)
                {
                    response.Data = Controller.Instance.SearchTerminePolaganja((Ispit)req.Body);
                    response.Message = "Vraceni termini polganja";
                }
                else if(req.Operation==Operation.CreateStudent)
                {
                    Student student = (Student)req.Body;
                    Controller.Instance.CreateStudent(student);
                    response.Message = "Student uspesno dodat";
                }
                else if(req.Operation==Operation.CreatePrijava)
                {
                    List<PrijavaNaTerminPolaganja> prijave = (List<PrijavaNaTerminPolaganja>)req.Body;
                    Controller.Instance.CreatePrijave(prijave);
                    response.Message = "Uspesna prijava";
                }
                else if(req.Operation==Operation.DeletePrijava)
                {
                    List<PrijavaNaTerminPolaganja> prijave = (List<PrijavaNaTerminPolaganja>)req.Body;
                    Controller.Instance.DeletePrijava(prijave);
                    response.Message = "Uspesna odjava";
                }
                else if (req.Operation == Operation.SearchPrijaveNaTerminPolaganja)
                {
                    response.Data = Controller.Instance.SearchPrijaveNaTerminPolaganja((TerminPolaganja)req.Body);
                    response.Message = "Vracene prijave";
                }
                else if (req.Operation == Operation.SearchPrijaveNaTerminPolaganjaStudent)
                {
                    response.Data = Controller.Instance.SearchPrijaveNaTerminPolaganjaStudent((Student)req.Body);
                    response.Message = "Vracene prijave";
                }

                else if (req.Operation == Operation.GetAllSale)
                {
                    response.Data = Controller.Instance.GetAllSale();
                    response.Message = "Vraceni sve sale";
                }
                else if(req.Operation==Operation.CreateRaspored)
                {
                    Raspored raspored = (Raspored)req.Body;
                    Controller.Instance.CreateRaspored(raspored);
                    response.Message = "Uspesno kreiran raspored";
                }
                else if (req.Operation==Operation.SearchRaspored)
                {
                    response.Data = Controller.Instance.SearchRaspored((TerminPolaganja)req.Body);
                    response.Message = "Vracen raspored";
                }

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Exception = new Exception(ex.Message);
            }

            return response;
        }

        public void StopSocket()
        {
            socket.Close();
        }
    }
}
