using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD2_DataAccess
{
    public class clsLicenseData
    {

        public static DataTable GetAllLicenses(int LicenseID)
        {
            DataTable dtLicenses = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select LicenseID , ApplicationID,LicenseClasses.ClassName,IssueDate
                            ,ExpirationDate,IsActive  from Licenses
                             join LicenseClasses on LicenseClasses.LicenseClassID
                             = Licenses.LicenseClass where LicenseID =@LicenseID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtLicenses.Load(reader);
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
            return dtLicenses;
        }

        public static DataTable GetAllLicensesByPersonID(int PersonID)
        {
            DataTable dtLicenses = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select LicenseID , ApplicationID,LicenseClasses.ClassName,IssueDate
                            ,ExpirationDate,IsActive from Licenses
                             join LicenseClasses on LicenseClasses.LicenseClassID  = Licenses.LicenseClass 
							 join Drivers on Drivers.DriverID =  Licenses.DriverID
							 join People on Drivers.PersonID =  People.PersonID
							 where People.PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtLicenses.Load(reader);
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
            return dtLicenses;
        }

        public static int AddNewLicense(int ApplicationID,int DriverID , int LicenseClass ,
            DateTime IssueDate, DateTime ExpirationDate , string Notes , decimal PaidFees , 
            bool IsActive , byte IssueReason , int CreatedByUserID)
        {
            int LicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Licenses
                            (ApplicationID
                            ,DriverID
                            ,LicenseClass
                            ,IssueDate
                            ,ExpirationDate
                            ,Notes
                            ,PaidFees
                            ,IsActive
                            ,IssueReason
                            ,CreatedByUserID)
                             VALUES
                             (@ApplicationID,@DriverID,@LicenseClass,
                             @IssueDate, @ExpirationDate, @Notes
                            ,@PaidFees , @IsActive ,
                             @IssueReason,@CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                Connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    LicenseID = InsertedID;
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
            return LicenseID;
        }

        public static bool FindByLicenseID(int LicenseID , ref int ApplicationID, ref int DriverID, ref int LicenseClass,
           ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees,
           ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Licenses where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    Notes = (string)reader["Notes"];
                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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

        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees,
            bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int rowsAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update Licenses
             set DriverID = @DriverID 
            ,LicenseClass = @LicenseClass
            ,IssueDate = @IssueDate
            ,ExpirationDate  = @ExpirationDate
            ,Notes = @Notes
            ,PaidFees = @PaidFees
            ,IsActive = @IsActive
            ,IssueReason = @IssueReason
            ,CreatedByUserID  =@CreatedByUserID
            where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


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

        public static bool DeleteLicense(int LicenseID)
        {
            int rowsAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"delete from Licenses where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

        public static bool HasActiveLicense(int ApplicationID)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select *  from Licenses where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static bool DeactivateLicense(int LicenseID)
        {
            int rowsAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update Licenses
             set IsActive = 0
            where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);       

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

        public static bool IsLicenseActive(int LicenseID)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select *  from Licenses where 
                           LicenseID = @LicenseID  and isActive = 1";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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
