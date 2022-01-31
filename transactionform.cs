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
    public partial class transactionform : Form
    {
        string mycon = "datasource=localhost;username=root;password=;database=library_db";
        public transactionform()
        {
            InitializeComponent();
            showalldata();
            totalpayments();
        }


        public void showalldata()
        {

            try
            {
                string query = "SELECT library_payment.transac_id, library_book.title, library_students.lastname, library_students.firstname, library_payment.payment, library_payment.transaction_Date FROM `library_payment` INNER JOIN library_students ON library_students.stud_id=library_payment.stud_id INNER JOIN library_book ON library_book.book_id=library_payment.book_id;";
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
      
        public void totalpayments() {

            string save = "Select Sum(payment) AS 'totalpayment' from library_payment";
            MySqlConnection conn = new MySqlConnection(mycon);


            MySqlCommand mycommand = new MySqlCommand(save, conn);

            MySqlDataReader myreader;
            conn.Open();
            myreader = mycommand.ExecuteReader();
            if (myreader.Read())
            {
                txttotal.Text  = myreader.GetString("totalpayment");
               


            }


            conn.Close();
        }



        public void srch()
        {

            try
            {
                string query1= "SELECT library_payment.transac_id, library_book.title, library_students.lastname, library_students.firstname, library_payment.payment, library_payment.transaction_Date " +
                    "FROM `library_payment` INNER JOIN library_students ON library_students.stud_id=library_payment.stud_id " +
                    "INNER JOIN library_book ON library_book.book_id=library_payment.book_id WHERE CONCAT(lastname,' ',firstname) LIKE  '%" + txtSrchname.Text + "%'";


         
                MySqlConnection conn = new MySqlConnection(mycon);

                MySqlDataAdapter adapter = new MySqlDataAdapter(query1, conn);
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
    }

    }
