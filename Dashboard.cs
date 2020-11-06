using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnCustomerRegistration.Left+60;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnAddRoom.Left + 1;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnCheckOut.Left + 7;
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnCustomerDetails.Left + 45;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnEmployee.Left + 12;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
        }
    }
}
