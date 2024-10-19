using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD2_DataAccess
{
    public class clsLicenseClassesData
    {

        public static DataTable GetAllLicensClasses()
        {
            DataTable dtLicensesClass = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from LicenseClasses";

            SqlCommand command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtLicensesClass.Load(reader);
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
            return dtLicensesClass;
        }

        public static bool FindByLicenseClassID(int LicenseClassID, ref string ClassName,
         ref string ClassDescription , ref byte MinimumAllowedAge , ref byte DefaultValidityLength ,
         ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from LicenseClasses where LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = (decimal)reader["ClassFees"];

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

        public static bool FindByLicenseClassName(string ClassName,ref int LicenseClassID,
       ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength,
       ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from LicenseClasses where ClassName = @ClassName";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    LicenseClassID = (int)reader["LicenseClassID"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = (decimal)reader["ClassFees"];

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
