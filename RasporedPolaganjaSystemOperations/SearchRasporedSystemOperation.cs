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
        public List<Raspored> raspored;
        protected override void ExecuteConcreteOperation()
        {
            string criteria = $" TerminId={termin.TerminPolaganjaId}";
            raspored = repository.Search(new Raspored(), criteria).Cast<Raspored>().ToList();
        }
    }
}
