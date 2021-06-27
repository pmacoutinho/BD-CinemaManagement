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
using CinemaManagment.Common;

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

        public static void updateClient(Client c)
        {
            if (!SGBDCon.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("operations.p_update_client", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("@ClientId", c.id));
            cmd.Parameters.Add(new SqlParameter("@ClientName", c.name));
            cmd.Parameters.Add(new SqlParameter("@ClientEmail", c.email));
            cmd.Parameters.Add(new SqlParameter("@Birthday", c.birthday.ToString("yyyyMMdd")));



            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update contact in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void deleteClient(int cId)
        {
            if (!SGBDCon.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("operations.p_delete_client", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("@ClientId", cId));

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete contact in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
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

        public static List<Ticket> loadTickets(int ticketId)
        {
            if (!SGBDCon.verifySGBDConnection())
                return null;

            List<Ticket> lst = new List<Ticket>();

            SqlCommand cmd = new SqlCommand("SELECT * from operations.f_get_tickets(@CinemaId)", cn);
            cmd.Parameters.Add(new SqlParameter("@CinemaId", ticketId.ToString()));

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Ticket t = new Ticket();
                t.id = Int32.Parse(reader["ID"].ToString());
                t.price = Int32.Parse(reader["Price"].ToString());
                t.clientName = reader["Client"].ToString(); 
                t.sellerName = reader["Seller"].ToString();
                lst.Add(t);
            }

            cn.Close();

            return lst;
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

        public static List<CleaningRecord> getCleaningRecords(bool allRecords)
        {
            SGBDCon.verify();

            Employee e = User.getInstance().e;
            

            SqlCommand cmd;

            if (allRecords)
            {
                cmd = new SqlCommand("SELECT * from operations.f_get_cleaning_records_cinema(@CinemaId)", cn);
            }
            else
            {
                cmd = new SqlCommand("SELECT * from operations.f_get_cleaning_records(@CinemaId, @EmployeeId)", cn);
                cmd.Parameters.Add(new SqlParameter("@EmployeeId", e.id));
            }
                
                
            cmd.Parameters.Add(new SqlParameter("@CinemaId", e.cinema));
            
            SqlDataReader reader = cmd.ExecuteReader();

            List<CleaningRecord> crLst = new List<CleaningRecord>();
            while (reader.Read())
            {
                CleaningRecord cr = new CleaningRecord();
                cr.sCinema = Int32.Parse(reader["sCinema"].ToString());
                cr.sNum = Int32.Parse(reader["sNum"].ToString());
                cr.func = Int32.Parse(reader["func"].ToString());
                cr.tm = DateTime.Parse(reader["tm"].ToString());
                crLst.Add(cr);
            }

            return crLst;
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
        
        public static void deleteCleaningRecord(CleaningRecord cr)
        {
            SGBDCon.verify();
            
            SqlCommand cmd = new SqlCommand("operations.p_delete_cleaning_record", cn)
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
                throw new Exception("Failed to delete Clening Record in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }

            
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

        public static List<SessionInstance> loadSessionInstances(int sessionInstanceId)
        {
            if (!SGBDCon.verifySGBDConnection())
                return null;

            List<SessionInstance> lst = new List<SessionInstance>();

            SqlCommand cmd = new SqlCommand("SELECT * from operations.f_get_session_instance(@CinemaId)", cn);
            cmd.Parameters.Add(new SqlParameter("@CinemaId", sessionInstanceId.ToString()));

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SessionInstance si = new SessionInstance();
                si.id = Int32.Parse(reader["ID"].ToString());
                si.filmName = reader["Film"].ToString();
                si.time = DateTime.Parse(reader["Start Time"].ToString());
                si.roomNumber = Int32.Parse(reader["Room"].ToString());
                lst.Add(si);
            }

            cn.Close();

            return lst;
        }
    }
}
