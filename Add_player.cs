using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace CS
{
    public partial class Add_player : Form
    {
        public Add_player()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-S8D10J1; Initial Catalog=CS; Integrated Security = True ");
            SqlCommand select = new SqlCommand("SELECT * FROM Teams WHERE TeamName = @Team_name", con);
            select.Parameters.AddWithValue("@Team_name", Teamname_text.Text);
            SqlDataAdapter sda = new SqlDataAdapter(select);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            select.ExecuteNonQuery();
            con.Close();

            string team_id;

            if (dt.Rows.Count > 0)
            {
                team_id = dt.Rows[0]["TeamID"].ToString();
                // team found, check player.
                SqlCommand player = new SqlCommand("SELECT * FROM Players WHERE First_Name = @First_Name AND Last_Name = @Last_Name", con);
                player.Parameters.AddWithValue("@First_Name", Firstname_text.Text);
                player.Parameters.AddWithValue("@Last_Name", Lastname_text.Text);
                SqlDataAdapter sda3 = new SqlDataAdapter(player);
                DataTable dt2 = new DataTable();
                sda3.Fill(dt2);
                con.Open();
                player.ExecuteNonQuery();
                con.Close();

                if (dt2.Rows.Count == 0)
                {
                    // player not in Database add him.
                    // get last player id, because it's not auto increment.
                    SqlCommand last_playerID = new SqlCommand("SELECT MAX(PlayerID) FROM Players", con);

                    con.Open();
                    int PlayerID = (int)last_playerID.ExecuteScalar();
                    PlayerID += 1;
                    con.Close();

                    // add player.

                    try
                    {
                        SqlCommand player6 = new SqlCommand("INSERT INTO Players (PlayerID, First_Name, Last_Name, TeamID) VALUES (@PlayerID, @First_Name, @Last_Name, @TeamID)", con);

                        con.Open();
                        player6.Parameters.AddWithValue("@First_Name", Firstname_text.Text);
                        player6.Parameters.AddWithValue("@Last_Name", Lastname_text.Text);
                        player6.Parameters.AddWithValue("@TeamID", team_id);
                        player6.Parameters.AddWithValue("@PlayerID", PlayerID);

                        player6.ExecuteNonQuery();
                        con.Close();
                       
                    }
                    catch
                    {
                    }


                    MessageBox.Show("Player added successfully");
                }
                else
                {
                    // Player already exists we won't add him sorry.
                    MessageBox.Show("Player already exists.", "Error");
                }
            }
            else
            {
                //  teams doesn't exist can't add player.
                MessageBox.Show("Team doesn't exists.", "Error");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
