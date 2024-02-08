using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasporedPolaganjaSystemOperations
{
    public class SearchRasporedSystemOperation : SystemOperationBase
    {
        public TerminPolaganja termin;
        public List<PrijavaNaTerminPolaganja> prijave;
        protected override void ExecuteConcreteOperation()
        {
            string criteria = $" TerminId={termin.TerminPolaganjaId}";
            PrijavaNaTerminPolaganja prijava=new PrijavaNaTerminPolaganja();
            prijava.SalaId = 0;
            prijave=repository.Search(prijava,criteria).Cast<PrijavaNaTerminPolaganja>().ToList();
        }
    }
}
