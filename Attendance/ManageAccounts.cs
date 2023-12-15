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
        public MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user=root;database=attendance;password=");
        MySqlCommand checkUname = new MySqlCommand();
        MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        string adminName = LoginForm.Session.loggedInName;

        public ManageAccounts()
        {
            InitializeComponent();
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
                    string register = $"INSERT INTO users (email, nama, pangkat, password) VALUES ('{email}', '{nama}', '{pangkat}', '{password}')";
                    cmd = new MySqlCommand(register, conn);
                    cmd.ExecuteNonQuery();
                    warning.Text = "User ditambahkan!";
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
