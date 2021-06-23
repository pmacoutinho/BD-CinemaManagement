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
    class Operations
    {
        private static SqlConnection cn = SGBDCon.getCN();

        public static int newClient(Client c)
        {
            if (!SGBDCon.verifySGBDConnection())
                return -1;
            SqlCommand cmd = new SqlCommand("operations.p_new_client", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("@ClientName", c.name));
            cmd.Parameters.Add(new SqlParameter("@ClientEmail", c.email));
            cmd.Parameters.Add(new SqlParameter("@Birthday", c.birthday.ToString("yyyyMMdd")));

            var returnParameter = cmd.Parameters.Add("@NewId", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add contact in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }

            var result = returnParameter.Value;

            return (int)result;
        }
    }
}
