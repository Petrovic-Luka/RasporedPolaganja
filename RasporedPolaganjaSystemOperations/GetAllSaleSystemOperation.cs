using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasporedPolaganjaSystemOperations
{

    public class GetAllSaleSystemOperation : SystemOperationBase
    {
        public List<Sala> sale;
        protected override void ExecuteConcreteOperation()
        {
            sale = repository.GetAll(new Sala()).Cast<Sala>().ToList();
        }
    }
}
