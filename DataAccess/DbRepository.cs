using Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DbRepository : IDbRepository<IEntity>
    {
        public void Add(IEntity entity)
        {
            string command = $"insert into {entity.TableName}";
            if (entity.PrimaryKeyName != null)
            {
                command += $" output inserted.{entity.PrimaryKeyName} ";
            }

            command += $" values ({entity.InsertValues})";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);
            if (entity.PrimaryKeyName != null)
            {
                int primaryKey = (int)cmd.ExecuteScalar();
                entity.GetType().GetProperty(entity.PrimaryKeyName).SetValue(entity, primaryKey);
            }
            else
            {
                int x = cmd.ExecuteNonQuery();
                Console.WriteLine("Affected rows insert: " + x);
            }
        }

        public void Close()
        {
            DbConnectionFactory.Instance.GetDbConnection().Close();
        }

        public void Commit()
        {
            DbConnectionFactory.Instance.GetDbConnection().Commit();
        }

        public void Delete(IEntity entity, string criteria)
        {
            string command = $"delete from {entity.TableName} where {criteria}";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);
            int x = cmd.ExecuteNonQuery();
            Console.WriteLine("Affected rows delete: " + x);
        }

        public IEntity Get(IEntity entity, string criteria)
        {
            string command = $"select * from {entity.TableName} ";
            command += " " + entity.Join;
            command += $" where {criteria} ";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);


            var reader = cmd.ExecuteReader();
            List<IEntity> lista = entity.GetList(reader);

            reader.Close();
            if (lista.Count > 0) return lista[0];
            return null;
        }

        public bool Exsists(IEntity entity,string criteria)
        {
            string command = $"select count(*) from {entity.TableName} ";
            command += " " + entity.Join;
            command += $" where {criteria} ";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);
            var reader = cmd.ExecuteReader();
            reader.Read();
            var value = reader.GetInt32(0);
            reader.Close();
            return value != 0;
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            string command = $"select * from {entity.TableName}";

            command += " " + entity.Join;
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);
            var reader = cmd.ExecuteReader();
            List<IEntity> output = entity.GetList(reader);
            reader.Close();

            if (output == null) throw new Exception("Greska pri operaciji");
            return output;
        }

        public void Rollback()
        {
            DbConnectionFactory.Instance.GetDbConnection().Rollback();
        }

        public List<IEntity> Search(IEntity entity, string criteria)
        {
            string command = $"select * from {entity.TableName} ";
            command += " " + entity.Join;
            command += $" where {criteria} ";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);
            var reader = cmd.ExecuteReader();
            List<IEntity> output = entity.GetList(reader);

            reader.Close();
            return output;
        }

        public void Update(IEntity entity, string criteria)
        {
            string command = $"update {entity.TableName} set {entity.UpdateValues} where {criteria}";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);
            int x = cmd.ExecuteNonQuery();

            Console.WriteLine("Affected rows update: " + x);
        }
    }
}
