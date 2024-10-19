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
    public class clsApplicationTypes
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }
        clsApplicationTypes(int applicationTypeID, string applicationTypeTitle, decimal applicationFees)
        {
            ApplicationTypeID = applicationTypeID;
            ApplicationTypeTitle = applicationTypeTitle;
            ApplicationFees = applicationFees;
        }
        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypesData.GetAllApplicationTypes();
        }
        public static clsApplicationTypes FindApplicationByApplicationTypeID(int ApplicationTypeID)
        {
            bool isFound = false;
            string ApplicationTypeTitle = ""; decimal ApplicationFees = 0;



            isFound = clsApplicationTypesData.FindByApplicationTypes(ApplicationTypeID, ref ApplicationTypeTitle,
                ref ApplicationFees);

            if (isFound)
                return new clsApplicationTypes(ApplicationTypeID,  ApplicationTypeTitle,
                 ApplicationFees);
            else
                return null;

        }
        public bool Update()
        {
            return clsApplicationTypesData.Update(this.ApplicationTypeID, 
                this.ApplicationTypeTitle, this.ApplicationFees);
        }
      
    }
}
