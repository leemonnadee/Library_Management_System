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
    public partial class borrowform : Form
    {
        string mycon = "datasource=localhost;username=root;password=;database=library_db";
      
        public borrowform()
        {
            InitializeComponent();
            //Borrow  Data table
            showalldata();

            //Return Data Table
            returndtableshow();

            //Overdue Data table
            overdueDtable();

          


        }
        //----------------------------------------------borrower tab----------------------------------------
        public void showalldata()
        {

            try
            {
                string query = "SELECT " +
                    "library_students.stud_id," +
                    "library_students.lastname," +
                    "library_students.firstname," +
                    "library_students.course," +
                    "library_book.title, " +
                    "library_book.author," +
                    "library_borrow.date_borrow," +
                    "library_borrow.date_return" +

" FROM library_borrow INNER JOIN library_students on library_students.stud_id = library_borrow.stud_id " +
"INNER JOIN library_book ON library_book.book_id = library_borrow.book_id; ";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);

                MySqlDataAdapter myadapter = new MySqlDataAdapter();
                myadapter.SelectCommand = mycommand;
                DataTable dtable = new DataTable();
                Dtable.DataSource = dtable;


                DataTable table = new DataTable();


                myadapter.Fill(dtable);








            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        public void srch()
        {

            try
            {

                string searchQuery = "SELECT " +
                    "library_students.stud_id," +
                    "library_students.lastname," +
                    "library_students.firstname," +
                    "library_students.course," +
                    "library_book.title, " +
                    "library_book.author," +
                    "library_borrow.date_borrow," +
                    "library_borrow.date_return" +
    " FROM library_borrow INNER JOIN library_book ON library_book.book_id = library_borrow.book_id  " +
    "INNER JOIN library_students on library_students.stud_id = library_borrow.stud_id WHERE CONCAT(lastname,' ',firstname) LIKE '%" + txtSrchname.Text + "%'";

                MySqlConnection conn = new MySqlConnection(mycon);

                MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Dtable.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void txtSrchname_KeyPress(object sender, KeyPressEventArgs e)
        {
            srch();
        }










        //-----------------------------RETURN TAB----------------------------------

        public void returndtableshow()
        {


            try
            {
                string query = "SELECT " +
                    "library_borrow.borrow_id," +

                    "library_book.title," +
                    "library_borrow.date_borrow," +
                    "library_borrow.date_return" +

" FROM library_borrow INNER JOIN library_students on library_students.stud_id = library_borrow.stud_id " +
"INNER JOIN library_book ON library_book.book_id = library_borrow.book_id ";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);

                MySqlDataAdapter myadapter = new MySqlDataAdapter();
                myadapter.SelectCommand = mycommand;
                DataTable dtable = new DataTable();
                returndtable.DataSource = dtable;


                DataTable table = new DataTable();


                myadapter.Fill(dtable);








            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        //-------------------------------Dtable in return  get data----------------
        public void returndata()
        {
            if (borrow_id.Equals(null))
            {

            }
            else
            {
                try
                {
                    string query = "SELECT " +
                           "library_students.stud_id," +
                           "library_students.lastname," +
                           "library_students.firstname," +
                           "library_students.course," +
                           "library_book.title, " +
                           "library_book.author," +
                           "library_book.description," +
                           "library_borrow.date_borrow," +
                           "library_borrow.date_return" +

       " FROM library_borrow INNER JOIN library_students on library_students.stud_id = library_borrow.stud_id " +
       "INNER JOIN library_book ON library_book.book_id = library_borrow.book_id where library_borrow.borrow_id='" + borrow_id.Text + "'";
                    MySqlConnection conn = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, conn);
                    MySqlDataReader searchread;


                    conn.Open();
                    searchread = mycommand.ExecuteReader();


                    if (searchread.Read())
                    {
                        string lastname = searchread.GetString("lastname");
                        string firstname = searchread.GetString("firstname");
                        string fullname = lastname + " " + firstname;

                        txt_borrower.Text = fullname.ToUpper();
                        txt_booktitle.Text = searchread.GetString("title");
                        txt_bookauthor.Text = searchread.GetString("author");
                        txt_description.Text = ("Description :  " + System.Environment.NewLine + " " + searchread.GetString("description"));


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
        }
        public void clear()
        {
            borrow_id.Text = "";
            txt_bookauthor.Text = "";
            txt_description.Text = "";
            txt_borrower.Text = "";
            txt_booktitle.Text = "";

            //overdue elements
            overdue_id.Text = "";
            overdue_name.Text = "";
            overdue_title.Text = "";
            totalpayment.Text = "";
            studID.Text = "";
            bookID.Text = "";
            
        }
        private void returndtable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.returndtable.Rows[e.RowIndex];
                borrow_id.Text = row.Cells["borrow_id"].Value.ToString();

                returndata();
            }
        }
        //--------------------------------Return books-----------------------------
        private void btn_ReturnBook_Click(object sender, EventArgs e)
        {
            if (borrow_id.Text.Equals(null))
            {
                MessageBox.Show("Please select data ", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                try
                {
                    string query = "DELETE FROM `library_borrow` WHERE borrow_id='" + borrow_id.Text + "'";
                    MySqlConnection mycon2 = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, mycon2);
                    MySqlDataReader myreader1;
                    mycon2.Open();
                    myreader1 = mycommand.ExecuteReader();
                    MessageBox.Show("Book Has been returned in the library", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                    returndtableshow();



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }








        //------------------------------OVERDUE---------------------------------------
        public void overduesrch()
        {

            try
            {

                string query = "SELECT " +
                   "library_borrow.borrow_id," +

                   "library_book.title," +
                   "library_borrow.date_borrow," +
                   "library_borrow.date_return" +

" FROM library_borrow INNER JOIN library_students on library_students.stud_id = library_borrow.stud_id " +
"INNER JOIN library_book ON library_book.book_id = library_borrow.book_id where borrow_id LIKE '%" + txtsrchborrow_id.Text + "%'";
                MySqlConnection conn = new MySqlConnection(mycon);

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                overduetable.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }













        public void overdueDtable()
        {

            DateTime dt = DateTime.Now; // Or whatever
            string s = dt.ToString("yy-MM-dd");

            try
            {
                string query = "SELECT " +
                    "library_borrow.borrow_id," +

                    "library_book.title," +
                    "library_borrow.date_borrow," +
                    "library_borrow.date_return" +

" FROM library_borrow INNER JOIN library_students on library_students.stud_id = library_borrow.stud_id " +
"INNER JOIN library_book ON library_book.book_id = library_borrow.book_id where date_return <'"+s+"'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);

                MySqlDataAdapter myadapter = new MySqlDataAdapter();
                myadapter.SelectCommand = mycommand;
                DataTable dtable = new DataTable();
                overduetable.DataSource = dtable;


                DataTable table = new DataTable();


                myadapter.Fill(dtable);








            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void txtsrchborrow_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            overduesrch();
        }

        private void overduetable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.overduetable.Rows[e.RowIndex];
                overdue_id.Text = row.Cells["borrow_id"].Value.ToString();
              
                overduedata();
            }
        }


        public void overduedata()
        {
            if (overdue_id.Text.Equals(null))
            {

            }
            else
            {
               
                try
                {
                    string query = "SELECT " +
                           "library_students.stud_id," +
                           "library_students.lastname," +
                           "library_students.firstname," +
                           "library_students.course," +
                           "library_book.title, " +
                           "library_book.author," +
                           "library_book.description," +
                           "library_borrow.date_borrow," +
                           "library_borrow.date_return," +
                           "library_book.book_id"+

       " FROM library_borrow INNER JOIN library_students on library_students.stud_id = library_borrow.stud_id " +
       "INNER JOIN library_book ON library_book.book_id = library_borrow.book_id where library_borrow.borrow_id='" + overdue_id.Text + "'";
                    MySqlConnection conn = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, conn);
                    MySqlDataReader searchread;


                    conn.Open();
                    searchread = mycommand.ExecuteReader();


                    if (searchread.Read())
                    {
                        string lastname = searchread.GetString("lastname");
                        string firstname = searchread.GetString("firstname");
                        string fullname = lastname + " " + firstname;
                        studID.Text = searchread.GetString("stud_id");
                        bookID.Text = searchread.GetString("book_id");
                        overdue_name.Text = fullname.ToUpper();
                        overdue_title.Text = searchread.GetString("title");

                        
                    }

                  

                    conn.Close();






                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void totalpayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        public void overduepaymentcomplete() {

            try
            {
                string query = "DELETE FROM `library_borrow` WHERE borrow_id='" + overdue_id.Text + "'";
                MySqlConnection mycon2 = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, mycon2);
                MySqlDataReader myreader1;
                mycon2.Open();
                myreader1 = mycommand.ExecuteReader();
                 clear();
                overduedata();
                returndtableshow();
                MessageBox.Show("Book Has been returned in the library", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }
        private void btn_sve_Click(object sender, EventArgs e)
        {
            if (overdue_id.Text.Equals(""))
            {

                MessageBox.Show("Please Select data !", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (totalpayment.Text.Equals(""))
            {

                MessageBox.Show("Please input total payment ", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else { 
            try
            {
                    dateformatreturn();
                string save = "INSERT INTO `library_payment`(`transac_id`, `stud_id`, `book_id`, `payment`, `transaction_Date`) " +
                    "VALUES ('','"+studID.Text+"','"+bookID.Text+"','"+ totalpayment.Text+ "','"+transac_date.Text+"]')";
                MySqlConnection conn = new MySqlConnection(mycon);


                MySqlCommand mycommand = new MySqlCommand(save, conn);

                MySqlDataReader myreader;
                conn.Open();
                myreader = mycommand.ExecuteReader();

                conn.Close();

                    overduepaymentcomplete();
                  
                    dateformat();

                    clear();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        }
        public void dateformat()
        {
            transac_date.Format = DateTimePickerFormat.Custom;
            
            transac_date.CustomFormat = "ddd dd MMM yyyy";
            

        }
        public void dateformatreturn()
        {

            transac_date.Format = DateTimePickerFormat.Custom;



            transac_date.CustomFormat = "yy-MM-dd";

        }
        private void borrowform_Load(object sender, EventArgs e)
        {
            transac_date.Value = DateTime.Now;
            dateformat();
            studID.Hide();
            bookID.Hide();
            overdue_id.Hide();





        }

       
    }
} 
    



