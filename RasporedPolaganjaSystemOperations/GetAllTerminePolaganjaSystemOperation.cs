using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasporedPolaganjaSystemOperations
{
    public class GetAllTerminePolaganjaSystemOperation : SystemOperationBase
    {
        public List<TerminPolaganja> termini;
        protected override void ExecuteConcreteOperation()
        {
            termini = repository.GetAll(new TerminPolaganja()).Cast<TerminPolaganja>().ToList();
        }
    }
}
