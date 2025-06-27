using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_School
{
    public partial class Farmerdashbord : Form
    {
        public Farmerdashbord()
        {
            InitializeComponent();
            courseControl1.BringToFront();
            scheduleControl1.BringToFront();
            matarialsControl1.BringToFront();
            eventControl1.BringToFront();
            profileControl1.BringToFront();
           
        }

        private void Farmerdashbord_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncourseList_Click(object sender, EventArgs e)
        {
            courseControl1.BringToFront();
        }

        private void btnschedule_Click(object sender, EventArgs e)
        {
            scheduleControl1.BringToFront();
        }

        private void matarialsControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnmatarials_Click(object sender, EventArgs e)
        {
            matarialsControl1.BringToFront();
        }

        private void btnevent_Click(object sender, EventArgs e)
        {
            eventControl1.BringToFront();
        }

        private void eventControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            profileControl1.BringToFront();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }
    }
}
