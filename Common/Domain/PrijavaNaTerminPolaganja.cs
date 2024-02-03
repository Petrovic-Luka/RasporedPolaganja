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
    public class PrijavaNaTerminPolaganja:IEntity
    {
        [Browsable(false)]
        public string BrojIndeksa { get; set; }
        [Browsable(false)]
        public int TerminId { get; set; }
        public DateTime DatumPrijave { get; set; }
        [Browsable(false)]
        public bool Izasao { get; set; }=false;
        public string Predmet { get; set; }

        public string Tip { get; set; }
        public DateTime DatumOdrzavanja { get; set; }

        [Browsable(false)]
        public string TableName => "PrijavaNaTerminPolaganja";
        [Browsable(false)]
        public string InsertValues => $"{TerminId},'{BrojIndeksa}','{DatumPrijave.ToString("yyyyMMdd HH:mm")}',{(Izasao? 1:0)}";
        [Browsable(false)]
        public string UpdateValues => throw new NotImplementedException();
        [Browsable(false)]
        public string Join => "join TerminPolaganja t on (t.TerminPolaganjaId=TerminId) join ispit i on (i.IspitId=t.IspitId)";
        [Browsable(false)]
        public string PrimaryKeyName => null;

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> output = new List<IEntity>();
            while (reader.Read())
            {
                PrijavaNaTerminPolaganja prijava = new PrijavaNaTerminPolaganja();
                prijava.BrojIndeksa = (string)reader["BrojIndeksa"];
                prijava.Izasao = (bool)reader["Izasao"];
                prijava.DatumPrijave = (DateTime)reader["DatumPrijave"];
                prijava.TerminId = (int)reader["TerminId"];
                prijava.DatumOdrzavanja = (DateTime)reader["Datum"];
                prijava.Predmet = (string)reader["Naziv"];
                prijava.Tip = (string)reader["Tip"];
                output.Add(prijava);
            }
            return output;
        }
    }
}
