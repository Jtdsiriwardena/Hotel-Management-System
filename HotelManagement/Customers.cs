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


namespace HotelManagement
{
    public partial class Customers : Form
    {

        
        public Customers()
        {
            InitializeComponent();
        }

        //insert operation
        private void btnIns_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO customers(ID,firstName,lastName,contactNo,country,IDproof) VALUES (@ID,@firstName,@lastName,@contactNo,@country,@IDproof)", con);
            cmd.Parameters.AddWithValue("@ID", textBox6.Text);
            cmd.Parameters.AddWithValue("@firstName", textBox1.Text);
            cmd.Parameters.AddWithValue("@lastName", textBox2.Text);
            cmd.Parameters.AddWithValue("@contactNo", textBox3.Text);
            cmd.Parameters.AddWithValue("@country", textBox4.Text);
            cmd.Parameters.AddWithValue("@IDproof", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            MessageBox.Show("Record inserted successfully !");
        }


        //delete operation
        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE customers WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            MessageBox.Show("Record deleted successfully !");

        }


        //update operation
        private void btnUpd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE customers SET firstName=@firstName,lastName=@lastName,contactNo=@contactNo,country=@country,IDproof=@IDproof WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", textBox6.Text);
            cmd.Parameters.AddWithValue("@firstName", textBox1.Text);
            cmd.Parameters.AddWithValue("@lastName", textBox2.Text);
            cmd.Parameters.AddWithValue("@contactNo", textBox3.Text);
            cmd.Parameters.AddWithValue("@country", textBox4.Text);
            cmd.Parameters.AddWithValue("@IDproof", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            MessageBox.Show("Record updated successfully !");
        }

        //search operation

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM customers WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", textBox6.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        //display operation
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM customers";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
