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
    public partial class Form2 : Form
    { 
         SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pc\OneDrive\Documents\Car_Db.mdf;Integrated Security=True;Connect Timeout=30");
            
        DataTable dt;
        SqlDataAdapter adpt;
           
        public Form2()  
        {  
            InitializeComponent();  
         displayvalue();
        }
        public void displayvalue()
        {
        con.Open();
            adpt= new SqlDataAdapter("select * from AutoType", con);
            dt=new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource= dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
          
            cmd.CommandText= "insert into AutoType values('"+textBox4.Text+"','"+textBox1.Text+"','"+textBox2.Text+"')";
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
            cmd.CommandText = "select * from AutoType";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            
        }
        private void ClearData()
        {
            
        }  
      
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "update AutoType set CarType='"+textBox1.Text+"' where CarTableID='"+textBox4.Text+"'";
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

            cmd.CommandText = "delete from AutoType where CarTableID='" + textBox4.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            MessageBox.Show("Record Deleted Successfuly");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
          
        }

        private void Form2_Load(object sender, EventArgs e)
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
            string query = "select * from AutoType where CarTableID like '%" + search + "%'";
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
            textBox4.Text = "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

      
}
