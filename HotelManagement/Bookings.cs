using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagement
{
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        //insert
        private void ins_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO bookings(ID,CustomerName,RoomNumber,CheckInDate,CheckOutDate) VALUES (@ID,@CustomerName,@RoomNumber,@CheckInDate,@CheckOutDate)", con);
            cmd.Parameters.AddWithValue("@ID", textBox6.Text);
            cmd.Parameters.AddWithValue("@CustomerName", textBox2.Text);
            cmd.Parameters.AddWithValue("@RoomNumber", textBox1.Text);
            cmd.Parameters.AddWithValue("@CheckInDate", textBox4.Text);
            cmd.Parameters.AddWithValue("@CheckOutDate", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";



            MessageBox.Show("Record inserted successfully !");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        //display
        private void dis_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM bookings";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }


        //update
        private void upd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE bookings SET CustomerName=@CustomerName,RoomNumber=@RoomNumber,CheckInDate=@CheckInDate,CheckOutDate=@CheckOutDate WHERE ID=@ID", con);

            cmd.Parameters.AddWithValue("@ID", textBox6.Text);
            cmd.Parameters.AddWithValue("@CustomerName", textBox2.Text);
            cmd.Parameters.AddWithValue("@RoomNumber", textBox1.Text);
            cmd.Parameters.AddWithValue("@CheckInDate", textBox4.Text);
            cmd.Parameters.AddWithValue("@CheckOutDate", textBox3.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";


            MessageBox.Show("Record updated successfully !");
        }


        //delete
        private void del_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE bookings WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";


            MessageBox.Show("Record deleted successfully !");
        }


        //search
        private void sea_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM bookings WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", textBox6.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
