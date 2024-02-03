using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DbConnectionFactory
    {
        private static DbConnectionFactory instance;
        private DbConnection connection = new DbConnection();
        public static DbConnectionFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbConnectionFactory();
                }
                return instance;
            }
        }
        private DbConnectionFactory()
        {

        }

        //ako je konekcija vec otvorena, iskoristice nju
        //ako nije, otvorice konekciju
        public DbConnection GetDbConnection()
        {
            if (!connection.IsReady())
            {
                connection.OpenConnection();
            }
            return connection;
        }
    }
}
