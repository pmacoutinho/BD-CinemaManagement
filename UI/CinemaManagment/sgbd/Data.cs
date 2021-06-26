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
    class Data
    {
        private static SqlConnection cn = SGBDCon.getCN();
        public static int newFilm(Film f)
        {
            if (!SGBDCon.verifySGBDConnection())
                return -1;
            SqlCommand cmd = new SqlCommand("data.p_new_film", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("@FilmId",f.imdb));
            cmd.Parameters.Add(new SqlParameter("@FilmName", f.name));
            cmd.Parameters.Add(new SqlParameter("@DirectorName", f.director));
            cmd.Parameters.Add(new SqlParameter("@Time", f.tmpMinutes));

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

            return (int) f.imdb;
        }

        public static int newSession(Session s)
        {
            if (!SGBDCon.verifySGBDConnection())
                return -1;
            SqlCommand cmd = new SqlCommand("data.p_new_session", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("@Cinema", s.cinema));
            cmd.Parameters.Add(new SqlParameter("@FilmId", s.filmId));
            cmd.Parameters.Add(new SqlParameter("@StartDay", s.startDay));
            cmd.Parameters.Add(new SqlParameter("@NoWeeks", s.noWeeks));

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

            return (int)s.filmId;
        }

    }
}
