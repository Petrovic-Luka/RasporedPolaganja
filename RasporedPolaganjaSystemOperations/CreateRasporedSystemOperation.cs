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
        public Raspored raspored;
        protected override void ExecuteConcreteOperation()
        {
            int brojacSala = 0;
            int brojacMesta = 0;
            foreach(PrijavaNaTerminPolaganja p in raspored.prijave)
            {
                Raspored r = new Raspored();
                r.TerminId= p.TerminId;
                r.BrojIndeksa=p.BrojIndeksa;
                r.SalaId = raspored.ZadateSale[brojacSala].SalaId;
                brojacMesta++;
                if(brojacMesta>= raspored.ZadateSale[brojacSala].BrojMesta)
                {
                    brojacSala++;
                    brojacMesta = 0;
                }
                repository.Add(r);

            }
        }
    }
}
