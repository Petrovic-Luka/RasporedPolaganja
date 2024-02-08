using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Common.Domain
{
    [Serializable]
    public class TerminPolaganja : IEntity
    {
        [Browsable(false)]
        public int TerminPolaganjaId { get; set; }
        public DateTime Datum { get; set; }
        [Browsable(false)]
        public int IspitId { get; set; }

        public string Tip { get; set; }

        public bool PotrebanRacunar { get; set; }

        public DateTime PrijavaDo { get; set; }

        [Browsable(false)]
        public int MaxBrojSala { get; set; }

        [Browsable(false)]
        public string TableName => "TerminPolaganja";

        public Ispit Ispit { get; set; }
        [Browsable(false)]
        public string InsertValues => $"'{Datum.ToString("yyyyMMdd HH:mm")}',{IspitId},'{Tip}',{(PotrebanRacunar? 1:0)},'{PrijavaDo.ToString("yyyyMMdd HH:mm")}',{MaxBrojSala}";
        [Browsable(false)]
        public string UpdateValues => throw new NotImplementedException();
        [Browsable(false)]
        public string Join => "join Ispit i on (i.IspitId=TerminPolaganja.IspitId)";
        [Browsable(false)]
        public string PrimaryKeyName => "TerminPolaganjaId";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> output = new List<IEntity>();
            while (reader.Read())
            {
                TerminPolaganja terminPolaganja = new TerminPolaganja();
                terminPolaganja.TerminPolaganjaId = (int)reader["TerminPolaganjaId"];
                terminPolaganja.Datum = (DateTime)reader["Datum"];
                terminPolaganja.IspitId = (int)reader["IspitId"];
                terminPolaganja.Tip = (string)reader["Tip"];
                terminPolaganja.PotrebanRacunar = (bool)reader["PotrebanRacunar"];
                terminPolaganja.PrijavaDo = (DateTime)reader["PrijavaDo"];
                terminPolaganja.MaxBrojSala = (int)reader["MaxBrojSala"];
                Ispit ispit = new Ispit();
                ispit.IspitId = terminPolaganja.IspitId;
                ispit.Naziv = (string)reader["Naziv"];
                ispit.Espb = (int)reader["Espb"];
                terminPolaganja.Ispit=ispit;
                output.Add(terminPolaganja);
            }
            return output;
        }
    }
}
