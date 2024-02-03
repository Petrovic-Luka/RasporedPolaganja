using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasporedPolaganjaSystemOperations
{
    public class CreateIspitSystemOperation:SystemOperationBase
    {
        public Ispit ispit;

        protected override void ExecuteConcreteOperation()
        {
            repository.Add(ispit);
        }
    }
}
