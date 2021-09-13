using System;
using System.Data.Entity;

namespace MySqlComMigration
{

    public class MySqlConfiguration : DbConfiguration
    {
        public MySqlConfiguration()
        {
            SetHistoryContext(
                "MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));
        }

        private void SetHistoryContext(string v, Func<object, object, MySqlHistoryContext> p)
        {
            throw new NotImplementedException();
        }
    }
}