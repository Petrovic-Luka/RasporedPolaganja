using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasporedPolaganjaSystemOperations
{
    public class CreateTerminPolaganjaSystemOperation : SystemOperationBase
    {
        public TerminPolaganja termin;

        protected override void ExecuteConcreteOperation()
        {
            repository.Add(termin);
        }
    }
}
