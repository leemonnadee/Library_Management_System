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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }



        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminloginform adminlogform = new adminloginform();
            adminlogform.Show();

        }




        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       private void label1_Click(object sender, EventArgs e)
        {

        }

        private void student_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentloginform studlog = new studentloginform();
            studlog.Show();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("hh:m tt");
            date.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            time.Text = DateTime.Now.ToString("hh:m:s tt");
            timer1.Start();
        }

       
    }
}
