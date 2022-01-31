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
    public partial class booksearch : Form
    {
        string mycon = "datasource=localhost;username=root;password=;database=library_db";
        public booksearch()
        {
            InitializeComponent();
            combo();

        }

        //Showtext


        // COmbo List data
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

        private void booksearch_Load(object sender, EventArgs e)
        {
          
          
            outputpanel.Hide();
            lbl_bookid.Visible = false;
         
           

        }

        private void btn_search_Click(object sender, EventArgs e)

        {
           
          


         

                try
                {
                    string query = "select * from library_db.library_book where title='" + combosearch.Text + "'";

                    MySqlConnection conn = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, conn);
                    MySqlDataReader searchread;


                    conn.Open();
                    searchread = mycommand.ExecuteReader();


                    if (searchread.Read())
                    {
                    searchpanel.Hide();
                    outputpanel.Show();

                    txtBookTitle.Text = ("Title: "+searchread.GetString("title"));
                        txtAuthor.Text = ("Author: " + searchread.GetString("author"));
                        txtDescription.Text = ("Description :  " + System.Environment.NewLine+" "+searchread.GetString("description"));
                       lbl_bookid.Text = searchread.GetString("book_id");
                    dateTimePicker1.Text = searchread.GetString("published");

                    }
                    else {

                        MessageBox.Show("Data not found", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }








        




        private void btn_done_Click(object sender, EventArgs e)
        {
            outputpanel.Hide();
            searchpanel.Show();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            outputpanel.Hide();
            searchpanel.Show();
        }

        private void searchpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

