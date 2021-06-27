using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagment.Common;
using CinemaManagment.Entities;
using CinemaManagment.sgbd;

namespace CinemaManagment
{
    public partial class Login : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

        public Login()
        {
            InitializeComponent();
        }

        public static int employeeId = -1;

        public int getEmployeeId()
        {
            return employeeId;
        }

        public int getCinema()
        {
            Login login = new Login();
            var employeeID = login.getEmployeeId();

            String checkCinema = "SELECT location FROM Management.Employee WHERE id=" + employeeID;

            using (var cmd = new SqlCommand(checkCinema, cn))
            {
                cn.Open();

                var reader = cmd.ExecuteReader();
                reader.Read();
                int location = reader.GetInt32(0);

                cn.Close();
                return location;
            }
        }

        private void login()
        {
            if (!SGBDCon.verifySGBDConnection())
                return;

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * " +
                                                        "FROM Management.Employee " +
                                                        "WHERE Management.Employee.id=@EmployeeId", cn);
            SqlCommand cmd =
                new SqlCommand("SELECT * FROM Management.Employee WHERE Management.Employee.id=@EmployeeId", cn);
            cmd.Parameters.Add(new SqlParameter("@EmployeeId", numericUpDownEmployee.Value));

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            List<Employee> eLst = dt.AsEnumerable().Select(row =>
                new Employee()
                {
                    id = row.Field<int>("id"),
                    name = row.Field<string>("name"),
                    email = row.Field<string>("email"),
                    cinema = row.Field<int>("location"),
                    shift = row.Field<int>("eShift"),
                    type = row.Field<int>("eType"),


                }).ToList();
            cn.Close();
            
            if (eLst.Count == 1)
            {
                 
                User.getInstance().e = eLst[0];
                employeeId = eLst[0].id; // backwards compatibilty
                


                int eType = eLst[0].type;
                if (eType == 0 || eType == 1)
                {
                    new MainMenuManager().Show();
                    this.Hide();
                }
                else if (eType == 2)
                {
                    new MainMenuSales().Show();
                    this.Hide();
                }
                else if (eType == 3)
                {
                    new MainMenuCleaner().Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("User doesnt exist!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void roundedButtonLogin_Click(object sender, EventArgs e)
        {
            login();
            /*
            String checkLogin = "SELECT * " +
                "FROM Management.Employee " +
                "JOIN Location.Cinema ON Management.Employee.location=Location.Cinema.id " +
                "WHERE Management.Employee.id=" + numericUpDownEmployee.Value + " " +
                "AND Location.Cinema.name='" + comboBoxCinema.Text + "'";

            SqlDataAdapter sqlData = new SqlDataAdapter(checkLogin, cn);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                employeeId = Convert.ToInt32(numericUpDownEmployee.Value);

                String checkType = "SELECT eType FROM Management.Employee WHERE id=" + numericUpDownEmployee.Value;

                using (var cmd = new SqlCommand(checkType, cn))
                {
                    cn.Open();
                    
                    var reader = cmd.ExecuteReader();
                    reader.Read();
                    int eType = reader.GetInt32(0);

                    if (eType == 0 || eType == 1)
                    {
                        cn.Close();
                        new MainMenuManager().Show();
                        this.Hide();
                    }
                    else if (eType == 2)
                    {
                        cn.Close();
                        new MainMenuSales().Show();
                        this.Hide();
                    }
                    else if (eType == 3)
                    {
                        cn.Close();
                        new MainMenuCleaner().Show();
                        this.Hide();
                    }
                }*/
        }
    

        private void buttonManager_Click(object sender, EventArgs e)
        {
            MainMenuManager mainMenuManager = new MainMenuManager();
            mainMenuManager.Show();
            this.Hide();
        }

        private void buttonSeller_Click(object sender, EventArgs e)
        {
            MainMenuSales mainMenuSales = new MainMenuSales();
            mainMenuSales.Show();
            this.Hide();
        }

        private void buttonCleaner_Click(object sender, EventArgs e)
        {
            MainMenuCleaner mainMenuCleaner = new MainMenuCleaner();
            mainMenuCleaner.Show();
            this.Hide();
        }
    }
}
