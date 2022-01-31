using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zubeer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbtnDriverTyoes_Click(object sender, EventArgs e)
        {
            Form2 yu = new Form2();
            yu.Show();
        }

        private void tsbtnCarTypes_Click(object sender, EventArgs e)
        {
            Form3 i = new Form3();
            i.Show();
        }

        private void tsbtnVehicles_Click(object sender, EventArgs e)
        {
            Form5 k = new Form5();
            k.Show();
        }

        private void tsbtnPersonRegistration_Click(object sender, EventArgs e)
        {
            Form4 h = new Form4();
            h.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form6 p = new Form6();
            p.Show();

        }

        private void tsbtnCheckin_Click(object sender, EventArgs e)
        {
            Form7 l = new Form7();
            l.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsbtnChekOut_Click(object sender, EventArgs e)
        {
            Form9 u = new Form9();
            u.Show();

        }

        private void tsbtnHistory_Click(object sender, EventArgs e)
        {
            Form10 ih = new Form10();
            ih.Show();
        }
    }
}
