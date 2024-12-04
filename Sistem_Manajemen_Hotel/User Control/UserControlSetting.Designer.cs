namespace Sistem_Manajemen_Hotel.User_Control
{
    partial class UserControlSetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlSetting = new System.Windows.Forms.TabControl();
            this.tabPageTambahUser = new System.Windows.Forms.TabPage();
            this.btnTambahUser = new System.Windows.Forms.Button();
            this.txtPasswordTambahUser = new System.Windows.Forms.TextBox();
            this.txtUsernameTambahUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageCariUser = new System.Windows.Forms.TabPage();
            this.txtUsernameCariUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewCariUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageUpdateDelete = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteUpdateUser = new System.Windows.Forms.Button();
            this.btnUpdateDeleteUser = new System.Windows.Forms.Button();
            this.txtPasswordUpdateDelete = new System.Windows.Forms.TextBox();
            this.txtUsernameUpdateDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControlSetting.SuspendLayout();
            this.tabPageTambahUser.SuspendLayout();
            this.tabPageCariUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariUser)).BeginInit();
            this.tabPageUpdateDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSetting
            // 
            this.tabControlSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlSetting.Controls.Add(this.tabPageTambahUser);
            this.tabControlSetting.Controls.Add(this.tabPageCariUser);
            this.tabControlSetting.Controls.Add(this.tabPageUpdateDelete);
            this.tabControlSetting.Location = new System.Drawing.Point(41, 39);
            this.tabControlSetting.Name = "tabControlSetting";
            this.tabControlSetting.SelectedIndex = 0;
            this.tabControlSetting.Size = new System.Drawing.Size(1020, 389);
            this.tabControlSetting.TabIndex = 0;
            // 
            // tabPageTambahUser
            // 
            this.tabPageTambahUser.Controls.Add(this.btnTambahUser);
            this.tabPageTambahUser.Controls.Add(this.txtPasswordTambahUser);
            this.tabPageTambahUser.Controls.Add(this.txtUsernameTambahUser);
            this.tabPageTambahUser.Controls.Add(this.label3);
            this.tabPageTambahUser.Controls.Add(this.label2);
            this.tabPageTambahUser.Controls.Add(this.label1);
            this.tabPageTambahUser.Location = new System.Drawing.Point(4, 26);
            this.tabPageTambahUser.Name = "tabPageTambahUser";
            this.tabPageTambahUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTambahUser.Size = new System.Drawing.Size(1012, 359);
            this.tabPageTambahUser.TabIndex = 0;
            this.tabPageTambahUser.Text = "Tambah User";
            this.tabPageTambahUser.UseVisualStyleBackColor = true;
            this.tabPageTambahUser.Enter += new System.EventHandler(this.tabPageTambahUser_Enter);
            this.tabPageTambahUser.Leave += new System.EventHandler(this.tabPageTambahUser_Leave);
            // 
            // btnTambahUser
            // 
            this.btnTambahUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTambahUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnTambahUser.FlatAppearance.BorderSize = 0;
            this.btnTambahUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahUser.ForeColor = System.Drawing.Color.White;
            this.btnTambahUser.Location = new System.Drawing.Point(140, 168);
            this.btnTambahUser.Name = "btnTambahUser";
            this.btnTambahUser.Size = new System.Drawing.Size(126, 40);
            this.btnTambahUser.TabIndex = 3;
            this.btnTambahUser.Text = "Tambah";
            this.btnTambahUser.UseVisualStyleBackColor = false;
            this.btnTambahUser.Click += new System.EventHandler(this.btnTambahUser_Click);
            // 
            // txtPasswordTambahUser
            // 
            this.txtPasswordTambahUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordTambahUser.Location = new System.Drawing.Point(566, 123);
            this.txtPasswordTambahUser.Name = "txtPasswordTambahUser";
            this.txtPasswordTambahUser.Size = new System.Drawing.Size(305, 23);
            this.txtPasswordTambahUser.TabIndex = 2;
            // 
            // txtUsernameTambahUser
            // 
            this.txtUsernameTambahUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsernameTambahUser.Location = new System.Drawing.Point(139, 123);
            this.txtUsernameTambahUser.Name = "txtUsernameTambahUser";
            this.txtUsernameTambahUser.Size = new System.Drawing.Size(305, 23);
            this.txtUsernameTambahUser.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(562, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(136, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username : ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah User :";
            // 
            // tabPageCariUser
            // 
            this.tabPageCariUser.Controls.Add(this.txtUsernameCariUser);
            this.tabPageCariUser.Controls.Add(this.label5);
            this.tabPageCariUser.Controls.Add(this.label4);
            this.tabPageCariUser.Controls.Add(this.dataGridViewCariUser);
            this.tabPageCariUser.Location = new System.Drawing.Point(4, 26);
            this.tabPageCariUser.Name = "tabPageCariUser";
            this.tabPageCariUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCariUser.Size = new System.Drawing.Size(1012, 359);
            this.tabPageCariUser.TabIndex = 1;
            this.tabPageCariUser.Text = "Cari User";
            this.tabPageCariUser.UseVisualStyleBackColor = true;
            this.tabPageCariUser.Enter += new System.EventHandler(this.tabPageCariUser_Enter);
            this.tabPageCariUser.Leave += new System.EventHandler(this.tabPageCariUser_Leave);
            // 
            // txtUsernameCariUser
            // 
            this.txtUsernameCariUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsernameCariUser.Location = new System.Drawing.Point(161, 90);
            this.txtUsernameCariUser.Name = "txtUsernameCariUser";
            this.txtUsernameCariUser.Size = new System.Drawing.Size(266, 23);
            this.txtUsernameCariUser.TabIndex = 1;
            this.txtUsernameCariUser.TextChanged += new System.EventHandler(this.txtUsernameCariUser_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(20, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cari User : ";
            // 
            // dataGridViewCariUser
            // 
            this.dataGridViewCariUser.AllowUserToAddRows = false;
            this.dataGridViewCariUser.AllowUserToDeleteRows = false;
            this.dataGridViewCariUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewCariUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCariUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCariUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewCariUser.Location = new System.Drawing.Point(23, 136);
            this.dataGridViewCariUser.Name = "dataGridViewCariUser";
            this.dataGridViewCariUser.ReadOnly = true;
            this.dataGridViewCariUser.Size = new System.Drawing.Size(967, 201);
            this.dataGridViewCariUser.TabIndex = 0;
            this.dataGridViewCariUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCariUser_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "User_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 308;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "User_Name";
            this.Column2.HeaderText = "Username";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "User_Password";
            this.Column3.HeaderText = "Password";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tabPageUpdateDelete
            // 
            this.tabPageUpdateDelete.Controls.Add(this.label8);
            this.tabPageUpdateDelete.Controls.Add(this.btnDeleteUpdateUser);
            this.tabPageUpdateDelete.Controls.Add(this.btnUpdateDeleteUser);
            this.tabPageUpdateDelete.Controls.Add(this.txtPasswordUpdateDelete);
            this.tabPageUpdateDelete.Controls.Add(this.txtUsernameUpdateDelete);
            this.tabPageUpdateDelete.Controls.Add(this.label6);
            this.tabPageUpdateDelete.Controls.Add(this.label7);
            this.tabPageUpdateDelete.Location = new System.Drawing.Point(4, 26);
            this.tabPageUpdateDelete.Name = "tabPageUpdateDelete";
            this.tabPageUpdateDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDelete.Size = new System.Drawing.Size(1012, 359);
            this.tabPageUpdateDelete.TabIndex = 2;
            this.tabPageUpdateDelete.Text = "Update dan Delete User";
            this.tabPageUpdateDelete.UseVisualStyleBackColor = true;
            this.tabPageUpdateDelete.Leave += new System.EventHandler(this.tabPageUpdateDelete_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(20, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Update dan Delete User :";
            // 
            // btnDeleteUpdateUser
            // 
            this.btnDeleteUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteUpdateUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUpdateUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUpdateUser.Location = new System.Drawing.Point(321, 183);
            this.btnDeleteUpdateUser.Name = "btnDeleteUpdateUser";
            this.btnDeleteUpdateUser.Size = new System.Drawing.Size(126, 40);
            this.btnDeleteUpdateUser.TabIndex = 9;
            this.btnDeleteUpdateUser.Text = "Delete";
            this.btnDeleteUpdateUser.UseVisualStyleBackColor = false;
            this.btnDeleteUpdateUser.Click += new System.EventHandler(this.btnDeleteUpdateUser_Click);
            // 
            // btnUpdateDeleteUser
            // 
            this.btnUpdateDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnUpdateDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDeleteUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDeleteUser.Location = new System.Drawing.Point(143, 183);
            this.btnUpdateDeleteUser.Name = "btnUpdateDeleteUser";
            this.btnUpdateDeleteUser.Size = new System.Drawing.Size(126, 40);
            this.btnUpdateDeleteUser.TabIndex = 9;
            this.btnUpdateDeleteUser.Text = "Update";
            this.btnUpdateDeleteUser.UseVisualStyleBackColor = false;
            this.btnUpdateDeleteUser.Click += new System.EventHandler(this.btnUpdateDeleteUser_Click);
            // 
            // txtPasswordUpdateDelete
            // 
            this.txtPasswordUpdateDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordUpdateDelete.Location = new System.Drawing.Point(569, 138);
            this.txtPasswordUpdateDelete.Name = "txtPasswordUpdateDelete";
            this.txtPasswordUpdateDelete.Size = new System.Drawing.Size(305, 23);
            this.txtPasswordUpdateDelete.TabIndex = 9;
            // 
            // txtUsernameUpdateDelete
            // 
            this.txtUsernameUpdateDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsernameUpdateDelete.Location = new System.Drawing.Point(142, 138);
            this.txtUsernameUpdateDelete.Name = "txtUsernameUpdateDelete";
            this.txtUsernameUpdateDelete.Size = new System.Drawing.Size(305, 23);
            this.txtUsernameUpdateDelete.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(565, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(139, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Username : ";
            // 
            // UserControlSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlSetting);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlSetting";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlSetting.ResumeLayout(false);
            this.tabPageTambahUser.ResumeLayout(false);
            this.tabPageTambahUser.PerformLayout();
            this.tabPageCariUser.ResumeLayout(false);
            this.tabPageCariUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariUser)).EndInit();
            this.tabPageUpdateDelete.ResumeLayout(false);
            this.tabPageUpdateDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSetting;
        private System.Windows.Forms.TabPage tabPageTambahUser;
        private System.Windows.Forms.TabPage tabPageCariUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsernameTambahUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTambahUser;
        private System.Windows.Forms.TextBox txtPasswordTambahUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewCariUser;
        private System.Windows.Forms.TextBox txtUsernameCariUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabPage tabPageUpdateDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteUpdateUser;
        private System.Windows.Forms.Button btnUpdateDeleteUser;
        private System.Windows.Forms.TextBox txtPasswordUpdateDelete;
        private System.Windows.Forms.TextBox txtUsernameUpdateDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
