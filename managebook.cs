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
    public partial class managebook : Form
    {
        string mycon = "datasource=localhost;username=root;password=;database=library_db";
        public managebook()
        {
            InitializeComponent();
            showalldata();
        }

        public void clear()
        {

            txtauthor.Text = "";
            txtdescription.Text = "";
            txttitle.Text = "";
            lbl_id.Text = "";



        }


        public void showalldata()
        {

            try
            {
                string query = "SELECT * FROM `library_book`";

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






        private void managebook_Load(object sender, EventArgs e)
        {
            showalldata();
            lbl_id.Text = "";

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

            if (txttitle.Text.Equals("")
           || txtauthor.Text.Equals("")
           || txtdescription.Text.Equals("")
           )
            {

                MessageBox.Show("Please Input Data first", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                try
                {
                    string book = "INSERT INTO `library_book`(`book_id`, `title`, `author`, `description`, `published`) VALUES ('','" + this.txttitle.Text + "','" + this.txtauthor.Text + "','" + this.txtdescription.Text + "','" + this.dateTimePicker1.Text + "')";
                    MySqlConnection conn = new MySqlConnection(mycon);


                    MySqlCommand mycommand = new MySqlCommand(book, conn);

                    MySqlDataReader myreader;
                    conn.Open();
                    myreader = mycommand.ExecuteReader();

                    conn.Close();

                    MessageBox.Show("Data Inserted", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showalldata();
                    clear();


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {


            string query = "UPDATE `library_book` SET `title`='" + txttitle.Text + "',`author`='" + txtauthor.Text + "',`description`='" + txtdescription.Text + "',`published`='" + dateTimePicker1.Text + "' WHERE book_id='" + lbl_id.Text + "'";

            if (txttitle.Text.Equals("")
                 || txtauthor.Text.Equals("")
                 || txtdescription.Text.Equals("")
                 || lbl_id.Text.Equals("")
                 )
            {

                MessageBox.Show("Please Select Data first", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {

                    MySqlConnection mycon2 = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, mycon2);
                    MySqlDataReader myreader1;
                    mycon2.Open();
                    myreader1 = mycommand.ExecuteReader();



                    MessageBox.Show("Data is updated", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_insert.Enabled = true;
                    showalldata();
                    clear();



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Dtable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Dtable.Rows[e.RowIndex];

                lbl_id.Text = row.Cells["book_id"].Value.ToString();
                txttitle.Text = row.Cells["title"].Value.ToString();
                txtauthor.Text = row.Cells["author"].Value.ToString();
                txtdescription.Text = row.Cells["description"].Value.ToString();
                dateTimePicker1.Text = row.Cells["published"].Value.ToString();

            }
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            btn_insert.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text.Equals(""))
            {

                MessageBox.Show("Please Select Data", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                if (MessageBox.Show("Are you sure you want to Delete this data??", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {



                    try
                    {
                        string query = "DELETE FROM `library_book` WHERE book_id='" + lbl_id.Text + "'";
                        MySqlConnection mycon2 = new MySqlConnection(mycon);
                        MySqlCommand mycommand = new MySqlCommand(query, mycon2);
                        MySqlDataReader myreader1;
                        mycon2.Open();
                        myreader1 = mycommand.ExecuteReader();
                        MessageBox.Show("Data Deleted", "CEAT Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        btn_insert.Enabled = true;
                        showalldata();



                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                }
            }
        }

        
    }
}

        

     

