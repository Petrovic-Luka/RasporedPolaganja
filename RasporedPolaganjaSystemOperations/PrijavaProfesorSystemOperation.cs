using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasporedPolaganjaSystemOperations
{
    public class PrijavaProfesorSystemOperation : SystemOperationBase
    {
        public Profesor profesor {  get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Profesor p = (Profesor)repository.Get(profesor, $" email='{profesor.Email}' and sifra='{profesor.Sifra}'");
            if (p == null) throw new Exception("Ne postoji profesor sa zadatim kredencijalima");
            profesor = p;
        }
    }
}
