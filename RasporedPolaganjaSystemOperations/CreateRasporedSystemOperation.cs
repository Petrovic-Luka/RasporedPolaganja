using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasporedPolaganjaSystemOperations
{
    public class CreateRasporedSystemOperation : SystemOperationBase
    {
        public List<PrijavaNaTerminPolaganja> prijave;
        protected override void ExecuteConcreteOperation()
        {
            foreach(PrijavaNaTerminPolaganja p in prijave)
            {
                string criteria = $"BrojIndeksa='{p.BrojIndeksa}' and TerminId={p.TerminId}";
                repository.Update(p,criteria);

            }
        }
    }
}
