namespace Sistem_Manajemen_Hotel
{
    partial class FormDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnReservasi = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUsernameDashboard = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.userControlClient1 = new Sistem_Manajemen_Hotel.User_Control.UserControlClient();
            this.userControlSetting1 = new Sistem_Manajemen_Hotel.User_Control.UserControlSetting();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnReservasi);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 720);
            this.panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(0, 254);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(13, 64);
            this.panelSlide.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::Sistem_Manajemen_Hotel.Properties.Resources.Mask_group;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(12, 534);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(288, 64);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "         Setting";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnReservasi
            // 
            this.btnReservasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReservasi.BackColor = System.Drawing.Color.Transparent;
            this.btnReservasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservasi.FlatAppearance.BorderSize = 0;
            this.btnReservasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservasi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservasi.ForeColor = System.Drawing.Color.White;
            this.btnReservasi.Image = global::Sistem_Manajemen_Hotel.Properties.Resources.Group_2;
            this.btnReservasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservasi.Location = new System.Drawing.Point(12, 464);
            this.btnReservasi.Name = "btnReservasi";
            this.btnReservasi.Size = new System.Drawing.Size(288, 64);
            this.btnReservasi.TabIndex = 4;
            this.btnReservasi.Text = "         Reservasi";
            this.btnReservasi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservasi.UseVisualStyleBackColor = false;
            this.btnReservasi.Click += new System.EventHandler(this.btnReservasi_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Image = global::Sistem_Manajemen_Hotel.Properties.Resources.Group_5;
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Location = new System.Drawing.Point(12, 394);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(288, 64);
            this.btnRoom.TabIndex = 3;
            this.btnRoom.Text = "         Ruang";
            this.btnRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoom.UseVisualStyleBackColor = false;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnClient
            // 
            this.btnClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClient.BackColor = System.Drawing.Color.Transparent;
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Image = global::Sistem_Manajemen_Hotel.Properties.Resources.Vector;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(12, 324);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(288, 64);
            this.btnClient.TabIndex = 2;
            this.btnClient.Text = "          Client";
            this.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Sistem_Manajemen_Hotel.Properties.Resources.Dashboard__2_;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(12, 254);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(288, 64);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "         Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 234);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEM MANAJEMEN \r\nHOTEL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Sistem_Manajemen_Hotel.Properties.Resources.Icon__1_;
            this.pictureBox1.Location = new System.Drawing.Point(78, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblUsernameDashboard);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(300, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1066, 234);
            this.panel3.TabIndex = 1;
            // 
            // lblUsernameDashboard
            // 
            this.lblUsernameDashboard.AutoSize = true;
            this.lblUsernameDashboard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameDashboard.ForeColor = System.Drawing.Color.White;
            this.lblUsernameDashboard.Location = new System.Drawing.Point(147, 165);
            this.lblUsernameDashboard.Name = "lblUsernameDashboard";
            this.lblUsernameDashboard.Size = new System.Drawing.Size(24, 25);
            this.lblUsernameDashboard.TabIndex = 0;
            this.lblUsernameDashboard.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblDateTime);
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1066, 123);
            this.panel4.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.lblDateTime.Location = new System.Drawing.Point(6, 91);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(24, 25);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "?";
            this.lblDateTime.Click += new System.EventHandler(this.lblDateTime_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(846, 52);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 21);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LogOut";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Sistem_Manajemen_Hotel.Properties.Resources.profile__1_;
            this.pictureBox2.Location = new System.Drawing.Point(759, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.userControlClient1);
            this.panel5.Controls.Add(this.userControlSetting1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(300, 234);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1066, 486);
            this.panel5.TabIndex = 0;
            // 
            // userControlClient1
            // 
            this.userControlClient1.BackColor = System.Drawing.Color.White;
            this.userControlClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlClient1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlClient1.Location = new System.Drawing.Point(0, 0);
            this.userControlClient1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlClient1.Name = "userControlClient1";
            this.userControlClient1.Size = new System.Drawing.Size(1066, 486);
            this.userControlClient1.TabIndex = 0;
            this.userControlClient1.Visible = false;
            // 
            // userControlSetting1
            // 
            this.userControlSetting1.BackColor = System.Drawing.Color.White;
            this.userControlSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSetting1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlSetting1.Location = new System.Drawing.Point(0, 0);
            this.userControlSetting1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetting1.Name = "userControlSetting1";
            this.userControlSetting1.Size = new System.Drawing.Size(1066, 486);
            this.userControlSetting1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem_Manajemen_Hotel | Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUsernameDashboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnReservasi;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timer1;
        private User_Control.UserControlSetting userControlSetting1;
        private User_Control.UserControlClient userControlClient1;
    }
}