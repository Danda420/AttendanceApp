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
    public partial class OperatorWindow : Form
    {
        string loggedInEmail = LoginForm.Session.loggedInEmail;
        string loggedInName = LoginForm.Session.loggedInName;
        string loggedInEvent = LoginForm.Session.loggedInEvent;

        public OperatorWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void OperatorWindow_Load(object sender, EventArgs e)
        {
            Email.Text = $"Email : {loggedInEmail}";
            Nama.Text = $"Nama : {loggedInName}";
            Event.Text = $"Assigned Event : {loggedInEvent}";
        }
    }
}
