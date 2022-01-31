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
    public partial class adminDashboard :Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void transaction_btn_Click(object sender, EventArgs e)
        {
            loadform(new transactionform());
        }

        private void dailyrecord_btn_Click_1(object sender, EventArgs e)
        {
            loadform(new daiilyrecordform());
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform mf = new Mainform();
            mf.Show();
        }

        private void bookinformation_btn_Click(object sender, EventArgs e)
        {
            loadform(new managebook());
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.mainpanel.Show();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            dashpanel.Hide();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform mf = new Mainform();
            mf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           loadform(new borrowform());
        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {
            loadform(new borrowform());
        }
    }
}
