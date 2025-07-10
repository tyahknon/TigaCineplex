using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TigaCineplex.Class
{
    class Movie
    {
        public int id ;
        public string name = "";
        public string genre = "";
        public string duration = "";
        public string description = "";
        public string rating = "";
       

        public bool SaveMovie(Movie param)
        {
            bool savesuccess = true;
            try
            {
                SqlConnection connection;
                //open the connection
                Database db = new Database();
                connection = db.OpenConnection();
                //handle the parameter
                String qry = "INSERT INTO tblMovie (MovieName,Genre,Duration," +
                "Description,Rating) VALUES(@v1,@v2,@v3,@v4,@v5)";

                //sql command
                SqlCommand com = new SqlCommand(qry, connection);
                //pass the parameters contents to each value
                com.Parameters.AddWithValue("@v1", param.name);
                com.Parameters.AddWithValue("@v2", param.genre);
                com.Parameters.AddWithValue("@v3", param.duration);
                com.Parameters.AddWithValue("@v4", param.description);
                com.Parameters.AddWithValue("@v5", param.rating);
                

         
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
                MessageBox.Show(e.Message, "Movie (SaveMovie)");
            }
            return savesuccess;
        }

        public List<Movie> GetMovie(string param)
        {
            List<Movie> rtn = new List<Movie>();
            try
            {
                //qry
                string qry = "SELECT * FROM tblMovie";
                //database
                SqlConnection connection;
                //open the connection
                Database db = new Database();
                connection = db.OpenConnection();
                //command
                SqlCommand cmd = new SqlCommand(qry, connection);
              
                //parameter
             
                //execute reader
                SqlDataReader rd = cmd.ExecuteReader();
                //loop
                if (rd.HasRows)
                {
                    //loop
                    while (rd.Read())
                    {
                        Movie mv = new Movie();
                        mv.id = Convert.ToInt32(rd[0]);
                        mv.name = rd[1].ToString();
                        mv.genre = rd[2].ToString();
                        mv.duration = rd[3].ToString();
                        mv.description = rd[4].ToString();
                        mv.rating = rd[5].ToString();
               
                        rtn.Add(mv);
                    }
                }
                else
                {
                    rtn = null;//empty list
                }
                //dispose and close
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Movie save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtn;
        }
        public bool UpdateRecords()
        {
            bool rtn = false;
            try
            {
                //qry
                string qry = "UPDATE tblMovie SET MovieName=@v1,Genre=@v2,Duration=@v3," +
                    "Description=@v4,Rating=@v5" +
                    " WHERE MovieID=@v6";
                //database
                //database
                SqlConnection connection;
                //open the connection
                Database db = new Database();
                connection = db.OpenConnection();
                //command
                SqlCommand cmd = new SqlCommand(qry, connection);
                //parameter
                cmd.Parameters.AddWithValue("@v1", name);
                cmd.Parameters.AddWithValue("@v2", genre);
                cmd.Parameters.AddWithValue("@v3", duration);
                cmd.Parameters.AddWithValue("@v4", description);
                cmd.Parameters.AddWithValue("@v5", rating);
                cmd.Parameters.AddWithValue("@v6", id);
                //execute
                if (cmd.ExecuteNonQuery() > 0)
                {
                    rtn = true;
                }
                //dispose and close
                cmd.Dispose();
                connection.Close();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "UpdateRecord Movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtn;
        }//end of method
        public bool DeleteRecord()
        {
            bool rtn = false;
            try
            {
                //qry
                string qry = "DELETE FROM tblMovie WHERE MovieID=@v1";
                //database
                SqlConnection connection;
                //open the connection
                Database db = new Database();
                connection = db.OpenConnection();
                //command
                SqlCommand cmd = new SqlCommand(qry, connection);
                //param
                cmd.Parameters.AddWithValue("@v1", id);
                //execite
                if (cmd.ExecuteNonQuery() > 0)
                {
                    rtn = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "DeleteRecord Movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtn;
        }
        public List<Movie> FilterMovie(int param1, int param2, string param3)
        {//param1 = select field,param2 = order,param3 = email
            List<Movie> rtn = new List<Movie>();
            try
            {
                //create array variable for the fields and sort order
                string[] selectfield = { "MovieID", "Genre", "Duration", "Rating" };
                string[] orders = { "ASC", "DESC" };
                //qry
                string qry = "SELECT * FROM tblMovie where MovieID=@v1 ORDER BY " + selectfield[param1] +
                    " " + orders[param2];
                //database
                SqlConnection connection;
                //open the connection
                Database db = new Database();
                connection = db.OpenConnection();
                //command
                SqlCommand cmd = new SqlCommand(qry, connection);
                //get the id
                Users u = new Users();
                u.username = param3;
                int id = u.GetID();
                //parameter
                cmd.Parameters.AddWithValue("@v1", id);
                //execute reader
                SqlDataReader rd = cmd.ExecuteReader();
                //loop
                if (rd.HasRows)
                {
                    //loop
                    while (rd.Read())
                    {
                        Movie mv = new Movie();
                        mv.id = Convert.ToInt32(rd[0]);
                        mv.name = rd[1].ToString();
                        mv.genre = rd[2].ToString();
                        mv.duration = rd[3].ToString();
                        mv.description = rd[4].ToString();
                        mv.rating = rd[5].ToString();
                      
                        rtn.Add(mv);
                    }
                }
                else
                {
                    rtn = null;//empty list
                }
                //dispose and close
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Movie save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtn;
        }

    }
}
