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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-APHGB9B;Initial Catalog=cinemamanagement;Integrated Security=True;MultipleActiveResultSets=true");

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Movies_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Movies.Text != "")
            {
                TicketCategory.Enabled = true;
            }

        }

        private void TicketCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "truncate table runtime;";
            SqlCommand cdm = new SqlCommand(query, con);
            cdm.ExecuteReader();


            DataRow dr;
            int mov = Convert.ToInt32(Movies.SelectedValue);
            int tckt = Convert.ToInt32(TicketCategory.SelectedValue);
            Movietiming movietiming = new Movietiming(mov, tckt);
            movietiming.gettiming();

            SqlCommand cmd = new SqlCommand("select time_ from runtime", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            // dr.ItemArray = new object[] { 0, "--Select Movie--" };
            dt.Rows.InsertAt(dr, 0);

            Timing.ValueMember = "id";

            Timing.DisplayMember = "time_";
            Timing.DataSource = dt;

            con.Close();

            //   Timing.Items.Add( movietiming.gettiming());
            if (TicketCategory.Text != "")
            {
                Timing.Enabled = true;
            }
        }

        private void Timing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Timing.Text != "")
            {
                int movie = Convert.ToInt32(Movies.SelectedValue);
                int ticket = Convert.ToInt32(TicketCategory.SelectedValue);

                Hall hall = new Hall(movie,TimeSpan.Parse( Timing.Text), ticket);

                Availableseats.Text = Convert.ToString(hall.getavailableseats());
                Seats.Enabled = true;
            }
        }

        private void Seats_TextChanged(object sender, EventArgs e)
        {if(Seats.Text!="")
            if (int.Parse(Seats.Text) > int.Parse(Availableseats.Text))
            {
                MessageBox.Show("Sorry, please enter seats within the available seats");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cinemamanagementDataSet.ticketcategory' table. You can move, or remove it, as needed.
            this.ticketcategoryTableAdapter.Fill(this.cinemamanagementDataSet.ticketcategory);
            // TODO: This line of code loads data into the 'cinemamanagementDataSet.moviecategory' table. You can move, or remove it, as needed.
            this.moviecategoryTableAdapter.Fill(this.cinemamanagementDataSet.moviecategory);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.moviecategoryTableAdapter.FillBy(this.cinemamanagementDataSet.moviecategory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketcategoryTableAdapter.FillBy(this.cinemamanagementDataSet.ticketcategory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            Customer vis = new Customer(FName.Text, LName.Text, Phone.Text, Email.Text,Movies.Text, TicketCategory.Text, TimeSpan.Parse(Timing.Text), Convert.ToInt32(Seats.Text));
            vis.enterCustomer();
            int seat = Convert.ToInt32(Seats.Text);
            int mov = Convert.ToInt32(Movies.SelectedValue);
            int tckt = Convert.ToInt32(TicketCategory.SelectedValue);
            Hall hall = new Hall(mov,TimeSpan.Parse( Timing.Text), tckt, seat);
            hall.setavailableseats();
            hall.bookedseats();
            string query1 = "truncate table runtime";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.ExecuteReader();
            this.Hide();
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 F6 = new Form6();
            F6.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FName.Clear();
            LName.Clear();
            Seats.Clear();
            Availableseats.Clear();
            Email.Clear();
            Movies.SelectedValue = 0;
            TicketCategory.SelectedValue = 0;
            Timing.SelectedValue = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
