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
    class Management
    {
        private static SqlConnection cn = SGBDCon.getCN();

        // todo
        public static int newEmployee(Employee e)
        {
            if (!SGBDCon.verifySGBDConnection())
                return -1;
            SqlCommand cmd = new SqlCommand("operations.p_new_employee", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("@Name", e.name));
            cmd.Parameters.Add(new SqlParameter("@Email", e.email));
            cmd.Parameters.Add(new SqlParameter("@Cinema", e.cinema.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Shift", e.shift.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Type", e.type.ToString()));

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

        public static List<Employee> loadEmployes()
        {

            if (!SGBDCon.verifySGBDConnection())
                return null;

            List<Employee> lst = new List<Employee>();

            SqlCommand cmd = new SqlCommand("SELECT * from management.f_get_employees()", cn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Employee e = new Employee();
                e.id = Int32.Parse(reader["id"].ToString());
                e.name = reader["name"].ToString();
                e.name = reader["email"].ToString();
                e.cinema  = Int32.Parse(reader["location"].ToString());
                e.shift = Int32.Parse(reader["eShift"].ToString());
                e.type = Int32.Parse(reader["eType"].ToString());

                lst.Add(e);
            }

            cn.Close();

            return lst;
        }

        public static Employee getEmployee(int employeeId)
        {

            if (!SGBDCon.verifySGBDConnection())
                return null;


            SqlCommand cmd = new SqlCommand("SELECT * from management.f_get_employee(@EmployeeId)", cn);
            cmd.Parameters.Add(new SqlParameter("@EmployeeId", employeeId.ToString()));
            SqlDataReader reader = cmd.ExecuteReader();
            Employee e = new Employee();
            while (reader.Read())
            {
                
                e.id = Int32.Parse(reader["id"].ToString());
                e.name = reader["name"].ToString();
                e.name = reader["email"].ToString();
                e.cinema  = Int32.Parse(reader["location"].ToString());
                e.shift = Int32.Parse(reader["eShift"].ToString());
                e.type = Int32.Parse(reader["eType"].ToString());


            }

            cn.Close();

            return e;
        }

        public static List<Employee> loadSellers()
        {

            if (!SGBDCon.verifySGBDConnection())
                return null;

            List<Employee> lst = new List<Employee>();

            SqlCommand cmd = new SqlCommand("SELECT * from management.f_get_sellers()", cn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Employee e = new Employee();
                e.id = Int32.Parse(reader["id"].ToString());
                e.name = reader["name"].ToString();
                e.email = reader["email"].ToString();
                e.cinema = Int32.Parse(reader["location"].ToString());
                e.shift = Int32.Parse(reader["eShift"].ToString());
                e.type = Int32.Parse(reader["eType"].ToString());

                lst.Add(e);
            }

            cn.Close();

            return lst;
        }

        public static Employee getSeller(int employeeId)
        {

            if (!SGBDCon.verifySGBDConnection())
                return null;


            SqlCommand cmd = new SqlCommand("SELECT * from management.f_get_seller(@EmployeeId)", cn);
            cmd.Parameters.Add(new SqlParameter("@EmployeeId", employeeId.ToString()));
            SqlDataReader reader = cmd.ExecuteReader();
            Employee e = new Employee();
            while (reader.Read())
            {

                e.id = Int32.Parse(reader["id"].ToString());
                e.name = reader["name"].ToString();
                e.email = reader["email"].ToString();
                e.cinema = Int32.Parse(reader["location"].ToString());
                e.shift = Int32.Parse(reader["eShift"].ToString());
                e.type = Int32.Parse(reader["eType"].ToString());


            }

            cn.Close();

            return e;
        }
    }
}
