using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasporedPolaganjaSystemOperations
{
    public class SearchTerminePolaganjaSystemOperation : SystemOperationBase
    {
        public Ispit ispit;
        public List<TerminPolaganja> termini;

        protected override void ExecuteConcreteOperation()
        {
            string criteria = $"[TerminPolaganja].IspitId={ispit.IspitId}";
            termini = repository.Search(new TerminPolaganja(), criteria).Cast<TerminPolaganja>().ToList();
        }
    }
}
