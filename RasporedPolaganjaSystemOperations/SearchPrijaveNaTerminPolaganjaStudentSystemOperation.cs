using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasporedPolaganjaSystemOperations
{
    public class SearchPrijaveNaTerminPolaganjaStudentSystemOperation : SystemOperationBase
    {
        public Student student;
        public List<PrijavaNaTerminPolaganja> prijave;
        protected override void ExecuteConcreteOperation()
        {
            string criteria = $"BrojIndeksa='{student.BrojIndeksa}'";
            prijave = repository.Search(new PrijavaNaTerminPolaganja(), criteria).Cast<PrijavaNaTerminPolaganja>().ToList();
        }
    }
}
