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
        public static string[] gbJobtype;
        public static string [] gbJoblocation;
        public static string [] gbJobdescription;
        public static string [] gbJobCompany;

        public static string gbSelectedJob = "";

        public static string[] gbDbService;

        public static string gbSelectedSearchJob = "";

        public static int selectedBox0 = 0;
        public static int selectedBox1 = 1;
        public static int selectedBox2 = 2;
        public static int selectedBox3 = 3;
        public static int selectedBox4 = 4;
        public static int selectedBox5 = 5;
    }
}
