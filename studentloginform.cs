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
    public partial class studentloginform : Form
    {
        string mycon = "datasource=localhost;username=root;password=;database=library_db";
      

        public studentloginform()
        {
            InitializeComponent();

        }



        public class UserDisplay
        {
            public static string displayuserID;
            public static string displayFName;
            public static string displayLName;
            public static string displayCourse;
            public static string displayname ;
            public static string displaystud_id;
        }

        public void clear() {

            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtcourse.Text = "";
            signupuser.Text = "";
            signuppass.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
        }



        private void lblsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clear();
            signinpanel.Hide();
            loginpanel.Show();
         
        }

      

        private void panel1_ControlAdded(object sender, ControlEventArgs e)
        {
            loginpanel.Hide();
            signinpanel.Show();
        }

        private void studentloginform_Load(object sender, EventArgs e)
        {
            this.loginpanel.Hide();
            lblidnum.Visible = false;
            signuppass.UseSystemPasswordChar = true;
            txtpassword.UseSystemPasswordChar = true;


        }

      

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            clear();
            this.Hide();
            Mainform mf = new Mainform();
            mf.Show();
        }

    

        private void login_btn_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtusername.Text == ("admin") && txtpassword.Text == "password")
                {
                    MessageBox.Show("No Data found", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }
                else { 


                    string query = "Select * from library_accounts where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                    string query2 = "SELECT library_students.*,library_accounts.* FROM library_accounts INNER JOIN library_students on library_students.account_id=library_accounts.user_id where username='"+txtusername.Text+"' and password='"+txtpassword.Text+"'";
                    MySqlConnection conn = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, conn);
                    MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

                    MySqlDataReader myreaderfetch;
                    MySqlDataReader myreader1;
                    conn.Open();
                    myreaderfetch = mycommandfetch.ExecuteReader();
                    while (myreaderfetch.Read())
                    {
                        UserDisplay.displayuserID = myreaderfetch.GetString("user_id");
                        UserDisplay.displayLName = myreaderfetch.GetString("lastname");
                        UserDisplay.displayFName = myreaderfetch.GetString("firstname");
                        UserDisplay.displayCourse = myreaderfetch.GetString("course");
                        UserDisplay.displaystud_id = myreaderfetch.GetString("stud_id");
                    


    }
                    conn.Close();

                    conn.Open();
                    myreader1 = mycommand.ExecuteReader();
                   


                    if (myreader1.Read())
                    {
                       
                      
        

                        this.Hide();
                        Studentdashboard sd = new Studentdashboard();
                        sd.Show();


                    }
                    else
                    {
                        MessageBox.Show("Username And Password Not Match!", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clear();
                    }
                    txtusername.Text = string.Empty;
                    txtpassword.Text = string.Empty;
                  

                    conn.Close();
                  
           
                    // always close


                 

                }
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            






         
        }

     
        
        private void showpass_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (showpassslogin.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void btn_create_Click_1(object sender, EventArgs e)
        {
            if (signuppass.Text.Equals("")
                || signupuser.Text.Equals("")
                || txtfirstname.Text.Equals("")
                || txtlastname.Text.Equals("")
                || txtcourse.Text.Equals("")
                || lblidnum.Text.Equals("")
                    )
            {

                MessageBox.Show("Please Fill out all field!", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                try
                {





                    string query = "INSERT INTO `library_accounts`(`user_id`, `username`, `password`) VALUES ('','" + signupuser.Text + "','" + signuppass.Text + "')";
                    string id = "SELECT user_id from library_accounts ORDER BY user_id DESC LIMIT 1";
                    string stud = "INSERT INTO `library_students`(`stud_id`, `lastname`, `firstname`, `course`, `account_id`) VALUES ('','" + txtlastname.Text + "','" + txtfirstname.Text + "','" + txtcourse.Text + "','" + lblidnum.Text + "')";

                    MySqlConnection conn = new MySqlConnection(mycon);

                    MySqlCommand mycommand = new MySqlCommand(query, conn);
                    MySqlCommand mycommand2 = new MySqlCommand(id, conn);
                    MySqlCommand mycommand3 = new MySqlCommand(stud, conn);
                    MySqlDataReader myreader1;
                    MySqlDataReader myreader2;
                    MySqlDataReader myreader3;
                    conn.Open();
                    myreader1 = mycommand.ExecuteReader();

                    conn.Close();
                    conn.Open();

                    myreader2 = mycommand2.ExecuteReader();

                    while (myreader2.Read())
                    {

                        string s = lblidnum.Text = myreader2.GetString("user_id");
                    }



                    conn.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    string stud = "INSERT INTO `library_students`(`stud_id`, `lastname`, `firstname`, `course`, `account_id`) VALUES ('','" + txtlastname.Text + "','" + txtfirstname.Text + "','" + txtcourse.Text + "','" + lblidnum.Text + "')";

                    MySqlConnection conn = new MySqlConnection(mycon);


                    MySqlCommand mycommand3 = new MySqlCommand(stud, conn);

                    MySqlDataReader myreader3;
                    conn.Open();
                    myreader3 = mycommand3.ExecuteReader();

                    conn.Close();
                    MessageBox.Show("Account created successfully ", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loginpanel.Hide();
                    signinpanel.Show();
                 
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void showpassregister_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (showpassregister.Checked)
            {
                signuppass.UseSystemPasswordChar = false;
            }
            else
            {
                signuppass.UseSystemPasswordChar = true;
            }
        }

        private void lblsignin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clear();
            loginpanel.Hide();
            signinpanel.Show();
        }

        private void lblidnum_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

