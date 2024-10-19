using DVLD2_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLV2_BusinessLogic
{
    public class clsCountries
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        clsCountries(int CountryID , string CountryName )
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static DataTable GetCountires()
        {
            return clsCountriesData.GetAllPeople();
        }

        public static clsCountries Find(int CountryID)
        {
            bool isFound = false; string CountryName = "";

            isFound = clsCountriesData.Find(CountryID, ref CountryName);

            if (isFound)
                return new clsCountries(CountryID, CountryName);
            else
                return null;

        }
    }
}
