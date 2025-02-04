using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_for_programming
{
    public class DataManager
    {
        private static DataManager _instance;
        public DataSet DataSet { get; private set; }

        private DataManager()
        {
            DataSet = new DataSet();
        }

        public static DataManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataManager();
                }
                return _instance;
            }
        }

        public void LoadData(string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string userQuery = $"SELECT * FROM Users";
                SqlDataAdapter userAdapter = new SqlDataAdapter(userQuery, con);
                userAdapter.TableMappings.Add("Table", "Users");
                DataTable userTable = new DataTable("Users");
                userAdapter.Fill(userTable);
                DataSet.Tables.Add(userTable);
            }
        }
    }
}
