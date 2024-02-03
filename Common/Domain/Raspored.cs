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
    public class Raspored:IEntity
    {
        [Browsable(false)]
        public int SalaId { get; set; }
        [Browsable(false)]
        public int TerminId { get; set; }
        public string BrojIndeksa { get; set; }
        [Browsable(false)]
        public List<Sala> ZadateSale { get; set; }
        [Browsable(false)]
        public List<PrijavaNaTerminPolaganja> prijave {  get; set; }
        public string NazivSale { get; set; }
        [Browsable(false)]
        public string TableName => "Raspored";
        [Browsable(false)]
        public string InsertValues => $"{TerminId},'{BrojIndeksa}',{SalaId}";
        [Browsable(false)]
        public string UpdateValues => throw new NotImplementedException();
        [Browsable(false)]
        public string Join => "join Sala s on (s.SalaId=raspored.SalaId)";
        [Browsable(false)]
        public string PrimaryKeyName => null;

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> output = new List<IEntity>();
            while (reader.Read())
            {
                Raspored raspored = new Raspored();
                raspored.SalaId = (int)reader["SalaId"];
                raspored.TerminId = (int)reader["TerminId"];
                raspored.BrojIndeksa = (string)reader["BrojIndeksa"];
                raspored.NazivSale = (string)reader["Naziv"];
                output.Add(raspored);
            }
            return output;
        }
    }
}
