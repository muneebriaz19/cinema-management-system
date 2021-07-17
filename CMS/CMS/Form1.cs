using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                Admin ad = new Admin(UserName.Text, Password.Text);
                string check = ad.checkid();
                if (check == "yes")
                {
                    this.Hide();
                    Form8 F8 = new Form8();
                    F8.Show();
                }
                else
                {
                    label5.Visible = true;
                }
            }
            else if (radioButton2.Checked)
            {
                User user = new User(UserName.Text, Password.Text);
                string check = user.checkid();
                if (check == "yes")
                {
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else
                {
                    label5.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please select the employee type");
            }

            }
            

        

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserName.Clear();
            Password.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}
