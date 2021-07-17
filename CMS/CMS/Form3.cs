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

namespace CMS
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-APHGB9B;Initial Catalog=cinemamanagement;Integrated Security=True;MultipleActiveResultSets=true");

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string statement = " select phone from employee where username = '" + textBox1.Text + "';";
            SqlCommand cmd = new SqlCommand(statement, con);
            if (cmd.ExecuteScalar().ToString() ==Phone.Text)
            {

                
                if (textBox2.Text == textBox3.Text)
                {
                    if (radioButton1.Checked)
                    {
                        Admin ad = new Admin(textBox1.Text, textBox3.Text);
                        ad.resetid((Phone.Text));
                        MessageBox.Show("Password updated");
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.Show();
                    }
                    if (radioButton2.Checked)
                    {
                        User user = new User(textBox1.Text, textBox3.Text);
                        user.resetid(Phone.Text);
                        MessageBox.Show("Password updated");
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Your password mismatched");
                }
            }
            else
            {
                MessageBox.Show("Please enter the correct username or phone");
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox1.Text != null)
            //{
            //    textBox2.Visible = true;
            //    textBox3.Visible = true;
            //    label2.Visible = true;
            //    label3.Visible = true;
            //}
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Phone.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
