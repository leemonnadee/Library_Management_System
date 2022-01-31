
namespace Library_Management_System
{
    partial class Studentdashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studentdashboard));
            this.dashpanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.manageacc_btn = new System.Windows.Forms.Button();
            this.booksearch_btn = new System.Windows.Forms.Button();
            this.bookreq_btn = new System.Windows.Forms.Button();
            this.studmainpanel = new System.Windows.Forms.Panel();
            this.dashpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashpanel
            // 
            this.dashpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(102)))));
            this.dashpanel.Controls.Add(this.button2);
            this.dashpanel.Controls.Add(this.ID);
            this.dashpanel.Controls.Add(this.button1);
            this.dashpanel.Controls.Add(this.manageacc_btn);
            this.dashpanel.Controls.Add(this.booksearch_btn);
            this.dashpanel.Controls.Add(this.bookreq_btn);
            this.dashpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashpanel.Location = new System.Drawing.Point(0, 0);
            this.dashpanel.Name = "dashpanel";
            this.dashpanel.Size = new System.Drawing.Size(380, 789);
            this.dashpanel.TabIndex = 2;
            this.dashpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dashpanel_Paint);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Image = global::Library_Management_System.Properties.Resources.rules_book_50px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 525);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(380, 63);
            this.button2.TabIndex = 14;
            this.button2.Text = "Rules";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ID.Location = new System.Drawing.Point(22, 19);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 29);
            this.ID.TabIndex = 13;
            this.ID.Text = "Course";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(0, 679);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 65);
            this.button1.TabIndex = 12;
            this.button1.Text = "Logout";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // manageacc_btn
            // 
            this.manageacc_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.manageacc_btn.FlatAppearance.BorderSize = 0;
            this.manageacc_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.manageacc_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.manageacc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageacc_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageacc_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.manageacc_btn.Image = ((System.Drawing.Image)(resources.GetObject("manageacc_btn.Image")));
            this.manageacc_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageacc_btn.Location = new System.Drawing.Point(-1, 414);
            this.manageacc_btn.Margin = new System.Windows.Forms.Padding(0);
            this.manageacc_btn.Name = "manageacc_btn";
            this.manageacc_btn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.manageacc_btn.Size = new System.Drawing.Size(380, 63);
            this.manageacc_btn.TabIndex = 9;
            this.manageacc_btn.Text = "Manage Account";
            this.manageacc_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageacc_btn.UseCompatibleTextRendering = true;
            this.manageacc_btn.UseVisualStyleBackColor = true;
            this.manageacc_btn.Click += new System.EventHandler(this.manageacc_btn_Click);
            // 
            // booksearch_btn
            // 
            this.booksearch_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.booksearch_btn.FlatAppearance.BorderSize = 0;
            this.booksearch_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.booksearch_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.booksearch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksearch_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksearch_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.booksearch_btn.Image = ((System.Drawing.Image)(resources.GetObject("booksearch_btn.Image")));
            this.booksearch_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booksearch_btn.Location = new System.Drawing.Point(0, 213);
            this.booksearch_btn.Margin = new System.Windows.Forms.Padding(0);
            this.booksearch_btn.Name = "booksearch_btn";
            this.booksearch_btn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.booksearch_btn.Size = new System.Drawing.Size(380, 63);
            this.booksearch_btn.TabIndex = 8;
            this.booksearch_btn.Text = "Book search";
            this.booksearch_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.booksearch_btn.UseCompatibleTextRendering = true;
            this.booksearch_btn.UseVisualStyleBackColor = true;
            this.booksearch_btn.Click += new System.EventHandler(this.booksearch_btn_Click);
            // 
            // bookreq_btn
            // 
            this.bookreq_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookreq_btn.FlatAppearance.BorderSize = 0;
            this.bookreq_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.bookreq_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.bookreq_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookreq_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookreq_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bookreq_btn.Image = ((System.Drawing.Image)(resources.GetObject("bookreq_btn.Image")));
            this.bookreq_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookreq_btn.Location = new System.Drawing.Point(-1, 306);
            this.bookreq_btn.Margin = new System.Windows.Forms.Padding(0);
            this.bookreq_btn.Name = "bookreq_btn";
            this.bookreq_btn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.bookreq_btn.Size = new System.Drawing.Size(380, 63);
            this.bookreq_btn.TabIndex = 7;
            this.bookreq_btn.Text = "Add book";
            this.bookreq_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookreq_btn.UseCompatibleTextRendering = true;
            this.bookreq_btn.UseVisualStyleBackColor = true;
            this.bookreq_btn.Click += new System.EventHandler(this.booksearch_btn_Click);
            this.bookreq_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bookreq_btn_MouseClick);
            // 
            // studmainpanel
            // 
            this.studmainpanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.studmainpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.studmainpanel.Location = new System.Drawing.Point(374, 0);
            this.studmainpanel.Name = "studmainpanel";
            this.studmainpanel.Size = new System.Drawing.Size(1115, 789);
            this.studmainpanel.TabIndex = 3;
            // 
            // Studentdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1487, 789);
            this.ControlBox = false;
            this.Controls.Add(this.studmainpanel);
            this.Controls.Add(this.dashpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Studentdashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studentdashboard";
            this.Load += new System.EventHandler(this.Studentdashboard_Load);
            this.dashpanel.ResumeLayout(false);
            this.dashpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dashpanel;
        private System.Windows.Forms.Button manageacc_btn;
        private System.Windows.Forms.Button booksearch_btn;
        private System.Windows.Forms.Button bookreq_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Panel studmainpanel;
        private System.Windows.Forms.Button button2;
    }
}