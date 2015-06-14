using System;
using System.Data.OleDb;
using System.IO;

namespace History.DAO
{
    public class Connection
    {
        public static OleDbConnection AccessConnection()
        {
            return SILIB.Connections.ConnectionAccess.GetConnection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.Combine("Resources","DataBase.mdb")));
        }
    }
}
