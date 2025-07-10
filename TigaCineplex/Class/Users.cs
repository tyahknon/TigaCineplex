using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TigaCineplex.Class
{
    class Users
    {
        public string userid = "";
        public string name = "";
        public string email = "";
        public string phone = "";
        public string role = "";
        public string username = "";
        public string password = "";
        public string dateregistered = "";

        //create a function to save the record

        public bool SaveUser(Users param)
        {
            bool savesuccess = true;
            try
            {
                SqlConnection connection;
                //open the connection
                Database db = new Database();
                connection = db.OpenConnection();
                //handle the parameter
                String qry = "INSERT INTO tblUsers (usrfullname, usremail, usrphone, usrrole, usrusername, usrpass, dateregistered) " +
             "VALUES (@v1, @v2, @v3, @v4, @v5, @v6, @v7)";

                //sql command
                SqlCommand com = new SqlCommand(qry, connection);
                //pass the parameters contents to each value
                com.Parameters.AddWithValue("@v1", param.name);
                com.Parameters.AddWithValue("@v2", param.email);
                com.Parameters.AddWithValue("@v3", param.phone);
                com.Parameters.AddWithValue("@v4", param.role);
                com.Parameters.AddWithValue("@v5", param.username);
                com.Parameters.AddWithValue("@v6", param.password);

                DateTime today = DateTime.Today;
                string date = today.ToString("yyyy-MM-dd");
                com.Parameters.AddWithValue("@v7", date);
                //execute the query
                if (com.ExecuteNonQuery() > 0)
                {
                    savesuccess = true;
                }
                else
                {
                    savesuccess = false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Users (SaveUsers)");
            }
            return savesuccess;
        }
        // function to chech if username exist
        public bool Checkusername(String param)
        {
            bool usernameexist = false;
            try
            {
                SqlConnection connection;
                Database db = new Database();
                connection = db.OpenConnection();
                string qry = "SELECT * FROM tblUsers where usrusername = @v5";
                //pass the param

                SqlCommand com = new SqlCommand(qry, connection);
                com.Parameters.AddWithValue("@v5", param);
                //sqldatareader
                SqlDataReader rd = com.ExecuteReader();
                //use if statement if reader is empty
                if (rd.HasRows)
                {
                    usernameexist = true;
                }
                //dispose the command
                com.Dispose();
                //close the connection
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "User (Checkusename)");
            }

            return usernameexist;
        }
        public int GetID()
        {
            int userid = 0;
            try
            {
                Database db = new Database();
                using (SqlConnection conn = db.OpenConnection())
                {
                    string qry = "SELECT UserID FROM tblUsers WHERE usremail = @v2";
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@v2", this.email);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        userid = Convert.ToInt32(reader["UserID"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return userid;
        }
      public List<Users>LoginUser(string username, string hashedPassword)
        {
            List<Users> list = new List<Users>();
            try
            {
                Database db = new Database();
                using (SqlConnection connection = db.OpenConnection())
                {
                    string qry = "SELECT * FROM tblUsers WHERE usrusername = @v5 AND usrpass = @v6";
                    using (SqlCommand com = new SqlCommand(qry, connection))
                    {
                        com.Parameters.AddWithValue("@v5", username);
                        com.Parameters.AddWithValue("@v6", hashedPassword);

                        using (SqlDataReader rd = com.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                Users u = new Users
                                {
                                    userid = rd[0].ToString(),
                                    name = rd[1].ToString(),
                                    email = rd[2].ToString(),
                                    phone = rd[3].ToString(),
                                    role = rd[4].ToString(),
                                    username = rd[5].ToString(),
                                    password = rd[6].ToString()
                                };
                                list.Add(u);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "User (LoginUser)");
            }
            return list;
        }
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
