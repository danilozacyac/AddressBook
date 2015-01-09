using System;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;

namespace AddressBook.DataAccess
{
    public class Conexiones
    {

        public static OleDbConnection GetConnection()
        {
            string bdStringSql = ConfigurationManager.ConnectionStrings["Address"].ConnectionString;
            OleDbConnection realConnection = new OleDbConnection(bdStringSql);
            return realConnection;


        }

    }
}
