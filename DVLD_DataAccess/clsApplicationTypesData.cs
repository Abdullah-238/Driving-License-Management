using DVLD2_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLV2_BusinessLogic
{
    public class clsApplicationTypesData
    {
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dtApplicationTypes = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from ApplicationTypes";

            SqlCommand command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtApplicationTypes.Load(reader);
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
            return dtApplicationTypes;
        }
        public static bool FindByApplicationTypes(int ApplicationTypeID,  ref string ApplicationTypeTitle,
            ref decimal ApplicationFees)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = (decimal)reader["ApplicationFees"];
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
        public static bool Update(int ApplicationTypeID,  string ApplicationTypeTitle,
             decimal ApplicationFees)
        {
            int rowsAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update ApplicationTypes
             set ApplicationTypeTitle = @ApplicationTypeTitle 
            ,ApplicationFees = @ApplicationFees
            where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
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

    }
}
