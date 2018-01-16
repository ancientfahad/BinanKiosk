using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanKiosk
{
    public static class Global
    {
        //Global variable which can be used in any forms;
        public static string language = "";
        public static string designation = "";

        public static string gbFirstName = "";
        public static string gbLastName = "";
        public static string gbMI = "";
        public static string gbDepartment = "";
        public static string gbPosition = "";
        public static string gbRoom = "";
        public static string gbDepDesc = "";

        public static string location = "";
        public static string personel = "";

        public static string gbService = "";

        public static string job = "";
        public static string [] gbJobtype = new string[1000];
        public static string [] gbJoblocation = new string[1000];
        public static string [] gbJobdescription = new string[1000];
        public static string [] gbJobCompany = new string[1000];
    }
}
