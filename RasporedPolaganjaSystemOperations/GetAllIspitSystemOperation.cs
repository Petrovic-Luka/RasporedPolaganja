using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasporedPolaganjaSystemOperations
{
    public class GetAllIspitSystemOperation : SystemOperationBase
    {
        public List<Ispit> ispiti;
        protected override void ExecuteConcreteOperation()
        {
            ispiti=repository.GetAll(new Ispit()).Cast<Ispit>().ToList();
        }
    }
}
