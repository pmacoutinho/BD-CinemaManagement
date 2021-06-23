using CinemaManagment.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagment.sgbd
{
    /**
     * Utility cclass to handle the connection to the SGBD
     */
    class SGBDCon
    {
        private static SqlConnection cn = getSGBDConnection();


        private static SqlConnection getSGBDConnection()
        {
            return new SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p3g8" + 
                "; uid = " + "p3g8" + ";" + "password = " + "5nbH$X^7");
        }

        public static bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != System.Data.ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }


        public static SqlConnection getCN()
        {
            verifySGBDConnection();
            return cn;
        }


        /*******************/
        
    }
}
