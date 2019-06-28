using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;


namespace MapControlApplication7.db
{
    class DBManager
    {
        private DBManager()
        {

        }
        private static DBManager db = new DBManager();

        public OleDbConnection getConnection()
        {
            OleDbConnection conn = null;
            conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + @"C:\Users\lidan\Documents\Database4.mdb");
            return conn;
        }

        public static DBManager getDBNanager()
        {
            return db;
        }
    }
}
