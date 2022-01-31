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
    public partial class manageaccount : Form
    {

        string mycon = "datasource=localhost;username=root;password=;database=library_db";
        public manageaccount()
        {
            InitializeComponent();
        }

   

        private void manageaccount_Load(object sender, EventArgs e)
        {
            txtlastname.Text = (studentloginform.UserDisplay.displayLName).ToUpper();
            txtfirstname.Text = (studentloginform.UserDisplay.displayFName).ToUpper();
            lblcourse.Text = studentloginform.UserDisplay.displayCourse;
            ID.Text = studentloginform.UserDisplay.displayuserID;
            txtrepass.Text = string.Empty;
            txtpass.Text = string.Empty;
            txtoldpass.Text = string.Empty;
            
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

          
            try
            {
                string query = "SELECT library_db.library_students.*,library_db.library_accounts.* FROM library_db.library_accounts " +
                    "INNER JOIN library_db.library_students on library_db.library_students.account_id=library_db.library_accounts.user_id where library_db.library_accounts.password='"+txtoldpass.Text+"'";
                string query2 = "UPDATE `library_accounts` SET `password`='"+txtpass.Text+"' WHERE user_id='"+ID.Text+ "'";
                
                MySqlConnection conn = new MySqlConnection(mycon);
               
                    MySqlCommand mycommand = new MySqlCommand(query, conn);
                MySqlCommand mycommand2 = new MySqlCommand(query2, conn);
               
                MySqlDataReader myreader;
                    
                conn.Open();
                myreader = mycommand.ExecuteReader();
                   

                    if (myreader.Read())
                {
              
                    updatedata();
                   
                }
                    else
                {
                    MessageBox.Show("Old Password Not Match!", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }
                conn.Close();

              




            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                    
                    }
        }
        public void updatestudinformation() {
            MySqlConnection conn = new MySqlConnection(mycon);
            string query3 = "UPDATE `library_students` SET `lastname`='" + this.txtlastname.Text + "',`firstname`='" + this.txtfirstname.Text + "' WHERE account_id='" + this.ID.Text + "'";
            MySqlCommand mycommand3 = new MySqlCommand(query3, conn);
            MySqlDataReader myreader3;
            
           
                conn.Open();
                myreader3 = mycommand3.ExecuteReader();
              



        }
        public void updatedata() {

            MySqlConnection conn = new MySqlConnection(mycon);
            string query2 = "UPDATE `library_accounts` SET `password`='" + this.txtpass.Text + "' WHERE user_id='" + ID.Text + "'";


            MySqlCommand mycommand2 = new MySqlCommand(query2, conn);
            MySqlDataReader myreader2;

            if (txtrepass.Text != txtpass.Text ||
                       txtpass.Text.Equals("") ||
                       txtrepass.Text.Equals("") ||
                       txtoldpass.Text.Equals("") 


                       )
            {
                MessageBox.Show("wrong credentials", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else if (txtfirstname.Text.Equals("") ||
                       txtlastname.Text.Equals(""))
            {
                MessageBox.Show("Fill up all field", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else if (txtrepass.Text == txtoldpass.Text ||
                  txtpass.Text == txtoldpass.Text
                  ) {
                MessageBox.Show("Do not use old password", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                conn.Open();
                myreader2 = mycommand2.ExecuteReader();
                MessageBox.Show("Information Update complete", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpass.UseSystemPasswordChar = false;
                txtoldpass.UseSystemPasswordChar = false;
                txtrepass.UseSystemPasswordChar = false;


                txtoldpass.Text = string.Empty;

                txtrepass.Text = string.Empty;
                txtpass.Text = string.Empty;
                updatestudinformation();



                conn.Close();

            }


        }

        private void txtoldpass_TextChanged(object sender, EventArgs e)
        {
            txtoldpass.UseSystemPasswordChar = true;
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
              txtpass.UseSystemPasswordChar = true;
        }

        private void txtrepass_TextChanged(object sender, EventArgs e)
        {
            txtrepass.UseSystemPasswordChar = true;
        }
    }
    }

