using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD2_DataAccess
{
    public class clsUserData
    {

        public static DataTable GetAllUsers()
        {
            DataTable dtUsers = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select UserID , Users.PersonID,
                          fullName = People.FirstName + ' ' + People.SecondName
                          + ' ' + People.ThirdName + ' ' +People.LastName 
                          , UserName , IsActive from Users 
                          join People on People.PersonID = Users.PersonID";

            SqlCommand command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtUsers.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erroe" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return dtUsers;
        }

        public static int AddNewUser(int PersonID, string UserName,
            string Password,bool IsActive)
        {
            int UserID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users
           (PersonID,UserName,Password,IsActive)
            VALUES
           (@PersonID,@UserName,@Password,@IsActive);
           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                Connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    UserID = InsertedID;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return UserID;
        }

        public static bool FindUserByUserID(int UserID, ref int PersonID, ref string UserName, 
            ref string Password,ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                   
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

        public static bool FindUserByPersonID(int PersonID , ref int UserID , ref string UserName,
           ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    IsActive = (bool)reader["IsActive"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }
        public static bool FindUserByUserNameAndPassword( string UserName,
            string Password, ref int UserID, ref int PersonID,  ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users where UserName = @UserName and Password = @Password";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];
                    UserID = (int)reader["UserID"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

        public static bool UpdateUser(int UserID,  int PersonID,  string UserName,
             string Password,  bool IsActive)
        {
            int rowsAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update Users
             set PersonID = @PersonID 
            ,UserName = @UserName
            ,Password = @Password
            ,IsActive  = @IsActive
            where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {

                Connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"delete from Users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool IsUserExsitByUserName(string UserName)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users where UserName = @UserName";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    isFound = true;

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

        public static bool IsUserExsitByUserID(int UserID)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    isFound = true;

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

        public static bool IsUserExsitByPersonID(int PersonID)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    isFound = true;

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

    }
}
