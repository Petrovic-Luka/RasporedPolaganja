using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasporedPolaganjaSystemOperations
{
    public class CreateStudentSystemOperation : SystemOperationBase
    {
        public Student student;
        protected override void ExecuteConcreteOperation()
        {
            repository.Add(student);
        }
    }
}
