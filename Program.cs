using System;
using System.Data.SqlClient;
using Dapper;

namespace p4lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using SqlConnection conn = new SqlConnection(connectionString);


            var db = new DB();
            db.Select(connectionString);
            // db.Insert(connection, 90, "RegionZ");

            Region reg = new Region();
            reg.RegionID = 300;
            //db.Delete(connection,reg);
        }
    }
}
