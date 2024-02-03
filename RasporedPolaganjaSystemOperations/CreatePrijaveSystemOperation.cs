using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasporedPolaganjaSystemOperations
{

    public class CreatePrijaveSystemOperation : SystemOperationBase
    {
        public List<PrijavaNaTerminPolaganja> prijave;
        protected override void ExecuteConcreteOperation()
        {
            foreach (var prijava in prijave)
            {
                string criteria = $"TerminId={prijava.TerminId} and BrojIndeksa='{prijava.BrojIndeksa}'";
                if (repository.Exsists(prijava, criteria))
                {
                    throw new UserException("Prijava vec postoji");
                }
                repository.Add(prijava);
            }
        }

    }
}
