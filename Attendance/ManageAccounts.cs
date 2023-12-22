using Attendance.Class;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Attendance
{
    public partial class ManageAccounts : Form
    {
        private Koneksi koneksi;
        MySqlConnection conn;

        MySqlCommand checkUname = new MySqlCommand();
        MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        string adminName = LoginForm.Session.loggedInName;

        public ManageAccounts()
        {
            InitializeComponent();

            koneksi = new Koneksi();
            conn = koneksi.conn;
        }

        public void updateTable()
        {
            conn.Open();
            string query = $"SELECT * FROM users WHERE nama != '{adminName}'";
            cmd = new MySqlCommand(query, conn);

            adapter = new MySqlDataAdapter(cmd);
            dataTable = new DataTable();

            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            conn.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = EmailBox.Text.ToString();
            string nama = NamaBox.Text.ToString();
            string pangkat = PangkatBox.Text.ToString();
            string event_ = comboBox1.Text;
            string password = PasswordBox.Text.ToString();

            if (email != "" && nama != "" && pangkat != "" && password != "")
            {
                conn.Open();
                string check = $"SELECT COUNT(*) FROM users WHERE email = '{email}'";
                checkUname = new MySqlCommand(check, conn);
                int userCount = Convert.ToInt32(checkUname.ExecuteScalar());

                if (userCount > 0)
                {
                    warning.Text = "Email ini sudah terdaftar!";
                }
                else
                {
                    string register = $"INSERT INTO users (email, nama, pangkat, assigned_event, password) VALUES ('{email}', '{nama}', '{pangkat}', '{event_}', '{password}')";
                    cmd = new MySqlCommand(register, conn);
                    cmd.ExecuteNonQuery();
                    warning.Text = "User ditambahkan!";

                    EmailBox.Clear();
                    NamaBox.Clear();
                    PangkatBox.Clear();
                    PasswordBox.Clear();
                }
                conn.Close();

                updateTable();
            }
            else
            {
                warning.Text = "Data wajib diisi!";
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            updateTable();

            comboBox1.Items.Clear();

            conn.Open();

            string query = "SELECT * FROM events";
            cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(1));
            }
            conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminWindow adminWindowInstance = new AdminWindow();
            adminWindowInstance.Show();

            this.Close();
        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            string id = IDBoxDel.Text.ToString();

            conn.Open();
            string delAcc = $"DELETE FROM users WHERE id = {id}";
            cmd = new MySqlCommand(delAcc, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            updateTable();
        }
    }
}
