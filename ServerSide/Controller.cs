using Common.Domain;
using RasporedPolaganjaSystemOperations;
using System;
using System.Collections.Generic;

namespace ServerSide
{
    public class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();

                }
                return instance;
            }
        }

        public Student LogInStudent(Student student)
        {
            PrijavaStudentSystemOperation operation = new PrijavaStudentSystemOperation();
            operation.student = student;
            operation.Execute();
            return operation.student;
        }

        public Profesor LogInProfesor(Profesor p)
        {
           PrijavaProfesorSystemOperation operation = new PrijavaProfesorSystemOperation();
            operation.profesor = p;
            operation.Execute();
            return operation.profesor;
        }

        public List<Ispit> GetAllIspiti()
        {
            GetAllIspitSystemOperation operation = new GetAllIspitSystemOperation();
            operation.Execute();
            return operation.ispiti;
        }

        public void CreateIspit(Ispit ispit)
        {
            CreateIspitSystemOperation operation = new CreateIspitSystemOperation();
            operation.ispit = ispit;
            operation.Execute();
        }

        public void CreateTerminPolaganja(TerminPolaganja termin)
        {
            CreateTerminPolaganjaSystemOperation operation=new CreateTerminPolaganjaSystemOperation();
            operation.termin = termin;
            operation.Execute();
        }

        public List<TerminPolaganja> GetAllTerminePolaganja()
        {
            GetAllTerminePolaganjaSystemOperation operation = new GetAllTerminePolaganjaSystemOperation();
            operation.Execute();
            return operation.termini;
        }

        public List<TerminPolaganja> SearchTerminePolaganja(Ispit ispit)
        {
            SearchTerminePolaganjaSystemOperation operation=new SearchTerminePolaganjaSystemOperation();
            operation.ispit= ispit;
            operation.Execute();
            return operation.termini;
        }

        public void CreateStudent(Student student)
        {
           CreateStudentSystemOperation operation=new CreateStudentSystemOperation();
            operation.student = student;
            operation.Execute();
        }

        public void CreatePrijave(List<PrijavaNaTerminPolaganja> prijave)
        {
            CreatePrijaveSystemOperation operation=new CreatePrijaveSystemOperation();
            operation.prijave= prijave;
            operation.Execute();
        }

        public void DeletePrijava(List<PrijavaNaTerminPolaganja> prijave)
        {
            DeletePrijavaSystemOperation operation = new DeletePrijavaSystemOperation();
            operation.prijave = prijave;
            operation.Execute();
        }

        public List<PrijavaNaTerminPolaganja> SearchPrijaveNaTerminPolaganja(TerminPolaganja termin)
        {
            SearchPrijaveNaTerminPolaganjaSystemOperation operation = new SearchPrijaveNaTerminPolaganjaSystemOperation();
            operation.termin = termin;
            operation.Execute();
            return operation.prijave;
        }

        public List<Sala> GetAllSale()
        {
            GetAllSaleSystemOperation operation = new GetAllSaleSystemOperation();
            operation.Execute();
            return operation.sale;
        }

        public void CreateRaspored(Raspored raspored)
        {
            CreateRasporedSystemOperation operation= new CreateRasporedSystemOperation();
            operation.raspored= raspored;
            operation.Execute();
        }

        public List<Raspored> SearchRaspored(TerminPolaganja t)
        {
            SearchRasporedSystemOperation operation = new SearchRasporedSystemOperation();
            operation.termin= t;
            operation.Execute();
            return operation.raspored;
        }

        public  List<PrijavaNaTerminPolaganja> SearchPrijaveNaTerminPolaganjaStudent(Student student)
        {
            SearchPrijaveNaTerminPolaganjaStudentSystemOperation operation = new SearchPrijaveNaTerminPolaganjaStudentSystemOperation();
            operation.student = student;
            operation.Execute();
            return operation.prijave;

        }
    }
}