using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD2_DataAccess
{
    public class clsDetainedLicenseDate
    {
        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dtDetainedLicenses = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select DetainID , DetainedLicenses.LicenseID ,DetainedLicenses.DetainDate, 
                             IsReleased , FineFees , ReleaseDate , NationalNo,
                             FullName = FirstName + ' ' + SecondName
                             + ' ' + ThirdName + ' ' +LastName , ReleaseApplicationID
                             from DetainedLicenses
                             join Licenses  on Licenses.LicenseID= DetainedLicenses.LicenseID 
                             join Drivers on Drivers.DriverID = Licenses.DriverID
                             join People on People.PersonID = Drivers.PersonID";

            SqlCommand command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtDetainedLicenses.Load(reader);
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
            return dtDetainedLicenses;
        }

        public static int AddNewDetainLicense(int LicenseID,
            DateTime DetainDate
            ,decimal FineFees,
            int CreatedByUserID, 
            bool IsReleased , DateTime ReleaseDate , 
            int ReleasedByUserID , int ReleaseApplicationID)
        {
            int DetainedID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO DetainedLicenses
                           (LicenseID
                           ,DetainDate
                           ,FineFees
                           ,CreatedByUserID
                           ,IsReleased)
                            VALUES
                           (@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,0);
                           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
           
            try
            {
                Connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    DetainedID = InsertedID;
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
            return DetainedID;
        }

        public static bool FindByDetainID(int DetainID , ref int LicenseID,ref DateTime DetainDate,
            ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased,ref DateTime ReleaseDate,
           ref int ReleasedByUserID,ref int ReleaseApplicationID)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from DetainedLicenses where DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
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

       
        public static bool UpdateDetained(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees,
            int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int rowsAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update DetainedLicenses
             set LicenseID = @LicenseID 
            ,DetainDate = @DetainDate
            ,FineFees = @FineFees
            ,CreatedByUserID = @CreatedByUserID
            ,IsReleased = @IsReleased
            ,ReleaseDate = @ReleaseDate
            ,ReleasedByUserID  = @ReleasedByUserID
            ,ReleaseApplicationID  = @ReleaseApplicationID
            where DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

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

        public static bool FindByLicenseID(int LicenseID , ref int DetainID,
            ref DateTime DetainDate, ref decimal FineFees,
         ref int CreatedByUserID, ref bool IsReleased,
         ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from DetainedLicenses 
                             where LicenseID = @LicenseID and IsReleased = 0 order by DetainID desc";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
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

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select *  from DetainedLicenses where 
                           LicenseID = @LicenseID  and IsReleased = 0 ";

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
