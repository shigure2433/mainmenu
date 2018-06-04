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

namespace mainmenu
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Username or password cannot be blank.");
            }
            else
            if (textBox1.Text == "1" || textBox2.Text == "1")
            {
                this.Hide();
                main ma = new main();
                ma.Show();
            }
            else 
            //if (textBox1.Text=="admin" && textBox2.Text=="admin")
            //{
            //    this.Hide();
            //    main ma = new main();
            //    ma.Show();
            //}
            //else
            {
                MessageBox.Show("Please check your username or password.");
            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
