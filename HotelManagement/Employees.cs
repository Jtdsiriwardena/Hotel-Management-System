using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagement
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        //insert
        private void btnIns_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-MUJC7ME1\\SQLEXPRESS01;Initial Catalog=hotelMangement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO employees(ID,firstName,lastName,department,contactNo) VALUES (@ID,@firstName,@lastName,@department,@contactNo)", con);
            cmd.Parameters.AddWithValue("@ID", textBox6.Text);
            cmd.Parameters.AddWithValue("@firstName", textBox1.Text);
            cmd.Parameters.AddWithValue("@lastName", textBox2.Text);
            cmd.Parameters.AddWithValue("@department", textBox3.Text);
            cmd.Parameters.AddWithValue("@contactNo", textBox4.Text);

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
            cmd.CommandText = "SELECT * FROM employees";
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

            SqlCommand cmd = new SqlCommand("DELETE employees WHERE ID=@ID", con);
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

            SqlCommand cmd = new SqlCommand("SELECT * FROM employees WHERE ID=@ID", con);
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

            SqlCommand cmd = new SqlCommand("UPDATE employees SET firstName=@firstName,lastName=@lastName,department=@department,contactNo=@contactNo WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", textBox6.Text);
            cmd.Parameters.AddWithValue("@firstName", textBox1.Text);
            cmd.Parameters.AddWithValue("@lastName", textBox2.Text);
            cmd.Parameters.AddWithValue("@department", textBox3.Text);
            cmd.Parameters.AddWithValue("@contactNo", textBox4.Text);
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
