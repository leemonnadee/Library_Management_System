
namespace Library_Management_System
{
    partial class adminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashboard));
            this.mainpanel = new System.Windows.Forms.Panel();
            this.dashpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bookinformation_btn = new System.Windows.Forms.Button();
            this.transaction_btn = new System.Windows.Forms.Button();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.mainpanel.SuspendLayout();
            this.dashpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.White;
            this.mainpanel.Controls.Add(this.bunifuPictureBox2);
            this.mainpanel.Location = new System.Drawing.Point(379, 0);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1350, 789);
            this.mainpanel.TabIndex = 2;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // dashpanel
            // 
            this.dashpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(102)))));
            this.dashpanel.Controls.Add(this.button2);
            this.dashpanel.Controls.Add(this.button1);
            this.dashpanel.Controls.Add(this.bunifuPictureBox1);
            this.dashpanel.Controls.Add(this.bookinformation_btn);
            this.dashpanel.Controls.Add(this.label4);
            this.dashpanel.Controls.Add(this.transaction_btn);
            this.dashpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashpanel.Location = new System.Drawing.Point(0, 0);
            this.dashpanel.Name = "dashpanel";
            this.dashpanel.Size = new System.Drawing.Size(380, 789);
            this.dashpanel.TabIndex = 1;
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
            this.button1.Location = new System.Drawing.Point(0, 629);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 63);
            this.button1.TabIndex = 13;
            this.button1.Text = "Logout";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(87, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "DASHBOARD";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 273);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(379, 93);
            this.button2.TabIndex = 14;
            this.button2.Text = "Borrower";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 24;
            this.bunifuPictureBox1.Image = global::Library_Management_System.Properties.Resources.dashboard_layout_96px;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(32, 46);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(49, 49);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 11;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // bookinformation_btn
            // 
            this.bookinformation_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookinformation_btn.FlatAppearance.BorderSize = 0;
            this.bookinformation_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.bookinformation_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.bookinformation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookinformation_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookinformation_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bookinformation_btn.Image = global::Library_Management_System.Properties.Resources.book_50px;
            this.bookinformation_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookinformation_btn.Location = new System.Drawing.Point(0, 377);
            this.bookinformation_btn.Margin = new System.Windows.Forms.Padding(0);
            this.bookinformation_btn.Name = "bookinformation_btn";
            this.bookinformation_btn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.bookinformation_btn.Size = new System.Drawing.Size(380, 73);
            this.bookinformation_btn.TabIndex = 9;
            this.bookinformation_btn.Text = "Books";
            this.bookinformation_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookinformation_btn.UseCompatibleTextRendering = true;
            this.bookinformation_btn.UseVisualStyleBackColor = true;
            this.bookinformation_btn.Click += new System.EventHandler(this.bookinformation_btn_Click);
            // 
            // transaction_btn
            // 
            this.transaction_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transaction_btn.FlatAppearance.BorderSize = 0;
            this.transaction_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.transaction_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.transaction_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaction_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.transaction_btn.Image = global::Library_Management_System.Properties.Resources.transaction_list_50px;
            this.transaction_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transaction_btn.Location = new System.Drawing.Point(0, 462);
            this.transaction_btn.Margin = new System.Windows.Forms.Padding(0);
            this.transaction_btn.Name = "transaction_btn";
            this.transaction_btn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.transaction_btn.Size = new System.Drawing.Size(379, 93);
            this.transaction_btn.TabIndex = 7;
            this.transaction_btn.Text = "Transactions";
            this.transaction_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.transaction_btn.UseCompatibleTextRendering = true;
            this.transaction_btn.UseVisualStyleBackColor = true;
            this.transaction_btn.Click += new System.EventHandler(this.transaction_btn_Click);
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BorderRadius = 4;
            this.bunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox2.Image")));
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(323, 222);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(8, 8);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 0;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1726, 789);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.dashpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminDashboard";
            this.Load += new System.EventHandler(this.adminDashboard_Load);
            this.mainpanel.ResumeLayout(false);
            this.dashpanel.ResumeLayout(false);
            this.dashpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel dashpanel;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Button bookinformation_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button transaction_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
    }
}