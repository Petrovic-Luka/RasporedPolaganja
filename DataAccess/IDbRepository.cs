using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDbRepository<I> where I : class
    {
        void Commit();
        void Rollback();
        void Close();

        void Add(I entity);
        void Update(I entity, string criteria);
        void Delete(I entity, string criteria);
        I Get(I entity, string criteria);
        List<I> GetAll(I entity);
        List<I> Search(I entity, string criteria);
    }
}
