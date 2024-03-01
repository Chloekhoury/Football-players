using System.Data;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            //hides password when typing
            Password_Textbox.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //Get Username and Password input
            string Username_Input = Username_Textbox.Text;
            string Password_Input = Password_Textbox.Text;


            //Checks if Username and Password are in DB
            SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog=CS; Integrated Security = True ");
            SqlCommand user_search = new SqlCommand("SELECT * FROM Users WHERE username = @Username_Input AND password = @Password_Input", con);
            user_search.Parameters.AddWithValue("@Username_Input", Username_Input);
            user_search.Parameters.AddWithValue("@Password_Input", Password_Input);
            SqlDataAdapter sda = new SqlDataAdapter(user_search);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            con.Open();
            user_search.ExecuteNonQuery();
            con.Close();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["password"].ToString() == Password_Input)
                    {
                        //Opens Main Page
                        this.Hide();
                        Main_Page main_page = new Main_Page();
                        main_page.Show();


                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Error");
            }


        }




        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_Password_Button.Checked == false)
                Password_Textbox.UseSystemPasswordChar = true;
            else
                Password_Textbox.UseSystemPasswordChar = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
