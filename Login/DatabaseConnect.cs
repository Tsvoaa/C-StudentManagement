using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class DatabaseConnect
    {

        string server = "43.200.12.50";
        int port = 3306;
        string database = "stdm";
        string id = "wskjdd12";
        string pw = "zkskep12";
        string conn = "";


        public string connect()
        {
            conn = String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", server, port, database, id, pw);


            return conn;
        }


    }
}
