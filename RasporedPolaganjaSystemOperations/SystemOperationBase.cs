using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasporedPolaganjaSystemOperations
{
    public abstract class SystemOperationBase
    {
        protected DbRepository repository;

        public SystemOperationBase()
        {
            repository = new DbRepository();
        }
        public void Execute()
        {
            try
            {
                ExecuteConcreteOperation();

                repository.Commit();
            }
            catch (Exception ex)
            {
                repository.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                repository.Close();
            }
        }


        protected abstract void ExecuteConcreteOperation();
    }
}
