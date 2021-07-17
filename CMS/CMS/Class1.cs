using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CMS
{
    public abstract class Connection
    {
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-APHGB9B;Initial Catalog=cinemamanagement;Integrated Security=True;MultipleActiveResultSets=true");

    }
    public abstract class Person : Connection
    {
        protected string Firstname;
        protected string Lastname;
        protected string phone;
        protected string Email;
        protected string Gender;
    }
    public abstract class Employee : Person
    {
        protected string username;
        protected string password;
        protected string employee;
        public string checkid()
        {
            string avaibility = "";
            con.Open();
            string selectquery = "select * from employee where username = '" + username + "' and pass_word= '" + password + "' and employee_type = '"+employee+"' ";
            SqlCommand cmd1 = new SqlCommand(selectquery, con);
            if (cmd1.ExecuteScalar() != null)
            {
                avaibility = "yes";

            }
            con.Close();
            return avaibility;
        }
        public void resetid(string phone)
        {
            con.Open();

            string query = "update employee set pass_word = '" + password + "' where username = '" + username + "' and Phone = '" + phone + "'and employee_type = '"+employee+"';";
            SqlCommand cmd1 = new SqlCommand(query, con);
            cmd1.ExecuteReader();
            con.Close();
        }
    }
    public class Admin : Employee
    {
        public Admin(string username, string password)
        {
            base.username = username;
            base.password = password;
            employee = "admin";
        }
        public Admin() { }
        public Admin(string Fname, string Lname, string username, string password, string phone, string email, string gender)
        {
            Firstname = Fname;
            Lastname = Lname;
            base.username = username;
            base.password = password;
            base.phone = phone;
            Email = email;
            Gender = gender;

        }
        public void update(string query)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand(query, con);
            cmd1.ExecuteReader();
            con.Close();
        }
        public DataTable show()
        {
            con.Open();string user = "worker";
            string query = " select id,firstname,lastname,phone,Email,username,pass_word,Gender,employee_type from employee where Employee_type ='"+user+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);      //this statement fills tha data table with the query written above
            con.Close();
            return dtbl;
        }
        public DataTable search(string text)
        {
            con.Open(); string user = "worker";
            string query = "select id,firstname,lastname,phone,Email,username,pass_word,Gender,employee_type from employee where (id like '%" + text + "%' or firstname like '%" + text + "%' or lastname like '%" + text + "%' or phone like '%" + text + "%' or Email like '%" + text + "%' or username like '%" + text + "%' or pass_word like'%" + text + "%' or gender like '%" + text + "%' or employee_type like '%" + text + "%') and employee_type = '"+user+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }
        public void update(int id,string fname,string lname,string phone,string email,string username,string password,string gender, string employee_type)
        {
            con.Open();
            string query = "update employee set firstname ='" + fname + "', lastname = '" + lname + "' , phone = '" + phone + "' , email = '" + email + "', username ='" + username + "',pass_word = '" + password + "',gender = '" + gender + "',employee_type = '"+employee_type+"' where id = '"+id+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
        }
        public void add(string fname, string lname, string phone, string email, string username, string password, string gender,string employee_type)
        {
            con.Open();
            string query = "insert into employee (firstname, lastname,phone,email,username,pass_word,gender,employee_type) values ('" + fname + "','" + lname + "' , '" + phone + "', '" + email + "','" + username + "', '" + password + "', '" + gender + "','"+employee_type+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
        }
        public void remove(int id)
        {
            con.Open();
            string query = "delete from employee where id = '"+id+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
        }


    }
    public class User : Employee
    {
        public User(string username, string password)
        {
            base.username = username;
            base.password = password;
            employee = "worker";
        }
        User() { }
    }
    public class Customer : Person
    {
        string movie, tckt;
        TimeSpan time;
        int seats;
        public Customer() { }
        public Customer(string Fname, string Lname, string phone, string email, string movie, string tckt, TimeSpan time, int seats)
        {
            Firstname = Fname;
            Lastname = Lname;
            base.phone = phone;
            Email = email;
            this.movie = movie;
            this.tckt = tckt;
            this.time = time;
            this.seats = seats;

        }
        public void enterCustomer()
        {
            con.Open();
            string query = "select price from ticketcategory where ticket_name='" + tckt + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            string query1 = "select movie_id from moviecategory where movie_name = '" + movie + "'";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            string query2 = " select hall_id from movietiming where movie_id = '" + cmd1.ExecuteScalar() + "' and time_ = '" + time + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            string query3 = " insert into Customer(Firstname,Lastname,phoneNo,Email,movie,category,timing,hall,cost,seats) values ('" + Firstname + "','" + Lastname + "','" + phone + "','" + Email + "', '" + movie + "', '" + tckt + "','" + time + "','" + cmd2.ExecuteScalar() + "','" + cmd.ExecuteScalar() + "','" + seats + "'); ";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            cmd3.ExecuteReader();
            con.Close();
        }
        public DataTable showcustomer()
        {
            con.Open();
            string query = " select id,firstname,lastname,phoneNo,Email,movie,category,timing,hall,cost,seats from customer;  ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);      //this statement fills tha data table with the query written above
            con.Close();
            return dtbl;
        }
        public DataTable search(string text)
        {
            con.Open();
            string query = "select * from customer where id like '%" + text + "%' or firstname like '%" + text + "%' or lastname like '%" + text + "%' or phoneNo like '%" + text + "%' or Email like '%" + text + "%' or movie like '%" + text + "%' or category like'%" + text + "%' or timing like '%" + text + "%' or hall like '%" + text + "%' or cost like '%" + text + "%' or seats like '%" + text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }
        public void update(int id,string phone,string email)
        {
            con.Open();
            string query = "update customer set phoneNo ='" + phone + "', email = '" + email + "'  where id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
        }
    }
    public class Movies : Connection
    {
        protected int id;
        protected string name, tckt;
        protected int hall;
        public Movies(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Movies() { }
        public void addmovie()
        {
            con.Open();
            string query = "insert into moviecategory(movie_id,movie_name) values ('" + id + "','" + name + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
        }
        public void addtiming(TimeSpan time)
        {
            con.Open();

            string query0 = "select id from ticketcategory where ticket_name= '" + tckt + "'";
            SqlCommand cmd0 = new SqlCommand(query0, con);
            string query1 = "insert into movietiming(movie_id,ticket_id,time_,hall_id) values ('" + id + "','" + cmd0.ExecuteScalar() + "','" + time + "','" + hall + "')";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.ExecuteReader();
        }
        public void removemovie(int movie)
        {
            con.Open();
            string query0 = "select hall_id,time_ from movietiming where movie_id='" + movie + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query0, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                string query1 = "insert into availabletime (hall_id,time_) values ('" + dt.Rows[i]["hall_id"].ToString()+"','"+TimeSpan.Parse(dt.Rows[i]["time_"].ToString())+"')";
                SqlCommand cmd = new SqlCommand(query1, con);
                cmd.ExecuteReader();
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string query2 = "delete from hall where hall_id = '" + dt.Rows[i]["hall_id"] + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                cmd.ExecuteReader();
            }
                string query = " delete from movietiming where movie_id='" + movie + "' ;";
            SqlCommand cmd1 = new SqlCommand(query, con);
            cmd1.ExecuteReader();

            string statement = " delete from moviecategory where movie_id ='" + movie + "';";
            SqlCommand cmd0 = new SqlCommand(statement, con);
            cmd0.ExecuteReader();

            con.Close();
        }
        public DataTable showmovie()
        {
            con.Open();
            string query = "Select date_, time_, hall_id, ticket_name, movie_name from movietiming left join moviecategory on movietiming.movie_Id = moviecategory.movie_id left join ticket category.id=movie timing.ticketid";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);      //this statement fills tha data table with the query written above
            con.Close();
            return dtbl;
           // alter table employee add Email varchar(255);

           // select* from movietiming

           //select movietiming.time_, moviecategory.movie_name, ticketcategory.price, ticketcategory.ticket_name
           //from movietiming left join moviecategory on movietiming.movie_id = moviecategory.movie_id left join ticketcategory on movietiming.ticket_id = ticketcategory.id

        }
    }
    public abstract class Addmovies : Movies
    {

        public abstract void updatehall(TimeSpan time);

        public void showavailabletime(string hall)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-APHGB9B;Initial Catalog=cinemamanagement;Integrated Security=True;MultipleActiveResultSets=true;MultipleActiveResultSets=true");
            con.Open();
            string statment = "select count(*) from availabletime;";
            int count = 0;
            SqlCommand cmd = new SqlCommand(statment, con);
            count = (int)cmd.ExecuteScalar();
            string statment1 = "select id from availabletime;";
            int id = 0;
            SqlCommand cmd0 = new SqlCommand(statment1, con);
            id = (int)cmd0.ExecuteScalar();

            for (int i = 1; i <= count; i++)
            {
                string query0 = "select * from availabletime where id = '" + id + "';";
                SqlCommand cmd1 = new SqlCommand(query0, con);
                if (cmd1.ExecuteScalar() != null)
                {
                    string query = " select time_ from availabletime where hall_id = '" + hall + "' and id= '" + id + "'";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    if (cmd2.ExecuteScalar() != null)
                    {
                        string query1 = "insert into runtime (availabletime) values( '" + cmd2.ExecuteScalar() + "')";
                        SqlCommand cmd3 = new SqlCommand(query1, con);
                        cmd3.ExecuteReader();
                    }
                }
                else
                { i--; }
                id++;
            }


        }
        public class Silver : Addmovies
        {
            public Silver() { }
            public Silver(int id, string name, string tckt, int hall)

            {
                this.id = id;
                this.name = name;
                this.tckt = tckt;
                this.hall = hall;
            }
            public override void updatehall(TimeSpan time)
            {
                addtiming(time);
                string query = "insert into hall (hall_id,totalseats,remainingseats,bookedseats,time_) values ('"+hall+"','" + 50 + "','" + 50 + "','" + 0 + "','"+time+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteReader();
                con.Close();

            }
        }
        public class Gold : Addmovies
        {
            public Gold() { }
            public Gold(int id, string name, string tckt, int hall)

            {
                this.id = id;
                this.name = name;
                this.tckt = tckt;
                this.hall = hall;
            }
            public override void updatehall(TimeSpan time)
            {
                addtiming(time);
                string query = "insert into hall (hall_id,totalseats,remainingseats,bookedseats,time_) values ('"+hall+"','" + 40 + "','" + 40 + "','" + 0 + "','"+time+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteReader();
                con.Close();

            }
        }
        public class Platinum : Addmovies
        {
            public Platinum() { }
            public Platinum(int id, string name, string tckt, int hall)

            {
                this.id = id;
                this.name = name;
                this.tckt = tckt;
                this.hall = hall;
            }
            public override void updatehall(TimeSpan time)
            {
                addtiming(time);
                string query = "insert into hall (hall_id,totalseats,remainingseats,bookedseats,time_) values ('"+hall+"' ,'"+ 30 + "','" + 30 + "','" + 0 + "','"+time+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteReader();
                con.Close();

            }
        }
    }
    public class Ticket : Connection
    {
        // int totalseats = 50;
        string ticketcategory;
        int ticketquantity;
        public Ticket(string ticketcategory, int ticketquantity)
        {
            this.ticketcategory = ticketcategory;
            this.ticketquantity = ticketquantity;
        }

        public int Bill()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-APHGB9B;Initial Catalog=cinemamanagement;Integrated Security=True;MultipleActiveResultSets=true;MultipleActiveResultSets=true");
            con.Open();
            string statment = "select count(*) from ticketcategory;";
            int count = 0;
            SqlCommand cmd = new SqlCommand(statment, con);
            count = (int)cmd.ExecuteScalar();
            int d = 0;
            for (int i = 1; i <= count; i++)
            {


                string selectquery = "select price from ticketcategory where ticket_name = '" + ticketcategory + "'; ";
                SqlCommand cmd1 = new SqlCommand(selectquery, con);
                if (cmd1.ExecuteScalar() != null)
                {


                    SqlDataReader dr = cmd1.ExecuteReader();
                    dr.Read();
                    d = dr.GetInt32(0);
                    dr.Close();
                    break;
                }


                i++;
            }
            d = d * ticketquantity;
            con.Close();

            return d;


        }




    }
    public class Movietiming : Connection
    {
        int mov, tckt;
        public Movietiming() { }
        public Movietiming(int mov, int tckt)
        {
            this.mov = mov;
            this.tckt = tckt;
        }
        public void gettiming()
        {
            con.Open();
            string statment = "select count(*) from movietiming;";
            int count = 0;
            SqlCommand cmd = new SqlCommand(statment, con);
            count = (int)cmd.ExecuteScalar();
            string statment1 = "select id from movietiming;";
            int id = 0;
            SqlCommand cmd0 = new SqlCommand(statment1, con);
            id = (int)cmd0.ExecuteScalar();
            //string time = "6";
            for (int i = 1; i <= count; i++)
            {
                string query0 = "select * from movietiming where id = '" + id + "';";
                SqlCommand cmd3 = new SqlCommand(query0, con);
                if (cmd3.ExecuteScalar() != null)
                {

                    string selectquery = "select time_ from movietiming where id= '" + id + "'and movie_id = '" + mov + "' and ticket_id = '" + tckt + "'; ";
                    SqlCommand cmd1 = new SqlCommand(selectquery, con);
                    if (cmd1.ExecuteScalar() != null)
                    {
                        string query = "insert into runtime (time_) values('" + cmd1.ExecuteScalar() + "');";
                        SqlCommand cmd2 = new SqlCommand(query, con);
                        cmd2.ExecuteReader();
                        //SqlDataReader dr = cmd1.ExecuteReader();
                        //dr.Read();
                        //time = dr.ToString();
                    }
                }
                else
                { i--; }


                id++;

            }

            con.Close();

            //return time;

        }

    }
    //public class Date 
    //{
    //    public Date()
    //    { }


    //    public DateTime[] getdate()
    //    {
    //        DateTime presentdate = DateTime.Today;
    //        SqlConnection con = new SqlConnection("Data Source=DESKTOP-APHGB9B;Initial Catalog=cinemamanagement;Integrated Security=True;MultipleActiveResultSets=true");
    //        con.Open();
    //        string statment = "select count(*) from movietiming;";
    //        int count = 0;
    //        SqlCommand cmd = new SqlCommand(statment, con);
    //        count = (int)cmd.ExecuteScalar();
    //        string statment1 = "select id from movietiming;";
    //        int id = 0;
    //        SqlCommand cmd0 = new SqlCommand(statment1, con);
    //        id = (int)cmd0.ExecuteScalar();
    //    }

    //}
    public class Hall : Connection
    {
        TimeSpan timing;
        int tcktcategory;
        int seat;
        int movie;
        public Hall(int movie, TimeSpan timing, int tcktcategory)
        {
            this.timing = timing;
            this.movie = movie;
            this.tcktcategory = tcktcategory;
        }
        public Hall(int movie, TimeSpan timing, int tcktcategory, int seat)
        {
            this.timing = timing;
            this.seat = seat;
            this.movie = movie;
            this.tcktcategory = tcktcategory;
        }
        public void bookedseats()
        {
            con.Open();
            string statment = "select count(*) from movietiming;";
            int count = 0;
            SqlCommand cmd = new SqlCommand(statment, con);
            count = (int)cmd.ExecuteScalar();
            //int remainingseats  ;
            //for (int i = 1; i <= count; i++)
            //{
            string selectquery = "select hall_id from movietiming where time_ = '" + timing + "'and movie_id= '" + movie + "' and ticket_id = '" + tcktcategory + "' ;";
            SqlCommand cmd1 = new SqlCommand(selectquery, con);
            if (cmd1.ExecuteScalar() != null)
            {
                string query = "select bookedseats from hall where hall_id = '" + cmd1.ExecuteScalar() + "' and time_ = '" + timing + "';";
                SqlCommand cmd2 = new SqlCommand(query, con);
                SqlDataReader dr = cmd2.ExecuteReader();
                dr.Read();
                int bookedseats = dr.GetInt32(0);
                bookedseats = bookedseats + seat;
                string query1 = "update hall set bookedseats = '" + bookedseats + "' where hall_id= '" + cmd1.ExecuteScalar() + "' and time_ = '" + timing + "';";
                SqlCommand cmd3 = new SqlCommand(query1, con);
                cmd3.ExecuteReader();
            }

            //}
            con.Close();
        }
        public int getavailableseats()
        {
            con.Open();
            string statment = "select count(*) from movietiming;";
            int count = 0;
            SqlCommand cmd = new SqlCommand(statment, con);
            count = (int)cmd.ExecuteScalar();
            int remainingseats = 0;
            //for (int i = 1; i <= count; i++)
            //{
            string selectquery = "select hall_id from movietiming where time_ = '" + timing + "' and movie_id =" + movie + " and ticket_id = " + tcktcategory + " ;";
            SqlCommand cmd1 = new SqlCommand(selectquery, con);
            if (cmd1.ExecuteScalar() != null)
            {
                string query = "select remainingseats from hall where hall_id = " + cmd1.ExecuteScalar() + " and time_ = '" + timing + "';";
                SqlCommand cmd2 = new SqlCommand(query, con);

                SqlDataReader dr = cmd2.ExecuteReader();
                dr.Read();
                remainingseats = dr.GetInt32(0);

            }

            //}
            con.Close();
            return remainingseats;


        }
        public void setavailableseats()
        {
            con.Open();
            string statment = "select count(*) from movietiming;";
            int count = 0;
            SqlCommand cmd = new SqlCommand(statment, con);
            count = (int)cmd.ExecuteScalar();
            int remainingseats = 0;
            //for (int i = 1; i <= count; i++)
            //{
            string selectquery = "select hall_id from movietiming where time_ = '" + timing + "'and movie_id ='" + movie + "' and ticket_id = '" + tcktcategory + "' ;";
            SqlCommand cmd1 = new SqlCommand(selectquery, con);
            if (cmd1.ExecuteScalar() != null)
            {
                string query = "select remainingseats from hall where hall_id = '" + cmd1.ExecuteScalar() + "' and time_ = '" + timing + "';";
                SqlCommand cmd2 = new SqlCommand(query, con);
                SqlDataReader dr = cmd2.ExecuteReader();
                dr.Read();
                remainingseats = dr.GetInt32(0);
                remainingseats = remainingseats - seat;
                string query1 = "update hall set remainingseats = '" + remainingseats + "' where hall_id = '" + cmd1.ExecuteScalar() + "' and time_ = '" + timing + "';";
                SqlCommand cmd3 = new SqlCommand(query1, con);
                cmd3.ExecuteReader();
            }

            //}
            con.Close();

        }
    }
}

