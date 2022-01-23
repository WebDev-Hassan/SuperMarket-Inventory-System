using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer;
using BusinessLayer.Models;

namespace BusinessLayer
{
    public class BusinessLogic
    {
        private DAL db = new DAL();
        private string query;
        SqlDataReader sdr;

        #region SignUp Functions
        // Inserts Unique Accounts
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
        // Checks any Matching Email and return boolean - Match = false else True
        private bool SignUp_checkAccount(User i)
        {
            try
            {
                var UserList = GetAllbyEmail(i);

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
        // Only returns the User
        public User SignIn(User i)
        {
            return SignIn_checkAccount(i);
        }

        // Check Accounts and return User from the database
        private User SignIn_checkAccount(User i)
        {
            try
            {
                var UserList = GetAllbyEmail(i);

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

        // Returns List of Users having same Emails
        public List<User> GetAllbyEmail(User i)
        {
            try
            {
                var UserList = new List<User>();
                //Efficient Query
                query = @"Select * from Users where Email = '" + i.Email + "'";
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
                return UserList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //Returns List of Products
        public List<Product> GetAllProducts()
        {
            try
            {
                var ProductsList = new List<Product>();
                query = @"Select * from Products";
                sdr = db.GetReader(query);

                // Storing Users in UserList
                while (sdr.Read())
                {
                    var product = new Product();
                    product.ID = int.Parse(sdr[0].ToString());
                    product.Title = sdr[1].ToString();
                    product.Quantity = int.Parse(sdr[2].ToString());
                    product.SalePrice = double.Parse(sdr[3].ToString());
                    product.PurchasePrice = double.Parse(sdr[3].ToString());
                }
                CloseReader();
                return ProductsList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion
    }
}
