using CinemaManagment.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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

            SqlCommand cmd = new SqlCommand("SELECT * from operations.f_get_clients()", cn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Client c = new Client();
                c.id = Int32.Parse(reader["ClientId"].ToString());
                c.name = reader["ClientName"].ToString();
                c.email = reader["email"].ToString();
                c.birthday = DateTime.Parse(reader["birthday"].ToString());

                lst.Add(c);
            }

            cn.Close();

            return lst;
        }

        public static Client getClient(int employeeId)
        {

            if (!SGBDCon.verifySGBDConnection())
                return null;


            SqlCommand cmd = new SqlCommand("SELECT * from operations.f_get_client(@EmployeeId)", cn);
            cmd.Parameters.Add(new SqlParameter("@EmployeeId", employeeId.ToString()));
            SqlDataReader reader = cmd.ExecuteReader();
            Client c = new Client();
            while (reader.Read())
            {
                
                c.id = Int32.Parse(reader["ClientId"].ToString());
                c.name = reader["ClientName"].ToString();
                c.email = reader["email"].ToString();
                c.birthday = DateTime.Parse(reader["birthday"].ToString());

            }

            cn.Close();

            return c;
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

        public static Reservation getSeats(int si)
        {
            if (!SGBDCon.verifySGBDConnection())
                return null;

            List<int> lst = new List<int>();
            int nSeats = 0;

            Reservation r = new Reservation();

            SqlCommand cmd = new SqlCommand("SELECT * from operations.f_get_res_session_inst(@SessionInst)", cn);
            cmd.Parameters.Add(new SqlParameter("@SessionInst", si.ToString()));
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Debug.WriteLine(reader["seat"].ToString());
                if (!reader["seat"].ToString().Equals(""))
                {
                    int seat = Int32.Parse(reader["seat"].ToString());
                    lst.Add(seat);
                }

                nSeats = Int32.Parse(reader["nSeats"].ToString());
            }

            cn.Close();

            r.lst = lst;
            r.nSeats = nSeats;

            return r;
        }

        public static int newCleaningRecord(CleaningRecord cr)
        {
            if (!SGBDCon.verifySGBDConnection())
                return -1;
            SqlCommand cmd = new SqlCommand("operations.p_new_cleaning_record", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("@Cinema", cr.sCinema));
            cmd.Parameters.Add(new SqlParameter("@RoomNumber", cr.sNum));
            cmd.Parameters.Add(new SqlParameter("@Employee", cr.func));
            cmd.Parameters.Add(new SqlParameter("@Time", cr.tm.ToString("yyyyMMdd")));

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

            return (int)cr.sNum;
        }

        public static int newSessionInstance(SessionInstance si)
        {
            if (!SGBDCon.verifySGBDConnection())
                return -1;
            SqlCommand cmd = new SqlCommand("operations.p_add_session_instance", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("@SessionId", si.sessionId));
            cmd.Parameters.Add(new SqlParameter("@RoomNumber", si.roomNumber));
            cmd.Parameters.Add(new SqlParameter("@InstTime", si.time.ToString("HH:mm")));

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

            return (int)si.sessionId;
        }
    }
}
