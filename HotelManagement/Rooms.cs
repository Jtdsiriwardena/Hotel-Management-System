using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagement
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        //insert operation
        private void btnIns_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO rooms(ID,RoomNumber,RoomType,Block,FloorNumber) VALUES (@ID,@RoomNumber,@RoomType,@Block,@FloorNumber)", con);
            cmd.Parameters.AddWithValue("@ID", textBox6.Text);
            cmd.Parameters.AddWithValue("@RoomNumber", textBox1.Text);
            cmd.Parameters.AddWithValue("@RoomType", textBox2.Text);
            cmd.Parameters.AddWithValue("@Block", textBox3.Text);
            cmd.Parameters.AddWithValue("@FloorNumber", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            MessageBox.Show("Record inserted successfully !");
        }


        //display
        private void dis_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM rooms";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }


        //delete
        private void del_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE rooms WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
          

            MessageBox.Show("Record deleted successfully !");
        }


        //search
        private void sea_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM rooms WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", textBox6.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        //update
        private void upd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE rooms SET RoomNumber=@RoomNumber,RoomType=@RoomType,Block=@Block,FloorNumber=@FloorNumber WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", textBox6.Text);
            cmd.Parameters.AddWithValue("@RoomNumber", textBox1.Text);
            cmd.Parameters.AddWithValue("@RoomType", textBox2.Text);
            cmd.Parameters.AddWithValue("@Block", textBox3.Text);
            cmd.Parameters.AddWithValue("@FloorNumber", textBox4.Text);
         
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            

            MessageBox.Show("Record updated successfully !");
        }
    }
}
