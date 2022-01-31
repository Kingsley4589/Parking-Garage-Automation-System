using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;  
namespace zubeer
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pc\OneDrive\Documents\Car_Db.mdf;Integrated Security=True;Connect Timeout=30");

        DataTable dt;
        SqlDataAdapter adpt;
        public Form3()
        {
            InitializeComponent();
            displayvalue();
        }
        public void displayvalue()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from DriverType", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into DriverType values('" + textBox1.Text + "','" + textBox2.Text + "')";
            _ = cmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            MessageBox.Show("Record Saved Successfuly");
        }
        private void DisplayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DriverType";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "delete from DriverType where AutoType='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            MessageBox.Show("Record Deleted Successfuly");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "update DriverType set Description='" + textBox2.Text + "' where AutoType='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            DisplayData();
            MessageBox.Show("Record Updated Successfuly");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            {
                searchData(textBox3.Text);
            }
        }
        public void searchData(string search)
        {
            con.Close();
            string query = "select * from DriverType where AutoType like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
     
}
