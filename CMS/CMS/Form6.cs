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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            dataGridView1.DataSource = cus.showcustomer();
            // TODO: This line of code loads data into the 'cinemamanagementDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.cinemamanagementDataSet1.Customer);
            // TODO: This line of code loads data into the 'cinemamanagementDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.cinemamanagementDataSet.Customer);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            id.Text = dataGridView1.Rows[rowindex].Cells["ID"].Value.ToString();
            Firstname.Text = dataGridView1.Rows[rowindex].Cells["Firstname"].Value.ToString();
            Lastname.Text = dataGridView1.Rows[rowindex].Cells["Lastname"].Value.ToString();
            phone.Text = dataGridView1.Rows[rowindex].Cells["phoneNo"].Value.ToString();
            Email.Text = dataGridView1.Rows[rowindex].Cells["Email"].Value.ToString();
            movie.Text = dataGridView1.Rows[rowindex].Cells["movie"].Value.ToString();
            category.Text = dataGridView1.Rows[rowindex].Cells["category"].Value.ToString();
            timing.Text = dataGridView1.Rows[rowindex].Cells["timing"].Value.ToString();
            hall.Text = dataGridView1.Rows[rowindex].Cells["hall"].Value.ToString();
            cost.Text = dataGridView1.Rows[rowindex].Cells["cost"].Value.ToString();
            seats.Text = dataGridView1.Rows[rowindex].Cells["seats"].Value.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void hall_TextChanged(object sender, EventArgs e)
        {

        }

        private void category_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            Customer cus = new Customer();
            if(text!=null)
            {
                dataGridView1.DataSource = cus.search(text);
            }
            else
            {
                dataGridView1.DataSource = cus.showcustomer();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.update( int.Parse( id.Text), phone.Text, Email.Text);
            MessageBox.Show("Done");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            id.Clear();
            Firstname.Clear();
            Lastname.Clear();
            phone.Clear();
            movie.Clear();
            category.Clear();
            timing.Clear();
            hall.Clear();
            seats.Clear();
            cost.Clear();
            textBox1.Clear();
            Email.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
