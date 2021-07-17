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
using static CMS.Addmovies;

namespace CMS
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-APHGB9B;Initial Catalog=cinemamanagement;Integrated Security=True;MultipleActiveResultSets=true");

        public Form4()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                hall_silver.Visible = true;
                silver_hall.Visible = true;
                silvertime1.Visible = true;
                silvertime2.Visible = true;
                silver1time.Visible = true;
                silver2time.Visible = true;
              
               
            }
            else
            {
                hall_silver.Visible = false;
                silver_hall.Visible = false;
                silvertime1.Visible = false;
                silvertime2.Visible = false;
                silver1time.Visible = false;
                silver2time.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
               
                    goldtime1.Visible = true;
                    goldtime2.Visible = true;
                    gold1time.Visible = true;
                    gold2time.Visible = true;
                    hall_gold.Visible = true;
                    gold_hall.Visible = true;
            }
            //if (checkBox2.Checked = false)
            else
            {
                hall_gold.Visible = false;
                gold_hall.Visible = false;
                goldtime1.Visible = false;
                goldtime2.Visible = false;
                gold1time.Visible = false;
                gold2time.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked )
            {
                hall_platinum.Visible = true;
                platinum_hall.Visible = true;
                platinumtime1.Visible = true;
                platinumtime2.Visible = true;
                platinum1time.Visible = true;
                platinum2time.Visible = true;
            }
            //if (checkBox3.Checked = false)
            else
            {
                hall_platinum.Visible = false;
                platinum_hall.Visible = false;
                platinumtime1.Visible = false;
                platinumtime2.Visible = false;
                platinum1time.Visible = false;
                platinum2time.Visible = false;
            }
        }

        private void silver_hall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (silver_hall.Text != "")
            {
               
                con.Open();
                string query = "truncate table runtime;";
                SqlCommand cdm = new SqlCommand(query, con);
                cdm.ExecuteReader();


                DataRow dr;

                Silver add = new Silver();
                add.showavailabletime(silver_hall.Text);

                SqlCommand cmd = new SqlCommand("select * from runtime", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dr = dt.NewRow();
                // dr.ItemArray = new object[] { 0, "--Select Movie--" };
                dt.Rows.InsertAt(dr, 0);

                silvertime1.ValueMember = "id";

                silvertime1.DisplayMember = "availabletime";
                silvertime1.DataSource = dt;

                con.Close();


            }
        }

        private void silvertime1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (silvertime1.Text != "")
            {
                silvertime2.Enabled = true;
                int i = Convert.ToInt32(silvertime1.SelectedValue);
                con.Open();
                string query = "delete from runtime where id = '" + i + "';";
                SqlCommand cdm = new SqlCommand(query, con);
                cdm.ExecuteReader();


                DataRow dr;

                //Addmovies add = new Addmovies();
                //add.showavailabletime(silver.Text);

                SqlCommand cmd = new SqlCommand("select * from runtime", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dr = dt.NewRow();
                dt.Rows.InsertAt(dr, 0);

                silvertime2.ValueMember = "id";

                silvertime2.DisplayMember = "availabletime";
                silvertime2.DataSource = dt;

                con.Close();


            }
        }

        private void gold_hall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gold_hall.Text != "")
            {
               
                con.Open();
                string query = "truncate table runtime;";
                SqlCommand cdm = new SqlCommand(query, con);
                cdm.ExecuteReader();


                DataRow dr;

                Gold add = new Gold();
                add.showavailabletime(gold_hall.Text);

                SqlCommand cmd = new SqlCommand("select * from runtime", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dr = dt.NewRow();
                // dr.ItemArray = new object[] { 0, "--Select Movie--" };
                dt.Rows.InsertAt(dr, 0);

                goldtime1.ValueMember = "id";

                goldtime1.DisplayMember = "availabletime";
                goldtime1.DataSource = dt;

                con.Close();


            }
        }

        private void goldtime1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (goldtime1.Text != "")
            {
                goldtime2.Enabled = true;
                int i = Convert.ToInt32(goldtime1.SelectedValue);
                //int id = Convert.ToInt32(silvertime1.SelectedValue.ToString());
                con.Open();
                string query = "delete from runtime where id = '" + i + "';";
                SqlCommand cdm = new SqlCommand(query, con);
                cdm.ExecuteReader();


                DataRow dr;

                //Addmovies add = new Addmovies();
                //add.showavailabletime(silver.Text);

                SqlCommand cmd = new SqlCommand("select * from runtime", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dr = dt.NewRow();
                // dr.ItemArray = new object[] { 0, "--Select Movie--" };
                dt.Rows.InsertAt(dr, 0);

                goldtime2.ValueMember = "id";

                goldtime2.DisplayMember = "availabletime";
                goldtime2.DataSource = dt;

                con.Close();


            }
        }

        private void platinum_hall_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (platinum_hall.Text != "")
            {
               
                con.Open();
                string query = "truncate table runtime;";
                SqlCommand cdm = new SqlCommand(query, con);
                cdm.ExecuteReader();


                DataRow dr;

                Platinum add = new Platinum();
                add.showavailabletime(platinum_hall.Text);

                SqlCommand cmd = new SqlCommand("select * from runtime", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dr = dt.NewRow();
                // dr.ItemArray = new object[] { 0, "--Select Movie--" };
                dt.Rows.InsertAt(dr, 0);

                platinumtime1.ValueMember = "id";

                platinumtime1.DisplayMember = "availabletime";
                platinumtime1.DataSource = dt;

                con.Close();


            }
        }

        private void platinumtime1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (platinumtime1.Text != "")
            {
                platinumtime2.Enabled = true;
                int i = Convert.ToInt32(platinumtime1.SelectedValue);
                //int id = Convert.ToInt32(silvertime1.SelectedValue.ToString());
                con.Open();
                string query = "delete from runtime where id = '" + i + "';";
                SqlCommand cdm = new SqlCommand(query, con);
                cdm.ExecuteReader();


                DataRow dr;

                //Addmovies add = new Addmovies();
                //add.showavailabletime(silver.Text);

                SqlCommand cmd = new SqlCommand("select * from runtime", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dr = dt.NewRow();
                // dr.ItemArray = new object[] { 0, "--Select Movie--" };
                dt.Rows.InsertAt(dr, 0);

                platinumtime2.ValueMember = "id";

                platinumtime2.DisplayMember = "availabletime";
                platinumtime2.DataSource = dt;

                con.Close();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(id.Text);
            Movies movies = new Movies(Id, Name.Text);
            movies.addmovie();
            con.Open();
            if (checkBox1.Checked)
            {
                int hall = int.Parse(silver_hall.Text);
                Silver addmovie = new Silver(Id, Name.Text, checkBox1.Text, hall);


                TimeSpan time = TimeSpan.Parse(silvertime1.Text);
                addmovie.updatehall(time);
                string query = "delete from availabletime where hall_id='" + silver_hall.Text + "' and time_ ='" + time + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteReader();

                if (silvertime2.Text != "")
                {
                    time = TimeSpan.Parse(silvertime2.Text);
                    addmovie.updatehall(time);
                    string query0 = "delete from availabletime where hall_id='" + silver_hall.Text + "' and time_ ='" + time + "';";
                    SqlCommand cmd0 = new SqlCommand(query0, con);
                    cmd0.ExecuteReader();
                }
                
                
            }
            if(checkBox2.Checked)
            {
                int hall = int.Parse(gold_hall.Text);
                Gold addmovie = new Gold(Id, Name.Text,checkBox2.Text, hall);

                TimeSpan time = TimeSpan.Parse(goldtime1.Text);
                addmovie.updatehall(time);
                string query = "delete from availabletime where hall_id='" + gold_hall.Text + "' and time_ ='" + time + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteReader();

                if (goldtime2.Text != "")
                {
                    time = TimeSpan.Parse(goldtime2.Text);
                    addmovie.updatehall(time);
                    string query0 = "delete from availabletime where hall_id='" + gold_hall.Text + "' and time_ ='" + time + "';";
                    SqlCommand cmd0 = new SqlCommand(query0, con);
                    cmd0.ExecuteReader();
                }
                
               
                
            }
            if(checkBox3.Checked)
            {
                int hall = int.Parse(platinum_hall.Text);
                Platinum addmovie = new Platinum(Id, Name.Text, checkBox3.Text, hall);

                TimeSpan time = TimeSpan.Parse(platinumtime1.Text);
                addmovie.updatehall(time);
                string query = "delete from availabletime where hall_id='" + platinum_hall.Text + "' and time_ ='" + time + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteReader();

                if (platinumtime2.Text != "")
                {
                    time = TimeSpan.Parse(platinumtime2.Text);
                    addmovie.updatehall(time);
                    string query0 = "delete from availabletime where hall_id='" + platinum_hall.Text + "' and time_ ='" + time + "';";
                    SqlCommand cmd0 = new SqlCommand(query0, con);
                    cmd0.ExecuteReader();
                }
               
            }
            
            string query1 = "truncate table runtime";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.ExecuteReader();
            con.Close();
            MessageBox.Show("Done");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cinemamanagementDataSet.moviecategory' table. You can move, or remove it, as needed.
            this.moviecategoryTableAdapter.Fill(this.cinemamanagementDataSet.moviecategory);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Movies movies = new Movies();
            movies.removemovie(int.Parse(remove.SelectedValue.ToString()));
            MessageBox.Show("Done");
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.moviecategoryTableAdapter.FillBy1(this.cinemamanagementDataSet.moviecategory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            id.Clear();
            Name.Clear();
            remove.SelectedValue = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}

    
