using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class DAL
    {
        #region DB Variables
        private string dbpath;
        private SqlConnection con;
        private SqlCommand com;
        #endregion   

        // Constructor
        public DAL()
        {
            dbpath = @"Data Source=HASSAN\SQLEXPRESS;Initial Catalog=SuperMarketInventory;Integrated Security=True";
            con = new SqlConnection(dbpath);
        }

        // Open Connection
        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        // Close Connection
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        // IDU (Insert Delete Update)
        public void IDU(String query)
        {
            OpenConnection();
            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            CloseConnection();
        }

        // Get Reader
        public SqlDataReader GetReader(String query)
        {
            OpenConnection();
            com = new SqlCommand(query, con);
            return com.ExecuteReader();
        }
    }
}
