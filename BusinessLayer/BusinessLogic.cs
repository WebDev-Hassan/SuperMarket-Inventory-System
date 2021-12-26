using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BusinessLogic
    {
        private DAL db = new DAL();
        private string query;
        SqlDataReader sdr;

        public void SignUp(User i)
        {
            query = @"Insert into Users Values('" + i.Name + "','" + i.Email + "','" + i.Password + "')";
            db.IDU(query);
        }
        public User SignIn(User i)
        {
            User user;
            query = @"Select * from Users where Email='" + i.Email + "' AND Password='" + i.Password + "'";

            sdr = db.GetReader(query);

            if (sdr.Read())
            {
                user = new User();
                user.ID = int.Parse(sdr[0].ToString());
                user.Name = sdr[1].ToString();
                user.Email = sdr[2].ToString();
                user.Password = sdr[3].ToString();
                sdr.Close();
                db.CloseConnection();
                return user;
            }

            return null;
        }

        // For Closing the Reader & Connection after SignIn (Ignore this for now)
        public void CloseReader()
        {
            sdr.Close();
            db.CloseConnection();
        }
    }
}
