using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            Customers cus = new Customers();
            cus.Show();
        }


        private void room_Click(object sender, EventArgs e)
        {
            Rooms rom = new Rooms();
            rom.Show();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bookings bok = new Bookings();
            bok.Show();
        }
    }
}
