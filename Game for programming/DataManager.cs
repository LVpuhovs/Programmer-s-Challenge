using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }

        }

        public void AddUser(string username, string name, string password, string email, string role)
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();
                string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose another.");
                        return;
                    }
                }

                string hashedPassword = HashPassword(password);

                string insertQuery = "INSERT INTO Users (Username, Name, Password, Email, Role) VALUES (@Username, @Name, @Password, @Email, @Role)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Role", role);

                    cmd.ExecuteNonQuery();
                }

                if (DataSet.Tables.Contains("Users"))
                {
                    DataSet.Tables["Users"].Clear();
                }
                LoadData(Program.connectionString);

                MessageBox.Show("Sign-up successful!");
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
                if (DataSet.Tables.Contains("Users"))
                {
                    DataSet.Tables["Users"].Clear(); 
                }
                else
                {
                    DataSet.Tables.Add(new DataTable("Users"));
                }

                userAdapter.Fill(DataSet.Tables["Users"]);


                string taskQuery = $"SELECT * FROM Tasks";
                SqlDataAdapter taskAdapter = new SqlDataAdapter(taskQuery, con);
                taskAdapter.TableMappings.Add("Table", "Tasks");
                if (DataSet.Tables.Contains("Tasks"))
                {
                    DataSet.Tables["Tasks"].Clear();
                }
                else
                {
                    DataSet.Tables.Add(new DataTable("Tasks"));
                }

                taskAdapter.Fill(DataSet.Tables["Tasks"]);


                string userTaskQuery = $"SELECT * FROM UserTasks";
                SqlDataAdapter userTaskAdapter = new SqlDataAdapter(userTaskQuery, con);
                userTaskAdapter.TableMappings.Add("Table", "UserTasks");
                if (DataSet.Tables.Contains("UserTasks"))
                {
                    DataSet.Tables["UserTasks"].Clear();
                }
                else
                {
                    DataSet.Tables.Add(new DataTable("UserTasks"));
                }

                userTaskAdapter.Fill(DataSet.Tables["UserTasks"]);
            }
        }
        

        public User AuthenticateUser(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            DataTable userTable = DataSet.Tables["Users"];
            if (userTable == null)
            {
                MessageBox.Show("User data not loaded.");
                return null;
            }
            User user = (from DataRow row in userTable.Rows
                         where row["Username"].ToString() == username && row["Password"].ToString() == hashedPassword
                         select new User
                         {
                             Username = row["Username"].ToString(),
                             IdUser = (int)row["IdUsers"],
                             Email = row["Email"].ToString(),
                             Role = row["Role"].ToString(),
                         }).FirstOrDefault();
            return user;
        }
    }
}
