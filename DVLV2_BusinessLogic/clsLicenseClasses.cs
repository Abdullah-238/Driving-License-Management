using DVLD2_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLV2_BusinessLogic
{
    public class clsLicenseClasses
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }

        public string ClassDescription { get; set; }

        public byte MinimumAllowedAge { get; set; }

        public byte DefaultValidityLength { get; set; }

        public decimal ClassFees { get; set; }
        clsLicenseClasses(int licenseClassID,string  className,
                string classDescription,byte minimumAllowedAge,byte defaultValidityLength,decimal classFees)
        {
            this.LicenseClassID = licenseClassID;
            this.ClassName = className;
            this.ClassDescription = classDescription;
            this.MinimumAllowedAge = minimumAllowedAge;
            this.DefaultValidityLength = defaultValidityLength;
            this.ClassFees = classFees;
        }

        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassesData.GetAllLicensClasses();
        }

        public static clsLicenseClasses FindLicenseByLicenseClassID(int LicenseClassID)
        {

            string ClassName = ""; string ClassDescription = "";
            byte MinimumAllowedAge = 0;  byte DefaultValidityLength = 0;
            decimal ClassFees = 0; 

            bool isFound = false;
           

            isFound = clsLicenseClassesData.FindByLicenseClassID(LicenseClassID, ref ClassName,
                ref ClassDescription  , ref MinimumAllowedAge , ref DefaultValidityLength , ref ClassFees);

            if (isFound)
                return new clsLicenseClasses(LicenseClassID,  ClassName,
                 ClassDescription,  MinimumAllowedAge,  DefaultValidityLength,  ClassFees);
            else
                return null;

        }

        public static clsLicenseClasses FindLicenseByLicenseClassName(string ClassName)
        {

            int ClassID = -1; string ClassDescription = "";
            byte MinimumAllowedAge = 0; byte DefaultValidityLength = 0;
            decimal ClassFees = 0;

            bool isFound = false;


            isFound = clsLicenseClassesData.FindByLicenseClassName(ClassName, ref ClassID,
                ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees);

            if (isFound)
                return new clsLicenseClasses(ClassID, ClassName , 
                 ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;

        }



    }
}
