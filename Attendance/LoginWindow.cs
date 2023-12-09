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

namespace Attendance
{
    public partial class LoginForm : Form
    {
        public MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user=root;database=attendance;password=");
        private MemberWindow memberWindowInstance;
        private AdminWindow adminWindowInstance;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text.Trim();
            string password = PasswordBox.Text.Trim();

            if (username != "" && password != "")
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (username == "admin")
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
                else
                {
                    UsernameBox.Text = null;
                    PasswordBox.Text = null;
                    warning.Text = "Username atau password salah!";
                }

                conn.Close();
            }
            else
            {
                warning.Text = "Username dan Password harus diisi!";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            var registForm = new RegisterWindow();
            registForm.Show();
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
