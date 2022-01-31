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
    public partial class Studentdashboard : Form
    {
        public Studentdashboard()
        {
            InitializeComponent();
        }

        public void studform(object Form)
        {
            if (this.studmainpanel.Controls.Count > 0)
                this.studmainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.studmainpanel.Controls.Add(f);
            this.studmainpanel.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform main = new Mainform();
            main.Show();
        }

        private void Studentdashboard_Load(object sender, EventArgs e)
        {
            /*
           studname.Text = (studentloginform.UserDisplay.displayname).ToUpper();
               lblcourse.Text = studentloginform.UserDisplay.displayCourse;

            ID.Text = studentloginform.UserDisplay.displaystud_id;
            studname.Visible = false;
            lblcourse.Visible = false;
        
          
            */
            ID.Hide();
            ID.Text = studentloginform.UserDisplay.displayuserID;
            studform(new rules());

        }





        private void booksearch_btn_Click(object sender, EventArgs e)
        {
            studform(new booksearch());
        }

        private void bookreq_btn_MouseClick(object sender, MouseEventArgs e)
        {
            studform(new stud_borrow());
        }

        private void manageacc_btn_Click(object sender, EventArgs e)
        {
            studform(new manageaccount());
        }

        private void dashpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            studform(new rules());
        }
    }
}
