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
using System.Drawing.Printing;
namespace CMS
{
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-APHGB9B;Initial Catalog=cinemamanagement;Integrated Security=True;MultipleActiveResultSets=true");

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT TOP 1 * FROM Customer ORDER BY id DESC";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Name.Text = dt.Rows[0]["Firstname"].ToString();
            Movie.Text = dt.Rows[0]["movie"].ToString();
            Hall.Text = dt.Rows[0]["hall"].ToString();
            Timing.Text = dt.Rows[0]["timing"].ToString();
            Category.Text = dt.Rows[0]["category"].ToString();
            seats.Text = dt.Rows[0]["seats"].ToString();
            cost.Text = dt.Rows[0]["cost"].ToString();
            Ticket tckt = new Ticket(dt.Rows[0]["category"].ToString(), Convert.ToInt32 (dt.Rows[0]["seats"].ToString()));
            totalcost.Text = Convert.ToString( tckt.Bill());
            con.Close();

        }
        void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            int SPACE = 145;
            string title = Application.StartupPath + "\\cinema.jpg";
            string barcode = Application.StartupPath + "\\code128bar.jpg";
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, 5, 5, 420, 550);
            string TType;
            if (Category.Text == "Silver")
            {
                TType = "S";
            }

            else if (Category.Text == "Gold")
            {
                TType = "G";
            }
            else
            {
                TType = "P";
            }



            g.DrawImage(Image.FromFile(title), 7, 7,420,120);
            Font fBody = new Font("Lucida Console", 15, FontStyle.Bold);
            Font fBody1 = new Font("Lucida Console", 15, FontStyle.Regular);
            Font rs = new Font("Stencil", 25, FontStyle.Bold);
            Font fTType = new Font("", 150, FontStyle.Bold);
            SolidBrush sb = new SolidBrush(Color.Black);


            g.DrawString("-------------------------------", fBody1, sb, 10, 120);

            g.DrawString("Date :", fBody, sb, 10, SPACE);
            g.DrawString(DateTime.Now.ToShortDateString(), fBody1, sb, 90, SPACE);

            g.DrawString("Time :", fBody, sb, 10, SPACE + 30);
            g.DrawString(DateTime.Now.ToShortTimeString(), fBody1, sb, 90, SPACE + 30);
            
            g.DrawString("Name:", fBody, sb, 10, SPACE + 60);
            g.DrawString(Name.Text, fBody1, sb, 120, SPACE + 60);

            g.DrawString("Movie:", fBody, sb, 10, SPACE + 90);
            g.DrawString(Movie.Text, fBody1, sb, 100, SPACE + 90);

            g.DrawString("Timing:", fBody, sb, 10, SPACE+120);
            g.DrawString(Timing.Text, fBody1, sb, 153, SPACE + 120);

            g.DrawString("Hall:", fBody, sb, 10, SPACE + 150);
            g.DrawString(Hall.Text, fBody1, sb, 100, SPACE + 150);

            g.DrawString("Cost:", fBody, sb, 10, SPACE + 180);
            g.DrawString(cost.Text, fBody1, sb, 100, SPACE + 180);

            g.DrawString("Seats:", fBody, sb, 10, SPACE + 210);
            g.DrawString(seats.Text, fBody1, sb, 100, SPACE + 210);

            g.DrawString("Total:", fBody, sb, 10, SPACE + 240);
            g.DrawString(totalcost.Text, fBody1, sb, 80, SPACE + 240);

            //g.DrawString("Rs. 8.00", rs, sb, 10, SPACE + 180);

            g.DrawString(TType, fTType, sb, 230, 120);

            g.DrawImage(Image.FromFile(barcode), 10, SPACE + 270);
            g.DrawString("Helpline No.: +91 9999999999", fBody, sb, 10, 530);

        }

        private void button1_Click(object sender, EventArgs e)
        {
             PrintDocument pd = new PrintDocument();
            PaperSize ps = new PaperSize("", 475, 600);

            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            pd.PrintController = new StandardPrintController();
            pd.DefaultPageSettings.Margins.Left = 0;
            pd.DefaultPageSettings.Margins.Right = 0;
            pd.DefaultPageSettings.Margins.Top = 0;
            pd.DefaultPageSettings.Margins.Bottom = 0;

            pd.DefaultPageSettings.PaperSize = ps;
            pd.Print();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();

        }
    }
}
