using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TigaCineplex.Class
{
    class Showtime
    {
        public int id;
        public string mvid = "";
        public string MovieName = "";
        public DateTime startdate ;
        public DateTime enddate ;
        public string time = "";
        public string hallnumber = "";
        public int userid;

        public bool SaveShowtime(Showtime param)
        {
            bool savesuccess = true;
            try
            {
                SqlConnection connection;
                //open the connection
                Database db = new Database();
                connection = db.OpenConnection();
                //handle the parameter
                String qry = "INSERT INTO tblShowtime (MovieID,startdate,enddate," +
                "showtime,hallnumber,userid) VALUES(@v1,@v2,@v3,@v4,@v5,@v6)";

                //sql command
                SqlCommand com = new SqlCommand(qry, connection);
                //pass the parameters contents to each value
                com.Parameters.AddWithValue("@v1", param.mvid);
                com.Parameters.AddWithValue("@v2", param.startdate);
                com.Parameters.AddWithValue("@v3", param.enddate);
                com.Parameters.AddWithValue("@v4", param.time);
                com.Parameters.AddWithValue("@v5", param.hallnumber);
                com.Parameters.AddWithValue("@v6", param.userid);

                savesuccess = com.ExecuteNonQuery() > 0;

                com.Dispose();
                connection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Showtime (SaveShowtime)");
            }
            return savesuccess;
        }

        public List<Showtime> GetShowtime(string param)
        {
            List<Showtime> rtn = new List<Showtime>();
            try
            {
                //qry
                string qry = @"
                    SELECT showtimeid, MovieID, startdate, enddate, showtime, hallnumber, userid
                    FROM tblShowtime 
                    INNER JOIN tblMovie  ON MovieID = MovieID
                    WHERE userid = @v6";
                //database
                SqlConnection connection;
                //open the connection
                Database db = new Database();
                connection = db.OpenConnection();
                //command
                SqlCommand cmd = new SqlCommand(qry, connection);
                //get the id
                Users u = new Users();
                u.username = param;
                int id = u.GetID();
                //parameter
                cmd.Parameters.AddWithValue("@v6", id);
                //execute reader
                SqlDataReader rd = cmd.ExecuteReader();
                //loop
                if (rd.HasRows)
                {
                    //loop
                    while (rd.Read())
                    {
                        Showtime st = new Showtime();
                        st.id = Convert.ToInt32(rd[0]);
                        st.mvid = rd[1].ToString();
                        st.MovieName = rd[2].ToString();
                        st.startdate = Convert.ToDateTime(rd[3]);
                        st.enddate = Convert.ToDateTime(rd[4]);
                        st.time = rd[5].ToString();
                        st.hallnumber = rd[6].ToString();
                        st.userid = Convert.ToInt32(rd[7]);
                        rtn.Add(st);
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
                MessageBox.Show(err.Message, "Showtime save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtn;
        }
        public bool UpdateRecord()
        {
            bool rtn = false;
            try
            {
                //qry
                string qry = "UPDATE tblShowtime SET MovieID=@v1, startdate=@v2, enddate=@v3, " +
              "showtime=@v4, hallnumber=@v5 WHERE ShowtimeID=@v6";
                //database
                //database
                SqlConnection connection;
                //open the connection
                Database db = new Database();
                connection = db.OpenConnection();
                //command
                SqlCommand cmd = new SqlCommand(qry, connection);
                //parameter
                cmd.Parameters.AddWithValue("@v1", mvid);
                cmd.Parameters.AddWithValue("@v2", startdate);
                cmd.Parameters.AddWithValue("@v3", enddate);
                cmd.Parameters.AddWithValue("@v4", time);
                cmd.Parameters.AddWithValue("@v5", hallnumber);
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
                MessageBox.Show(err.Message, "UpdateRecord Showtime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtn;
        }//end of method
        public bool DeleteRecords()
        {
            bool rtn = false;
            try
            {
                //qry
                string qry = "DELETE FROM tblShowtime WHERE ShowtimeID=@v1";
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
                MessageBox.Show(err.Message, "DeleteRecord Showtime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtn;
        }
        public List<Showtime> FilterShowtime(int param1, int param2, string param3)
        {//param1 = select field,param2 = order,param3 = email
            List<Showtime> rtn = new List<Showtime>();
            try
            {
                //create array variable for the fields and sort order
                string[] selectfield = { "ShowtimeID", "MovieID", "startdate", "enddate", "showtime","hallnumber" };
                string[] orders = { "ASC", "DESC" };
                //qry
                string qry = $@"
                    SELECT ShowtimeID, MovieID, MovieName, Startdate, Enddate, showtime, hallnumber, userid
                    FROM tblShowtime 
                    INNER JOIN tblMovie ON MovieID = MovieID
                    WHERE userid = @6
                    ORDER BY {selectfield[param1]} {orders[param2]}";
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
                        Showtime st = new Showtime();
                        st.id = Convert.ToInt32(rd[0]);
                        st.mvid = rd[1].ToString();
                        st.MovieName = rd[2].ToString();
                        st.startdate = Convert.ToDateTime(rd[3]);
                        st.enddate = Convert.ToDateTime(rd[4]);
                        st.time = rd[5].ToString();
                        st.hallnumber = rd[6].ToString();
                        st.userid = Convert.ToInt32(rd[7]);
                        rtn.Add(st);
                    }
                }
                rd.Close();
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Showtime save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtn;
        }
    }
}
