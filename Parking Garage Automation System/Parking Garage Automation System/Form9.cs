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
    public partial class Form9 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pc\OneDrive\Documents\Car_Db.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt;
        SqlDataAdapter adpt;
        public Form9()
        {
            InitializeComponent();
            displayvalue();
        }
        public void displayvalue()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from CheckOut", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into CheckOut values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            MessageBox.Show("Record Checked Out Successfuly");
        }
        private void DisplayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CheckOut";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            searchData(textBox3.Text);
        }
        public void searchData(string search)
        {
            con.Close();
            string query = "select * from CheckOut where EnterNo like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

    }
}
