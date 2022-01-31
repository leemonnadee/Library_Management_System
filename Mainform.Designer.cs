
namespace Library_Management_System
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.student = new Bunifu.UI.WinForms.BunifuImageButton();
            this.admin = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuShadowPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuShadowPanel1.BorderRadius = 20;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.panel1);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(541, 57);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(102)))));
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(102)))));
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(640, 688);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.time);
            this.panel1.Location = new System.Drawing.Point(16, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 205);
            this.panel1.TabIndex = 0;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.date.Location = new System.Drawing.Point(57, 135);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(303, 35);
            this.date.TabIndex = 1;
            this.date.Text = "Time and date display";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.DodgerBlue;
            this.time.Location = new System.Drawing.Point(25, 61);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(338, 65);
            this.time.TabIndex = 0;
            this.time.Text = "Time  display";
            this.time.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = null;
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::Library_Management_System.Properties.Resources.cancel_96px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(37, 35);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(57, 55);
            this.bunifuImageButton1.InitialImage = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1173, -4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(57, 55);
            this.bunifuImageButton1.TabIndex = 15;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // student
            // 
            this.student.ActiveImage = null;
            this.student.AllowAnimations = true;
            this.student.AllowBuffering = false;
            this.student.AllowToggling = false;
            this.student.AllowZooming = true;
            this.student.AllowZoomingOnFocus = false;
            this.student.BackColor = System.Drawing.Color.Transparent;
            this.student.DialogResult = System.Windows.Forms.DialogResult.None;
            this.student.ErrorImage = null;
            this.student.FadeWhenInactive = false;
            this.student.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.student.Image = ((System.Drawing.Image)(resources.GetObject("student.Image")));
            this.student.ImageActive = null;
            this.student.ImageLocation = null;
            this.student.ImageMargin = 20;
            this.student.ImageSize = new System.Drawing.Size(214, 180);
            this.student.ImageZoomSize = new System.Drawing.Size(234, 200);
            this.student.InitialImage = null;
            this.student.Location = new System.Drawing.Point(278, 266);
            this.student.Name = "student";
            this.student.Rotation = 0;
            this.student.ShowActiveImage = true;
            this.student.ShowCursorChanges = true;
            this.student.ShowImageBorders = true;
            this.student.ShowSizeMarkers = false;
            this.student.Size = new System.Drawing.Size(234, 200);
            this.student.TabIndex = 6;
            this.student.ToolTipText = "";
            this.student.WaitOnLoad = false;
            this.student.Zoom = 20;
            this.student.ZoomSpeed = 10;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // admin
            // 
            this.admin.ActiveImage = null;
            this.admin.AllowAnimations = true;
            this.admin.AllowBuffering = false;
            this.admin.AllowToggling = false;
            this.admin.AllowZooming = true;
            this.admin.AllowZoomingOnFocus = false;
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.admin.ErrorImage = null;
            this.admin.FadeWhenInactive = false;
            this.admin.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.admin.Image = ((System.Drawing.Image)(resources.GetObject("admin.Image")));
            this.admin.ImageActive = null;
            this.admin.ImageLocation = null;
            this.admin.ImageMargin = 20;
            this.admin.ImageSize = new System.Drawing.Size(211, 180);
            this.admin.ImageZoomSize = new System.Drawing.Size(231, 200);
            this.admin.InitialImage = null;
            this.admin.Location = new System.Drawing.Point(30, 266);
            this.admin.Name = "admin";
            this.admin.Rotation = 0;
            this.admin.ShowActiveImage = true;
            this.admin.ShowCursorChanges = true;
            this.admin.ShowImageBorders = true;
            this.admin.ShowSizeMarkers = false;
            this.admin.Size = new System.Drawing.Size(231, 200);
            this.admin.TabIndex = 5;
            this.admin.ToolTipText = "";
            this.admin.WaitOnLoad = false;
            this.admin.Zoom = 20;
            this.admin.ZoomSpeed = 10;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 810);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.student);
            this.Controls.Add(this.admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuImageButton admin;
        private Bunifu.UI.WinForms.BunifuImageButton student;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label date;
    }
}

