using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                // regex paroļu pārbaudei https://stackoverflow.com/questions/5859632/regular-expression-for-password-validation
                Regex passwordRegex = new Regex(@"^(?=.*[a - z])(?=.*[A - Z])(?=.*\d)(?=.*[^\da - zA - Z]).{ 8, 15 }$");
                Match passwordMatch = passwordRegex.Match(password);
                // regex epastu pārbaudei https://stackoverflow.com/questions/5342375/regex-email-validation
                Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = emailRegex.Match(email);

                
                if (match.Success && passwordMatch.Success) 
                {
                    string hashedPassword = HashPassword(password);
                    string insertQuery = "INSERT INTO Users (Username, Name, Password, Email, Role) " +
                    "VALUES (@Username, @Name, @Password, @Email, @Role)";
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
                }else if (!match.Success)
                {
                    MessageBox.Show("Wrong email validation. Please choose another.");
                    return;
                }else if (!passwordMatch.Success)
                {
                    MessageBox.Show("Password must be 8–25 characters long and include at least one uppercase letter and one special character!");
                    return;
                }

                
            }
        }

        public void LoadData(string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                //Users table datu iegusana
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

                // Tasks table datu iegusana
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

                // UserTasks table datu iegusana
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

        public bool saveUserAnwser(int userId, int taskId, string userAnswer, string programLanguage)
        {
            bool isCorrect = false;
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();
                string getAnswerQuery = "SELECT Answer from Tasks WHERE IdTasks = @taskId";
                using (SqlCommand getAnswerCmd = new SqlCommand(getAnswerQuery, con))
                {
                    getAnswerCmd.Parameters.AddWithValue("@taskId", taskId);
                    object correctAnswerObj = getAnswerCmd.ExecuteScalar();
                    if (correctAnswerObj != null)
                    {
                        string correctAnswer = correctAnswerObj.ToString().Trim();
                        if (string.Equals(userAnswer, correctAnswer, StringComparison.OrdinalIgnoreCase))
                        {
                            isCorrect = true;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show($"Pareizā atbilde nav atrasta uzdevumam ar Id: {taskId}");
                        return false;
                    }
                }
                string insertQuery = @"INSERT INTO UserTasks (IdUser, IdTask, UserAnswer, IsCorrect, Language)
                                    VALUES (@userId, @taskId, @userAnswer, @isCorrect, @language);";
                
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@taskId", taskId);
                    cmd.Parameters.AddWithValue("@userAnswer", userAnswer);
                    cmd.Parameters.AddWithValue("@isCorrect", isCorrect);
                    cmd.Parameters.AddWithValue("@language", programLanguage);

                    cmd.ExecuteNonQuery();
                }
            }

            LoadData(Program.connectionString);
            return isCorrect;
        }

        public List<int> getCompletedTaskId(int userId, string programLanguage)
        {
            List<int> completedTasks = new List<int>();

            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();
                string query = "SELECT IdTask from UserTasks WHERE IdUser = @userId and IsCorrect = 1 and Language = @language";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@language", programLanguage);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int taskId = reader.GetInt32(0);
                            completedTasks.Add(taskId);
                        }
                    }
                }
            }
            return completedTasks;
        }
    }
}
