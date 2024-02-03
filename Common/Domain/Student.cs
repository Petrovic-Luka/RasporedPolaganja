using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Student:IEntity
    {
        public string BrojIndeksa {  get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Sifra { get; set; }

        public string TableName => "Student";

        public string InsertValues => $"'{BrojIndeksa}','{Ime}','{Prezime}','{Email}','{Sifra}'";

        public string UpdateValues => throw new NotImplementedException();

        public string Join => "";

        public string PrimaryKeyName => null;

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> output = new List<IEntity>();
            while (reader.Read())
            {
                Student student = new Student();
                student.BrojIndeksa = (string)reader["BrojIndeksa"];
                student.Ime = (string)reader["Ime"];
                student.Prezime = (string)reader["Prezime"];
                student.Email = (string)reader["Email"];
                student.Sifra = (string)reader["Sifra"];
                output.Add(student);
            }
            return output;
        }
    }
}
