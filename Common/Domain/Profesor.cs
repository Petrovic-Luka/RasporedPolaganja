using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Profesor : IEntity
    {
        public int ProfesorId { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Sifra { get; set; }

        public string TableName => "Profesor";

        public string InsertValues => $"'{Ime}','{Prezime}','{Email}','{Sifra}'";

        public string UpdateValues => throw new NotImplementedException();

        public string Join => "";

        public string PrimaryKeyName => "ProfesorId";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> output=new List<IEntity>();
            while (reader.Read())
            {
                Profesor profesor=new Profesor();
                profesor.ProfesorId = (int)reader["ProfesorId"];
                profesor.Ime = (string)reader["Ime"];
                profesor.Prezime = (string)reader["Prezime"];
                profesor.Email = (string)reader["Email"];
                profesor.Sifra = (string)reader["Sifra"];
                output.Add(profesor);
            }
            return output;
        }
    }
}
