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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Requests r = new Requests();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have no right to get in.");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have no right to get in.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
