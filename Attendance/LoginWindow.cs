using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Attendance
{
    public partial class LoginForm : Form
    {
        public MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user=root;database=attendance;password=");
        private MemberWindow memberWindowInstance;
        private AdminWindow adminWindowInstance;

        public class Session
        {
            public static string loggedInEmail { get; private set; }

            public static string loggedInName { get; private set; }

            public static void SetLoggedInUser(string email, string name)
            {
                loggedInEmail = email;
                loggedInName = name;
            }

            public static void destroySession()
            {
                loggedInEmail = null;
            }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = EmailBox.Text.Trim();
            string password = PasswordBox.Text.Trim();

            if (email != "" && password != "")
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE email = @email AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string getNama = "SELECT nama FROM users WHERE email = @email";
                    string getPangkat = "SELECT pangkat FROM users WHERE email = @email";
                    MySqlCommand getNamaCmd = new MySqlCommand(getNama, conn);
                    MySqlCommand getPangkatCmd = new MySqlCommand(getPangkat, conn);
                    getNamaCmd.Parameters.AddWithValue("@email", email);
                    getPangkatCmd.Parameters.AddWithValue("@email", email);

                    reader.Close();

                    using (MySqlDataReader getNamaReader = getNamaCmd.ExecuteReader())
                    {
                        if (getNamaReader.Read())
                        {
                            string nama = getNamaReader["nama"].ToString();
                            Session.SetLoggedInUser(email, nama);
                        }
                    }

                    using (MySqlDataReader getPangkatReader = getPangkatCmd.ExecuteReader())
                    {
                        if (getPangkatReader.Read())
                        {
                            string pangkat = getPangkatReader["pangkat"].ToString();

                            if (pangkat == "admin")
                            {
                                if (adminWindowInstance == null || adminWindowInstance.IsDisposed)
                                {
                                    adminWindowInstance = new AdminWindow();
                                    adminWindowInstance.Show();
                                }
                                else
                                {
                                    adminWindowInstance.BringToFront();
                                }
                                warning.Text = null;
                            }
                            else
                            {
                                if (memberWindowInstance == null || memberWindowInstance.IsDisposed)
                                {
                                    memberWindowInstance = new MemberWindow();
                                    memberWindowInstance.Show();
                                }
                                else
                                {
                                    memberWindowInstance.BringToFront();
                                }
                                warning.Text = null;
                            }
                            this.Hide();
                        }
                    }
                    
                }
                else
                {
                    EmailBox.Text = null;
                    PasswordBox.Text = null;
                    warning.Text = "Email atau password salah!";
                }
                conn.Close();
            }
            else
            {
                warning.Text = "Email dan Password harus diisi!";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
        }

        private void passCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (passCheckbox.Checked)
            {
                PasswordBox.PasswordChar = '\0';
            }
            else
            {
                PasswordBox.PasswordChar = '*';
            }
        }
    }
}
