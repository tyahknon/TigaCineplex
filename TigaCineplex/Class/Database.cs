using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TigaCineplex.Class
{
    class Database
    {
        SqlConnection connection;

        //create a function to conect to the database
        public SqlConnection OpenConnection()
        {
            try
            {
                //initialiaze the variable connection
                connection = new SqlConnection();
                //set the connection string
                connection.ConnectionString = "Data Source=LAPTOP-LVSJ0TBE\\SQLEXPRESS; Initial Catalog=TigaCineplex_DB; Integrated Security=true; TrustServerCertificate=True;";
                //open the connection
                connection.Open();
               // MessageBox.Show("Connected");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Database Connection Error");
            }
            return connection;
        }

    }
}
