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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pc\OneDrive\Documents\Car_Db.mdf;Integrated Security=True;Connect Timeout=30");

        DataTable dt;
        SqlDataAdapter adpt;
        public Form4()
        {
            InitializeComponent();
            displayvalue();
        }
        public void displayvalue()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from Registration", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Registration values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox8.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            MessageBox.Show("Record Saved Successfuly");
        }
        private void DisplayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Registration";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "update Registration set AutoType='" + textBox2.Text + "' where DriverType='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            DisplayData();
            MessageBox.Show("Record Updated Successfuly");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "delete from Registration where DriverType='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            MessageBox.Show("Record Deleted Successfuly");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            searchData(textBox7.Text);
        }


        public void searchData(string search)
        {
            con.Close();
            string query = "select * from Registration where DriverType like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
