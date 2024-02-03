using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasporedPolaganjaSystemOperations
{
    public class SearchPrijaveNaTerminPolaganjaSystemOperation : SystemOperationBase
    {
        public TerminPolaganja termin;
        public List<PrijavaNaTerminPolaganja> prijave;
        protected override void ExecuteConcreteOperation()
        {
            string criteria = $"TerminId={termin.TerminPolaganjaId}";
            prijave = repository.Search(new PrijavaNaTerminPolaganja(), criteria).Cast<PrijavaNaTerminPolaganja>().ToList();
        }
    }
}
