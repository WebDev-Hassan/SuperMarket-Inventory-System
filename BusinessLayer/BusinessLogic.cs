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

        #region SignUp Functions
        public User SignUp(User i)
        {
            try
            {
                if (SignUp_checkAccount(i))
                {
                    query = @"Insert into Users Values('" + i.Name + "','" + i.Email + "','" + i.Password + "')";
                    db.IDU(query);
                    return SignIn(i);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
        private bool SignUp_checkAccount(User i)
        {
            try
            {
                var UserList = new List<User>();
                query = @"Select * from Users";
                sdr = db.GetReader(query);

                // Storing Users in UserList
                while (sdr.Read())
                {
                    User user = new User();
                    user.ID = int.Parse(sdr[0].ToString());
                    user.Name = sdr[1].ToString();
                    user.Email = sdr[2].ToString();
                    user.Password = sdr[3].ToString();
                    UserList.Add(user);
                }
                CloseReader();

                // Checking any Matching Emails
                foreach (var u in UserList)
                {
                    if (i.Email == u.Email)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        #endregion

        #region SignIn Functions
        public User SignIn(User i)
        {
            return SignIn_checkAccount(i);

            //if (SignIn_checkAccount(i))
            //{
            //    query = @"Select * from Users where Email='" + i.Email + "' AND Password='" + i.Password + "'";
            //    sdr = db.GetReader(query);

            //    if (sdr.Read())
            //    {
            //        user = new User();
            //        user.ID = int.Parse(sdr[0].ToString());
            //        user.Name = sdr[1].ToString();
            //        user.Email = sdr[2].ToString();
            //        user.Password = sdr[3].ToString();
            //        sdr.Close();
            //        db.CloseConnection();
            //        return user;
            //    }
            //}
            //return null;

        }

        private User SignIn_checkAccount(User i)
        {
            try
            {
                var UserList = new List<User>();
                //Efficient Query
                query = @"Select * from Users where Email = '"+i.Email+"'";
                //query = @"Select * from Users ";
                sdr = db.GetReader(query);

                // Storing Users in UserList
                while (sdr.Read())
                {
                    User user = new User();
                    user.ID = int.Parse(sdr[0].ToString());
                    user.Name = sdr[1].ToString();
                    user.Email = sdr[2].ToString();
                    user.Password = sdr[3].ToString();
                    UserList.Add(user);
                }
                CloseReader();

                // Checking any Matching Emails
                foreach (var u in UserList)
                {
                    if (i.Email == u.Email)
                    {
                        return u;
                    }
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }

        }
        #endregion


        #region Utility Functions

        // For Closing the Reader & Connection after SignIn (Ignore this for now)
        public void CloseReader()
        {
            sdr.Close();
            db.CloseConnection();
        }

        #endregion
    }
}
