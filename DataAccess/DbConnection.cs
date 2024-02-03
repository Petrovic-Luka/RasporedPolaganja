using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DbConnection
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public DbConnection()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        }

        public void OpenConnection()
        {
            connection?.Open();
        }

        public void CloseConnection()
        {
            connection?.Close();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }
        public void Commit()
        {
            transaction?.Commit();
        }
        public void Rollback()
        {
            transaction.Rollback();
        }
        public SqlCommand CreateCommand(string query = "")
        {
            if (transaction?.Connection == null) transaction = connection.BeginTransaction();

            return new SqlCommand(query, connection, transaction);
        }
        public bool IsReady()
        {
            return (connection != null && connection.State != ConnectionState.Closed);
        }

        public void Close()
        {
            connection?.Close();
            transaction?.Dispose();
            //transaction = null
        }
    }
}
