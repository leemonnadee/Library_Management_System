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
    public partial class stud_borrow : Form

    {
        string mycon = "datasource=localhost;username=root;password=;database=library_db";
        string student = studentloginform.UserDisplay.displaystud_id;
        

        public stud_borrow()
        {
            InitializeComponent();
            combo();
        }


        void combo()
        {


            string query = "Select * from library_db.library_book order by title asc;";

            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommand = new MySqlCommand(query, conn);
            MySqlDataReader myreader2;

            try
            {
                conn.Open();
                myreader2 = mycommand.ExecuteReader();

                while (myreader2.Read())
                {


                    string title = myreader2.GetString("title");


                    combosearch.Items.Add(title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void textreset()
        {

            combosearch.Text = "Book title";
            txtAuthor.Text="";
            txtDescription.Text="";
            lbl_bookid.Text = "";
          

        }
        public void dateformat() {
            date_issuing.Format = DateTimePickerFormat.Custom;
            date_return.Format = DateTimePickerFormat.Custom;
            date_issuing.CustomFormat = "ddd dd MMM yyyy";
            date_return.CustomFormat = "ddd dd MMM yyyy";


        }
        public void dateformatreturn() {

            date_issuing.Format = DateTimePickerFormat.Custom;
            date_return.Format = DateTimePickerFormat.Custom;
            date_issuing.CustomFormat = "yy-MM-dd";
            date_return.CustomFormat = "yy-MM-dd";

        }
        
        private void bookreq_Load(object sender, EventArgs e)
        {
            
            date_issuing.Value = DateTime.Now;
            date_return.Value = DateTime.Today.AddDays(3);
            dateformat();
            lbl_bookid.Show();

        }

        private void combosearch_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                string query = "Select * from library_db.library_book where title='" + combosearch.Text + "'";

                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);
                MySqlDataReader searchread;


                conn.Open();
                searchread = mycommand.ExecuteReader();
               

                if (searchread.Read())
                {


                    txtAuthor.Text = searchread.GetString("author");
                    txtDescription.Text = searchread.GetString("description");
                    lbl_bookid.Text = searchread.GetString("book_id");
                    dateTimePicker1.Text = searchread.GetString("published");


                }
                else
                {

                    MessageBox.Show("Data not found", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void stud_id() {

            try
            {

            }
            catch (Exception ex) {

             
            }
        
        }
        private void btn_borrowbook_Click(object sender, EventArgs e)
        {
          
            if (lbl_bookid.Text.Equals(""))
            {

                MessageBox.Show("Please Select book!", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }else
            { 

            try
            {
                    dateformatreturn();
                    string brw = "INSERT INTO `library_borrow`(`borrow_id`, `date_borrow`, `date_return`, `stud_id`, `book_id`) " +
                    "VALUES ('','" + date_issuing.Text + "','" + date_return.Text + "','" + student + "','" + lbl_bookid.Text+ "')";


                MySqlConnection conn2 = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(brw, conn2);
                MySqlDataReader borrowread;
                conn2.Open();
                borrowread = mycommand.ExecuteReader();
          
                conn2.Close();
                    textreset();
                    dateformat();
                    MessageBox.Show("Book added complete!", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            
            }
            }
        }
    }



    }

