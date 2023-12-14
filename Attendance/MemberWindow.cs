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
    public partial class MemberWindow : Form
    {
        public MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user=root;database=attendance;password=");
        MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        string loggedInEmail = LoginForm.Session.loggedInEmail;
        string loggedInName = LoginForm.Session.loggedInName;

        public MemberWindow()
        {
            InitializeComponent();
        }

        public void updateTable()
        {
            conn.Open();
            string query = $"SELECT * FROM attendance WHERE nama = '{loggedInName}'";
            cmd = new MySqlCommand(query, conn);

            adapter = new MySqlDataAdapter(cmd);
            dataTable = new DataTable();

            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.HeaderText == "id")
                {
                    column.Visible = false;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            conn.Close();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            Email.Text = $"Email : {loggedInEmail}";
            lblNama.Text = $"Nama : {loggedInName}";
            updateTable();
        }

        private void btnAbsen_Click(object sender, EventArgs e)
        {
            string status = null;

            if (rbHadir.Checked)
            {
                status = "Hadir";
            }
            else if (rbIzin.Checked)
            {
                status = "Izin";
            }
            else if (rbAlfa.Checked)
            {
                status = "Alfa";
            }

            DateTime currentDate = DateTime.Now;
            string date = currentDate.ToString("yyyy-MM-dd");

            conn.Open();
            string absen = $"INSERT INTO attendance (nama, date, attendance) VALUES ('{loggedInName}', '{date}', '{status}')";
            cmd = new MySqlCommand(absen, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            updateTable();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm.Session.destroySession();

            LoginForm loginWindowInstance = new LoginForm();
            loginWindowInstance.Show();

            this.Close();
        }
    }
}
