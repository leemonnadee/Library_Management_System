using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class adminloginform : Form
    {

        string mycon = "datasource=localhost;username=root;password=;database=library_db";
        public adminloginform()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showpass_CheckedChanged_1(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (showpass.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void adminloginform_Load(object sender, EventArgs e)
        {
            
            txtpassword.UseSystemPasswordChar = true;

        }


        //--------------------------------------------------------------LOGIN BUTOOON------------------------------------------------------------------------------------------


        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusername.Text == ("admin") && txtpassword.Text == "password")
                {

                    string query = "Select * from library_accounts where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";


                    MySqlConnection conn = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, conn);
                    MySqlDataReader myreader1;



                    conn.Open();
                    myreader1 = mycommand.ExecuteReader();


                    if (myreader1.Read())
                    {
                        this.Hide();
                        adminDashboard adBoard = new adminDashboard();
                        adBoard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username And Password Not Match!", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtusername.Text = string.Empty;
                    txtpassword.Text = string.Empty;
                    myreader1.Close();
                    mycommand.Dispose();

                    // always close

                    conn.Close();

                }
                else {
                    MessageBox.Show("Username And Password Not Match!", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Mainform mf = new Mainform();
            mf.Show();

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
