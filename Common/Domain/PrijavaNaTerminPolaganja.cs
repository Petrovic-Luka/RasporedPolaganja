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
    public class PrijavaNaTerminPolaganja : IEntity
    {
        
        public string BrojIndeksa { get; set; }
        [Browsable(false)]
        public int TerminId { get; set; }

        public int? SalaId { get; set; }
        [Browsable(false)]
        public DateTime DatumPrijave { get; set; }     
        public bool Izasao { get; set; } = false;

        public string Predmet { get; set; }

        public string Sala {  get; set; }
        public string Tip { get; set; }
        public DateTime DatumOdrzavanja { get; set; }

        [Browsable(false)]
        public string TableName => "PrijavaNaTerminPolaganja";
        [Browsable(false)]
        public string InsertValues => $"{TerminId},'{BrojIndeksa}',{(SalaId==null? "null":SalaId.Value.ToString())},'{DatumPrijave.ToString("yyyyMMdd HH:mm")}',{(Izasao ? 1 : 0)}";
        [Browsable(false)]
        public string UpdateValues => $"SalaId={SalaId.Value}";
        [Browsable(false)]
        public string Join
        {
            get
            { string s= "join TerminPolaganja t on (t.TerminPolaganjaId=TerminId) join ispit i on (i.IspitId=t.IspitId)";
                if (SalaId.HasValue) s += "join sala s on (PrijavaNaTerminPolaganja.SalaId=s.SalaId)";
                return s;
            }
        }
        [Browsable(false)]
        public string PrimaryKeyName => null;

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> output = new List<IEntity>();
            while (reader.Read())
            {
                PrijavaNaTerminPolaganja prijava = new PrijavaNaTerminPolaganja();
                prijava.BrojIndeksa = (string)reader["BrojIndeksa"];
                try
                {
                    prijava.SalaId = (int)reader["SalaId"];
                }
                catch
                {
                    prijava.SalaId = null;
                }
                prijava.Izasao = (bool)reader["Izasao"];
                prijava.DatumPrijave = (DateTime)reader["DatumPrijave"];
                prijava.TerminId = (int)reader["TerminId"];
                prijava.DatumOdrzavanja = (DateTime)reader["Datum"];
                prijava.Predmet = (string)reader["Naziv"];
                prijava.Tip = (string)reader["Tip"];
                if(prijava.SalaId!=null)
                {
                    try
                    {
                        prijava.Sala = reader.GetString(16);
                    }
                    catch (Exception)
                    {

                        prijava.Sala = "";
                    }
                }
                output.Add(prijava);
            }
            return output;
        }
    }
}
