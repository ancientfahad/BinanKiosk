using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BinanKiosk
{
    public static class Config
    {
        public static MySqlConnection conn = new MySqlConnection("SERVER=" + "sql12.freemysqlhosting.net" + ";" + "DATABASE=" + "sql12218595" + ";" + "UID=" + "sql12218595" + ";" + "PASSWORD=" + "d1QUEcxSde" + ";");
        //public static MySqlConnection conn = new MySqlConnection("SERVER=" + "localhost" + ";" + "DATABASE=" + "binan_kiosk" + ";" + "UID=" + "root" + ";" + "PASSWORD=" + "" + ";");
    }
}
