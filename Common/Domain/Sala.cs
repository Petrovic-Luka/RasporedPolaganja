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
    public class Sala:IEntity
    {
        [Browsable(false)]
        public int SalaId { get; set; }
        public string Naziv { get; set; }
        public int BrojMesta { get; set; }
        public bool Rc { get; set; }
        [Browsable(false)]
        public string TableName => "Sala";
        [Browsable(false)]
        public string InsertValues => $"'{Naziv}',{BrojMesta},{(Rc?1:0)}";
        [Browsable(false)]
        public string UpdateValues => throw new NotImplementedException();
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string PrimaryKeyName => "SalaId";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> output = new List<IEntity>();
            while (reader.Read())
            {
                Sala sala = new Sala();
                sala.SalaId = (int)reader["SalaId"];
                sala.Naziv = (string)reader["Naziv"];
                sala.BrojMesta = (int)reader["BrojMesta"];
                sala.Rc = (bool)reader["Rc"];
                output.Add(sala);
            }
            return output;
        }

    }
}
