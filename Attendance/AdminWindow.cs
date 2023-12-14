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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Attendance
{
    public partial class AdminWindow : Form
    {
        public MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user=root;database=attendance;password=");
        MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        string loggedInEmail = LoginForm.Session.loggedInEmail;
        string loggedInName = LoginForm.Session.loggedInName;

        public AdminWindow()
        {
            InitializeComponent();
        }

        public void updateTable()
        {
            conn.Open();
            string query = $"SELECT * FROM attendance";
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

        private void AdminWindow_Load(object sender, EventArgs e)
        {
            Email.Text = $"Email : {loggedInEmail}";
            lblNama.Text = $"Nama : {loggedInName}";

            updateTable();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm.Session.destroySession();

            LoginForm loginWindowInstance = new LoginForm();
            loginWindowInstance.Show();

            this.Close();
        }

        private void btnManageAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mngAcc = new ManageAccounts();
            mngAcc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

            string id = IDBox.Text.ToString();

            conn.Open();
            string editAbsen = $"UPDATE attendance SET attendance = '{status}' WHERE id = {id}";
            cmd = new MySqlCommand(editAbsen, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            updateTable();
        }

        private void btnDelAttendance_Click(object sender, EventArgs e)
        {
            string id = IDBoxDel.Text.ToString();

            conn.Open();
            string delAbsen = $"DELETE FROM attendance WHERE id = {id}";
            cmd = new MySqlCommand(delAbsen, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            updateTable();
        }
    }
}
