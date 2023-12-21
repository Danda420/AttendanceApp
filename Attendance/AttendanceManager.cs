using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attendance
{
    public partial class AttendanceManager : Form
    {
        public MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user=root;database=attendance;password=");
        MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        public AttendanceManager()
        {
            InitializeComponent();
        }

        private void updateComboBox()
        {
            cBoxDisplay.Items.Clear();
            cbAddAtt.Items.Clear();

            conn.Open();

            string query = "SELECT * FROM events";
            cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                cBoxDisplay.Items.Add(reader.GetString(1));
                cbAddAtt.Items.Add(reader.GetString(1));
            }
            conn.Close();
            
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

        public void updateEventTable()
        {
            conn.Open();
            string query = $"SELECT * FROM events";
            cmd = new MySqlCommand(query, conn);

            adapter = new MySqlDataAdapter(cmd);
            dataTable = new DataTable();

            adapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;

            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            conn.Close();
        }

        public void updateTableWithEvent(string event_)
        {
            conn.Open();
            string query = $"SELECT * FROM attendance WHERE event = '{event_}'";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string status = null;

            if (rbHadirAdd.Checked)
            {
                status = "Hadir";
            }
            else if (rbIzinAdd.Checked)
            {
                status = "Izin";
            }
            else if (rbAbsentAdd.Checked)
            {
                status = "Absent";
            }
            else if (rbTelatAdd.Checked)
            {
                status = "Telat";
            }

            string nama = addAttBox.Text.ToString();

            string event_ = cbAddAtt.Text;

            conn.Open();
            string absen = $"INSERT INTO attendance (nama, event, attendance) VALUES ('{nama}', '{event_}', '{status}')";
            cmd = new MySqlCommand(absen, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            addAttBox.Clear();

            updateTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string status = null;

            if (rbHadirEdit.Checked)
            {
                status = "Hadir";
            }
            else if (rbIzinEdit.Checked)
            {
                status = "Izin";
            }
            else if (rbAbsentEdit.Checked)
            {
                status = "Absent";
            }
            else if (rbTelatEdit.Checked)
            {
                status = "Telat";
            }

            string id = IDBoxEdit.Text.ToString();

            conn.Open();
            string editAbsen = $"UPDATE attendance SET attendance = '{status}' WHERE id = {id}";
            cmd = new MySqlCommand(editAbsen, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            IDBoxEdit.Clear();

            updateTable();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = IDBoxDel.Text.ToString();

            if (id != "")
            {
                conn.Open();
                string delAbsen = $"DELETE FROM attendance WHERE id = {id}";
                cmd = new MySqlCommand(delAbsen, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                IDBoxDel.Clear();

                updateTable();
            }
        }

        private void btnEventAdd_Click(object sender, EventArgs e)
        {
            string event_ = eventAddBox.Text.ToString();
            string location = eventLocBox.Text.ToString();
            string date = dateTimePicker1.Value.ToString("yy-MM-dd");

            conn.Open();
            string addEvent = $"INSERT INTO events (event, location, date) VALUES ('{event_}', '{location}', '{date}')";
            cmd = new MySqlCommand(addEvent, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            eventAddBox.Clear();
            eventLocBox.Clear();

            updateComboBox();
            updateEventTable();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = dataGridView1;
            Type excelType = Type.GetTypeFromProgID("Excel.Application");

            if (excelType != null)
            {
                dynamic excel = Activator.CreateInstance(excelType);
                excel.Visible = true;
                dynamic workbook = excel.Workbooks.Add();
                dynamic sheet = workbook.ActiveSheet;

                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    sheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        dynamic cellValue = dataGridView.Rows[i].Cells[j].Value;
                        sheet.Cells[i + 2, j + 1].Value = cellValue?.ToString();
                    }
                }
                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    sheet.Columns[i].AutoFit();
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string event_ = cBoxDisplay.Text;
            updateTableWithEvent(event_);
        }

        private void AttendanceManager_Load(object sender, EventArgs e)
        {
            updateComboBox();
            updateTable();
            updateEventTable();
        }

        private void btnDelEvent_Click(object sender, EventArgs e)
        {
            string id = eventIDBox.Text.ToString();

            if (id != "")
            {
                conn.Open();
                string delEvent = $"DELETE FROM events WHERE id = {id}";
                cmd = new MySqlCommand(delEvent, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                eventIDBox.Clear();

                updateEventTable();
                updateComboBox();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminWindow adminWindowInstance = new AdminWindow();
            adminWindowInstance.Show();

            this.Close();
        }

        private void rbTelatEdit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cbAddAtt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbAbsentAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbIzinAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbHadirAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addAttBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void IDBoxDel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbAbsentEdit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbIzinEdit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbHadirEdit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IDBoxEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbTelatAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
