using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance
{
    public partial class RegisterWindow : Form
    {
        public MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user=root;database=attendance;password=");
        MySqlCommand checkUname = new MySqlCommand();
        MySqlCommand cmd = new MySqlCommand();

        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text.ToString();
            string nama = NamaBox.Text.ToString();
            string password = PasswordBox.Text.ToString();
            string conPassword = ConfirmPassBox.Text.ToString();
            if (username != "" && nama != "" && password != "" && conPassword != "")
            {
                if (password == conPassword)
                {
                    conn.Open();
                    string check = $"SELECT COUNT(*) FROM users WHERE username = '{username}'";
                    checkUname = new MySqlCommand(check, conn);
                    int userCount = Convert.ToInt32(checkUname.ExecuteScalar());

                    if (userCount > 0)
                    {
                        warning.Text = "User ini sudah terdaftar!";
                    }
                    else
                    {
                        string register = $"INSERT INTO users (username, nama, password) VALUES ('{username}', '{nama}', '{password}')";
                        cmd = new MySqlCommand(register, conn);
                        cmd.ExecuteNonQuery();
                        warning.Text = "Selamat anda sudah terdaftar!";
                    }

                    conn.Close();
                }
                else
                {
                    warning.Text = "Password tidak sama!";
                }
            }
            else
            {
                warning.Text = "Data wajib diisi!";
            }
        }

        private void passCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (passCheckbox.Checked)
            {
                PasswordBox.PasswordChar = '\0';
                ConfirmPassBox.PasswordChar = '\0';
            }
            else
            {
                PasswordBox.PasswordChar = '*';
                ConfirmPassBox.PasswordChar = '*';
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
            ConfirmPassBox.PasswordChar = '*';
        }
    }
}
