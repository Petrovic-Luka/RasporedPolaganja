using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Ispit : IEntity
    {
        [Browsable(false)]
        public int IspitId { get; set; }
        public string Naziv { get; set; }
        public int Espb { get; set; }

        [Browsable(false)]
        public string TableName => "Ispit";

        [Browsable(false)]
        public string InsertValues => $"'{Naziv}',{Espb}";

        [Browsable(false)]
        public string UpdateValues => throw new NotImplementedException();
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string PrimaryKeyName => "IspitId";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> output = new List<IEntity>();
            while (reader.Read())
            {
                Ispit ispit = new Ispit();
                ispit.IspitId = (int)reader["IspitId"];
                ispit.Naziv = (string)reader["Naziv"];
                ispit.Espb = (int)reader["Espb"];
                output.Add(ispit);
            }
            return output;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
