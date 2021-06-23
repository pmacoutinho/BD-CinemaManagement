using CinemaManagment.Entities;
using System;
using System.Collections;
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

        public static List<Client> loadClients()
        {

            if (!SGBDCon.verifySGBDConnection())
                return null;

            List<Client> lst = new List<Client>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", cn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Client c = new Client();
                c.id = Int32.Parse(reader["ClientId"].ToString());
                c.name = reader["ClientName"].ToString();
                c.email = reader["email"].ToString();
                c.birthday = DateTime.Parse(reader["birthdat"].ToString());

                lst.Add(c);
            }

            cn.Close();

            return lst;
        }

        public static void newTicket(Ticket t)
        {
            if (!SGBDCon.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("operations.p_new_ticket", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("@SellerId", t.seller));
            cmd.Parameters.Add(new SqlParameter("@ClientId", t.client));
            cmd.Parameters.Add(new SqlParameter("@SessionInstanceId", t.session));
            cmd.Parameters.Add(new SqlParameter("@SeatNumber", t.seatnumber));
            cmd.Parameters.Add(new SqlParameter("@Price", t.price.ToString()));

            try
            { 
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add ticket to the database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
