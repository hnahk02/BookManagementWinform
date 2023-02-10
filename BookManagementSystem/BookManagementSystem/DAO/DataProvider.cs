using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.DAO
{
    internal class DataProvider
    {
        private string connection_str = "Data Source=KHANH;Initial Catalog=BookManagementSystem;Integrated Security=True";
        
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);


                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] param)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if(param != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParam)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] param)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (param != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParam)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }

            return data;
        }


    }
}
