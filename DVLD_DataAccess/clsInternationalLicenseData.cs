using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD2_DataAccess
{
    public class clsInternationalLicenseData
    {

        public static DataTable GetAllINternationalLicenses(int LicenseID)
        {
            DataTable dtLicenses = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from InternationalLicenses Where IssuedUsingLocalLicenseID
                        = @LicenseID";

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

        public static int AddNewInternationalLicense(int ApplicationID, int DriverID, 
            int IssuedUsingLocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int InternationalLicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO InternationalLicenses
                            (ApplicationID
                            ,DriverID
                            ,IssuedUsingLocalLicenseID
                            ,IssueDate
                            ,ExpirationDate
                            ,IsActive
                            ,CreatedByUserID)
                             VALUES
                             (@ApplicationID,@DriverID,@IssuedUsingLocalLicenseID,
                             @IssueDate, @ExpirationDate, @IsActive ,
                             @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                Connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    InternationalLicenseID = InsertedID;
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
            return InternationalLicenseID;
        }

        public static bool FindByLicenseID(ref int InternationalLicenseID ,
            ref int ApplicationID, ref int DriverID,
             int IssuedUsingLocalLicenseID,
            ref DateTime IssueDate, ref DateTime ExpirationDate,
            ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from InternationalLicenses 
                            where IssuedUsingLocalLicenseID = @LocalLicenseID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@LocalLicenseID", IssuedUsingLocalLicenseID);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    InternationalLicenseID = (int)reader["InternationalLicenseID"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    IsActive = (bool)reader["IsActive"];
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

        public static bool UpdateInternationalLicenseID(int InternationalLicenseID, int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int rowsAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update InternationalLicenses
             set ApplicationID = @ApplicationID 
            ,DriverID = @DriverID
            ,IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID
            ,IssueDate  = @IssueDate
            ,ExpirationDate = @ExpirationDate
            ,IsActive = @IsActive
            ,CreatedByUserID  =@CreatedByUserID
            where InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
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

        public static bool DeleteInternationalLicenseID(int InternationalLicenseID)
        {
            int rowsAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"delete from InternationalLicenses where InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

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

        public static bool IsDriverHasActiveInternationalLicense(int LocalLicenseID)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from InternationalLicenses where
                             IssuedUsingLocalLicenseID = @LocalLicenseID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);

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
