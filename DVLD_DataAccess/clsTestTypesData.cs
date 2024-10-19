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
    public class clsTestTypesData
    {

        public static DataTable GetAllTestTypes()
        {
            DataTable dtApplicationTypes = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from TestTypes";

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
        public static bool FindByTestTypes(int TestTypeID, ref string TestTypeTitle
            ,ref string TestTypeDescription,ref decimal TestTypeFees)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from TestTypes where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees = (decimal)reader["TestTypeFees"];
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
        public static bool Update(int TestTypeID,  string TestTypeTitle
            ,  string TestTypeDescription,  decimal TestTypeFees)
        {
            int rowsAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update TestTypes
             set TestTypeTitle = @TestTypeTitle 
            ,TestTypeDescription = @TestTypeDescription
            ,TestTypeFees = @TestTypeFees
            where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
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
