using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace code_first
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<human> human1 = new List<human>();
        private void Form1_Load(object sender, EventArgs e)
        {
            db db = new db();
            human huma = new human()
            {name = "mehrshad", family="mehrshad",age=23  };
            db db1 = new db();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db1.humans.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db db1 = new db();

            human human = new human() { name = textBox1.Text,family=textBox2.Text,age =Convert.ToByte(textBox3.Text) };
            db1.humans.Add(human);
            db1.SaveChanges();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db1.humans.ToList();
        }
    }
}
