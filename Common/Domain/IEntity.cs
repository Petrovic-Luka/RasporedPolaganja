using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public interface IEntity
    {
        string TableName { get; }
        string InsertValues { get; }
        string UpdateValues { get; }
        string Join { get; }
        string PrimaryKeyName { get; }
        List<IEntity> GetList(SqlDataReader reader);
    }
}
