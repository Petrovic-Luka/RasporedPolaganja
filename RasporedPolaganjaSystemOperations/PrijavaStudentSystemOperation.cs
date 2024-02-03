using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasporedPolaganjaSystemOperations
{
    public class PrijavaStudentSystemOperation : SystemOperationBase
    {
        public Student student { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Student s = (Student)repository.Get(student, $" email='{student.Email}' and sifra='{student.Sifra}'");
            if (s == null) throw new Exception("Ne postoji student sa zadatim kredencijalima");
            student = s;
        }
    }
}
