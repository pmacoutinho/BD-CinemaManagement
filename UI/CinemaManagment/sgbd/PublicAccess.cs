using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagment.Entities;

namespace CinemaManagment.sgbd
{
    class PublicAccess
    {
        private static SqlConnection cn = SGBDCon.getCN();
        
        public static List<Cinema> loadShowingFilms()
        {
            if (!SGBDCon.verifySGBDConnection())
                return null;

            SqlCommand cmd = new SqlCommand("select * from location.f_get_cinemas()", cn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Cinema> lst = new List<Cinema>();

            while (reader.Read())
            {
                Cinema c = new Cinema();
                c.id=Int32.Parse(reader["id"].ToString());
                c.name= reader["name"].ToString();
                c.location = reader["location"].ToString();

                lst.Add(c);
            }

            cn.Close();

            return lst;
        }

        public static List<Film> loadFilmsInExibition(int cinemaId, DateTime date)
        {
            if (!SGBDCon.verifySGBDConnection())
                return null;

            String dataParam = date.ToString("yyyyMMdd");

            SqlCommand cmd = new SqlCommand("select * from public_access.f_get_films_in_exibition_cinema", cn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Film> lst = new List<Film>();

            cmd.CommandText = "select * from public_access.f_get_films_in_exibition_cinema(@Date, @CinemaId)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", dataParam);
            cmd.Parameters.AddWithValue("@CinemaId", cinemaId.ToString());


            while (reader.Read())
            {
                Film f = new Film();

                f.imdb = Int32.Parse(reader["filmId"].ToString());
                f.name = reader["name"].ToString();
                f.director = reader["director"].ToString();
                f.tmpMinutes = Int32.Parse(reader["timeMin"].ToString());

                lst.Add(f);
            }

            cn.Close();

            return lst;
        }

        /**
         * Returns films in exibition ay given date in a given cinema
         */
        public static List<SessionInstance> getOpenSessionsCinema(DateTime date, int cinemaId)
        {
            if (!SGBDCon.verifySGBDConnection())
                return null;

            String dataParam = date.ToString("yyyyMMdd");

            SqlCommand cmd = new SqlCommand("select * from public_access.f_get_open_sessions_cinema(@Date, @CinemaId)", cn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<SessionInstance> lst = new List<SessionInstance>();


            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", dataParam);
            cmd.Parameters.AddWithValue("@CinemaId", cinemaId.ToString());


            while (reader.Read())
            {
                SessionInstance s = new SessionInstance();
                
                Film f = new Film();


                f.imdb = Int32.Parse(reader["filmId"].ToString());
                f.name = reader["name"].ToString();
                f.director = reader["director"].ToString();
                f.tmpMinutes = Int32.Parse(reader["timeMin"].ToString());
                s.film = f;
                
                s.CinemaId = Int32.Parse(reader["cinema"].ToString());
                s.sessionId = Int32.Parse(reader["session"].ToString());
                s.id = Int32.Parse(reader["sessionInst"].ToString());
                s.startDay = DateTime.Parse(reader["startDay"].ToString());
                s.noWeeks = Int32.Parse(reader["noWeeks"].ToString());
                s.roomNumber = Int32.Parse(reader["room"].ToString());
                s.time = DateTime.Parse(reader["time"].ToString());


                lst.Add();
            }

            cn.Close();

            return lst;
        }
    }
}
