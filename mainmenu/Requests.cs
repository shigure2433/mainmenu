using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainmenu
{
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            create c = new create();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            create c = new create();
            c.Hide();
            modify m = new modify();
            m.Hide();

            login l = new login();
            l.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[1].Cells[1].Value.ToString();
            //if ((bool)item["ProductStatus"])
            //{
            //    comboBox1.SelectedIndex = 0;
            //}
            //else
            //{
            //    comboBox1.SelectedIndex = 1;
            //}
            //comboBox1.SelectedText = dataGridView1.Rows[0].Cells[2].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            modify m = new modify();
            m.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Console.Write(DateTime.Now.ToString("ddd dd MMM, yyyy"));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Requests_Load(object sender, EventArgs e)
        {

        }
    }
}
