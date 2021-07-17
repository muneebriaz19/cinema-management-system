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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            dataGridView1.DataSource = admin.show(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            Admin admin = new Admin();
            if (text!=null)
            {
                dataGridView1.DataSource = admin.search(text);
            }
            else
            {
                dataGridView1.DataSource = admin.show();
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            id.Text = dataGridView1.Rows[rowindex].Cells["ID"].Value.ToString();
            Firstname.Text = dataGridView1.Rows[rowindex].Cells["Firstname"].Value.ToString();
            Lastname.Text = dataGridView1.Rows[rowindex].Cells["Lastname"].Value.ToString();
            phone.Text = dataGridView1.Rows[rowindex].Cells["phone"].Value.ToString();
            Email.Text = dataGridView1.Rows[rowindex].Cells["Email"].Value.ToString();
            username.Text = dataGridView1.Rows[rowindex].Cells["username"].Value.ToString();
            password.Text = dataGridView1.Rows[rowindex].Cells["pass_word"].Value.ToString();
            gender.Text = dataGridView1.Rows[rowindex].Cells["gender"].Value.ToString();
            employee_type.Text = dataGridView1.Rows[rowindex].Cells["employee_type"].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.add( Firstname.Text, Lastname.Text, phone.Text, Email.Text, username.Text, password.Text, gender.Text, employee_type.Text);
            MessageBox.Show("Done");
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.update(int.Parse(id.Text), Firstname.Text, Lastname.Text, phone.Text, Email.Text, username.Text, password.Text, gender.Text, employee_type.Text);
            MessageBox.Show("Done");
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.remove(int.Parse(id.Text));
            MessageBox.Show("Done");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            id.Clear();
            Firstname.Clear();
            Lastname.Clear();
            phone.Clear();
            Email.Clear();
            username.Clear();
            password.Clear();
            gender.Clear();
            employee_type.Clear();
            textBox1.Clear();

        }

        private void employee_type_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
