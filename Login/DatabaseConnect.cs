using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections;
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

        public string[,] SqlSelect(string query, int columns)
        {


            try
            {
                using (MySqlConnection mysql = new MySqlConnection(connect()))
                {
                    mysql.Open();

                    
                    string sql = String.Format("{0}", query);

                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    command = new MySqlCommand(query, mysql);
                    MySqlDataReader reader = command.ExecuteReader();

                    int columnsCount = 0;

                    while (reader.Read())
                    {
                        columnsCount++;
                    }

                    reader.Close();

                    string[,] result = new string[columnsCount, columns];

                    reader = command.ExecuteReader();

                    int len = 0;

                    while(reader.Read())
                    {
                        for(int i = 0; i < columns; i++)
                        {
                            result[len, i] = reader[i].ToString();
                        }

                        len++;
                    }

                    reader.Close();
                    mysql.Close();

                    return result;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return null;
            
        }

        public bool SqlOther(string sql)
        {

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(connect()))
                {
                    mysql.Open();

                    

                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    if(command.ExecuteNonQuery() != 1)
                    {
                        mysql.Close();
                        return true;
                    }
                    else
                    {
                        mysql.Close();
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
