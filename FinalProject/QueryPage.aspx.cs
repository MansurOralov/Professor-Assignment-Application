using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Professor> profList = new List<Professor>();
        SqlConnection con = new SqlConnection();
        int counter = 0;



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Invisible();
                Button5.Visible = false;
            }



        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Check(RadioButton4, RadioButton5, RadioButton6);


        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Check(RadioButton5, RadioButton4, RadioButton6);

        }

        protected void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Check(RadioButton6, RadioButton5, RadioButton4);

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Check(RadioButton1, RadioButton2, RadioButton3);
            Button1.Visible = true;

            Invisible();
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Check(RadioButton2, RadioButton1, RadioButton3);
            Button1.Visible = false;
            Button5.Visible = false;


            Button2.Visible = true;
            Button3.Visible = true;
            Button4.Visible = true;
            TextBox1.Visible = true;
            Label4.Visible = true;
            GridView1.Visible = false;
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Check(RadioButton3, RadioButton2, RadioButton1);

            Invisible();
            Button1.Visible = false;
            Button5.Visible = true;
            GridView1.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source= DESKTOP-F4T05A9; Initial Catalog = Prof_Availability; Integrated Security = True";
            con.Open();
            string courseCode = code.Text;

            if (RadioButton1.Checked && RadioButton4.Checked)
            {

                SqlDataAdapter cmd = new SqlDataAdapter("Both1", con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.Add("@code", SqlDbType.VarChar).Value = courseCode;
                DataTable dtbl = new DataTable();
                cmd.Fill(dtbl);
                GridView1.DataSource = dtbl;
                GridView1.DataBind();


            }

            if (RadioButton1.Checked && RadioButton6.Checked)
            {
                SqlDataAdapter cmd = new SqlDataAdapter("PhD", con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.Add("@code", SqlDbType.VarChar).Value = courseCode;
                DataTable dtbl = new DataTable();
                cmd.Fill(dtbl);
                GridView1.DataSource = dtbl;
                GridView1.DataBind();


            }

            if (RadioButton1.Checked && RadioButton5.Checked)
            {
                SqlDataAdapter cmd = new SqlDataAdapter("Masters", con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.Add("@code", SqlDbType.VarChar).Value = courseCode;
                DataTable dtbl = new DataTable();
                cmd.Fill(dtbl);
                GridView1.DataSource = dtbl;
                GridView1.DataBind();


            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            if (RadioButton2.Checked && RadioButton4.Checked)
            {
                ChangeList(ref profList);
            }
            TextBox1.Text = "Press Next";
        }




        // Method  to check the radio buttons
        void Check(RadioButton main, RadioButton r2, RadioButton r3)
        {
            if (main.Checked)
            {
                r2.Checked = false;
                r3.Checked = false;
            }

        }

        void Invisible()
        {
            Button2.Visible = false;
            Button3.Visible = false;
            Button4.Visible = false;
            TextBox1.Visible = false;
            Label4.Visible = false;
        }


        void ChangeList(ref List<Professor> profeList)
        {
            con.ConnectionString = @"Data Source= DESKTOP-F4T05A9; Initial Catalog = Prof_Availability; Integrated Security = True";
            con.Open();
            string courseCode = code.Text;


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from professor";
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Professor prof = new Professor();
                prof.pID = Convert.ToString(rd["ProfID"]);
                prof.pName = Convert.ToString(rd["Name"]);
                prof.pEducation = Convert.ToString(rd["Eductaion"]);
                prof.pCourseCode = Convert.ToString(rd["CourseCode"]);
                prof.pDay = Convert.ToString(rd["Day"]);
                prof.pTime = Convert.ToString(rd["Time"]);
                profList.Add(prof);
            }

        }

        public void Button3_Click(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source= DESKTOP-F4T05A9; Initial Catalog = Prof_Availability; Integrated Security = True";
            con.Open();
            string courseCode = code.Text;

            if (RadioButton2.Checked && RadioButton4.Checked)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"Both1 @code = { courseCode }";
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                List<Professor> both = new List<Professor>();

                while (rd.Read())
                {
                    Professor prof = new Professor();
                    prof.pID = Convert.ToString(rd["ProfID"]);
                    prof.pName = Convert.ToString(rd["Name"]);
                    prof.pEducation = Convert.ToString(rd["Eductaion"]);
                    prof.pCourseCode = Convert.ToString(rd["CourseCode"]);
                    prof.pDay = Convert.ToString(rd["Day"]);
                    prof.pTime = Convert.ToString(rd["Time"]);
                    both.Add(prof);
                }

                if (Counter.BothCounter1 < both.Count)
                {
                    TextBox1.Text = Convert.ToString(both[Counter.BothCounter1].pName) + ", "
                                  + Convert.ToString(both[Counter.BothCounter1].pCourseCode) + ", " +
                                    Convert.ToString(both[Counter.BothCounter1].pDay) + ", " +
                                    Convert.ToString(both[Counter.BothCounter1].pTime) + ", " +
                                    Convert.ToString(both[Counter.BothCounter1].pEducation);
                    Counter.BothCounter1++;
                }

            }

            if (RadioButton2.Checked && RadioButton5.Checked)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"Masters @code = { courseCode }";
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                List<Professor> masters = new List<Professor>();

                while (rd.Read())
                {
                    Professor prof = new Professor();
                    prof.pID = Convert.ToString(rd["ProfID"]);
                    prof.pName = Convert.ToString(rd["Name"]);
                    prof.pEducation = Convert.ToString(rd["Eductaion"]);
                    prof.pCourseCode = Convert.ToString(rd["CourseCode"]);
                    prof.pDay = Convert.ToString(rd["Day"]);
                    prof.pTime = Convert.ToString(rd["Time"]);
                    masters.Add(prof);
                }

                if (Counter.MastersCounter < masters.Count)
                {
                    TextBox1.Text = Convert.ToString(masters[Counter.MastersCounter].pName) + ", "
                                  + Convert.ToString(masters[Counter.MastersCounter].pCourseCode) + ", " +
                                    Convert.ToString(masters[Counter.MastersCounter].pDay) + ", " +
                                    Convert.ToString(masters[Counter.MastersCounter].pTime) + ", " +
                                    Convert.ToString(masters[Counter.MastersCounter].pEducation);
                    Counter.MastersCounter++;
                }

            }
            if (RadioButton2.Checked && RadioButton6.Checked)
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = $"PhD @code = {courseCode}";
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                List<Professor> PhD = new List<Professor>();

                while (rd.Read())
                {
                    Professor prof = new Professor();
                    prof.pID = Convert.ToString(rd["ProfID"]);
                    prof.pName = Convert.ToString(rd["Name"]);
                    prof.pEducation = Convert.ToString(rd["Eductaion"]);
                    prof.pCourseCode = Convert.ToString(rd["CourseCode"]);
                    prof.pDay = Convert.ToString(rd["Day"]);
                    prof.pTime = Convert.ToString(rd["Time"]);
                    PhD.Add(prof);
                }
                if (Counter.PhDCounter < PhD.Count)
                {
                    TextBox1.Text = Convert.ToString(PhD[Counter.PhDCounter].pName) + ", "
                                  + Convert.ToString(PhD[Counter.PhDCounter].pCourseCode) + ", " +
                                    Convert.ToString(PhD[Counter.PhDCounter].pDay) + ", " +
                                    Convert.ToString(PhD[Counter.PhDCounter].pTime) + ", " +
                                    Convert.ToString(PhD[Counter.PhDCounter].pEducation);
                    Counter.PhDCounter++;
                }

            }
        }
        public void Button4_Click(object sender, EventArgs e)
        {
            List<Professor> schedule = new List<Professor>();
            string text = TextBox1.Text;
            string[] record = text.Split(',');
             Professor p = new Professor("1", record[0], record[4], record[1], record[2], record[3]);
            schedule.Add(p);


            if (p.pEducation.Contains("P"))
            {
                Counter.phD++;
            }
            else
            {
                Counter.masters++;
                
            }
        }




        // This class is a counters class, because the standard counters didn't work for some reason;
        class Counter
        {
            public static int BothCounter1 = 0;
            public static int MastersCounter = 0;
            public static int PhDCounter = 0;
            public static int OccurenceCounter = 0;
            public static int masters = 0;
            public static int phD = 0;

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            info.Text = $"Professors with PhD: {Counter.phD}";
            info1.Text =  $"Professors with Masters: {Counter.masters}";
        }
    }
}
     