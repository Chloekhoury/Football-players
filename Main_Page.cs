using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CS
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
            dataGridView1.Hide();
        }

        private DataTable Search()
        {
            //gets search keyword from textbox
            string Search_Input = Search_TextBox.Text;


            string firstName = null;
            string lastName = null;
            int i;


            SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog=CS; Integrated Security = True ");
            SqlCommand select;

            if (checkBox2.Checked == true)
            {
                select = new SqlCommand("SELECT * FROM Teams WHERE TeamName = @Search_Input", con);
                select.Parameters.AddWithValue("@Search_Input", Search_Input);
            }
            else
            {
                Search_Input = Search_Input + " "; //add space to eliminate exception (index out of bounds)
                //gets player's First_Name and Last_Name
                for (i = 0; Search_Input[i] != ' '; i++)
                {
                    firstName = firstName + Search_Input[i];
                }
                for (i = i + 1; i < Search_Input.Length; i++)
                {
                    lastName = lastName + Search_Input[i];
                }

                select = new SqlCommand("SELECT * FROM Players WHERE First_Name = @First_Name OR Last_Name = @Last_Name", con);
                select.Parameters.AddWithValue("@First_Name", firstName);
                select.Parameters.AddWithValue("@Last_Name", lastName);
            }

            SqlDataAdapter sda = new SqlDataAdapter(select);
            DataTable resultsdt = new DataTable();

            try
            {
                sda.Fill(resultsdt);
                con.Open();
                select.ExecuteNonQuery();
                con.Close();
            }
            catch // if last name is not entered
            {
                MessageBox.Show("No item match your search.");
            }
            return resultsdt;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //gets search results
            DataTable resultsdt = Search();



            if (resultsdt.Rows.Count == 0)
            {
                MessageBox.Show("No items match your search.");
            }
            else
            {

                if (checkBox1.Checked == true) //Display Book Info
                {
                    //Gets info to be Displayed
                    string firstname, lastname, team;
                    firstname = resultsdt.Rows[0]["First_Name"].ToString();
                    lastname = resultsdt.Rows[0]["Last_Name"].ToString();
                    team = getteam(resultsdt);


                    label4.Text = firstname;

                    label5.Text = lastname;

                    label7.Text = team;

                }
                else // Display team Info
                {
                    string teamname, nationality;
                    teamname = resultsdt.Rows[0]["TeamName"].ToString();
                    nationality = getnationality(resultsdt);

                    label4.Text = teamname;
                    label5.Text = nationality;


                }

            }

        }

        private string getteam(DataTable resultsdt)
        {
            SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog=CS; Integrated Security = True ");
            SqlCommand selectteam = new SqlCommand("SELECT * FROM Teams WHERE TeamID = @TeamID", con);
            selectteam.Parameters.AddWithValue("@TeamID", resultsdt.Rows[0]["TeamID"]);
            SqlDataAdapter sda = new SqlDataAdapter(selectteam);
            DataTable team = new DataTable();
            sda.Fill(team);
            return team.Rows[0]["TeamName"].ToString();
        }

        private string getnationality(DataTable resultsdt)
        {
            SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog=CS; Integrated Security = True ");
            SqlCommand selectnat = new SqlCommand("SELECT * FROM Nationalities WHERE NationaltyID = @NationalityID", con);
            selectnat.Parameters.AddWithValue("@NationalityID", resultsdt.Rows[0]["NationalityID"]);
            SqlDataAdapter sda = new SqlDataAdapter(selectnat);
            DataTable nationality = new DataTable();
            sda.Fill(nationality);
            return nationality.Rows[0]["Nationality"].ToString();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_player addplayer = new Add_player();
            addplayer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Show();
            SqlDataAdapter q = new SqlDataAdapter("select * from Players", Properties.Settings.Default.connsettings);
            DataSet data = new DataSet();
            q.Fill(data);
            this.dataGridView1.DataSource = data.Tables[0];
        }
    }
}
