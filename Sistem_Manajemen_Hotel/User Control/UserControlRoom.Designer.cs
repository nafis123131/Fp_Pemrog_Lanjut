namespace Sistem_Manajemen_Hotel.User_Control
{
    partial class UserControlRoom
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
            this.tabControlCariRuang = new System.Windows.Forms.TabControl();
            this.tabPageTambahRuang = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPageUpdateDeleteRuang = new System.Windows.Forms.TabPage();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.cmbListRuangan = new System.Windows.Forms.ComboBox();
            this.btnTambahRuangan = new System.Windows.Forms.Button();
            this.txtPhoneTambahRuangan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControlCariRuang.SuspendLayout();
            this.tabPageTambahRuang.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCariRuang
            // 
            this.tabControlCariRuang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlCariRuang.Controls.Add(this.tabPageTambahRuang);
            this.tabControlCariRuang.Controls.Add(this.tabPage2);
            this.tabControlCariRuang.Controls.Add(this.tabPageUpdateDeleteRuang);
            this.tabControlCariRuang.Location = new System.Drawing.Point(30, 29);
            this.tabControlCariRuang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlCariRuang.Name = "tabControlCariRuang";
            this.tabControlCariRuang.SelectedIndex = 0;
            this.tabControlCariRuang.Size = new System.Drawing.Size(1042, 406);
            this.tabControlCariRuang.TabIndex = 0;
            // 
            // tabPageTambahRuang
            // 
            this.tabPageTambahRuang.Controls.Add(this.rdbNo);
            this.tabPageTambahRuang.Controls.Add(this.rdbYes);
            this.tabPageTambahRuang.Controls.Add(this.cmbListRuangan);
            this.tabPageTambahRuang.Controls.Add(this.btnTambahRuangan);
            this.tabPageTambahRuang.Controls.Add(this.txtPhoneTambahRuangan);
            this.tabPageTambahRuang.Controls.Add(this.label5);
            this.tabPageTambahRuang.Controls.Add(this.label6);
            this.tabPageTambahRuang.Controls.Add(this.label7);
            this.tabPageTambahRuang.Controls.Add(this.label8);
            this.tabPageTambahRuang.Location = new System.Drawing.Point(4, 26);
            this.tabPageTambahRuang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageTambahRuang.Name = "tabPageTambahRuang";
            this.tabPageTambahRuang.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageTambahRuang.Size = new System.Drawing.Size(1034, 376);
            this.tabPageTambahRuang.TabIndex = 0;
            this.tabPageTambahRuang.Text = "Tambah Ruang";
            this.tabPageTambahRuang.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1034, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cari Ruang";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPageUpdateDeleteRuang
            // 
            this.tabPageUpdateDeleteRuang.Location = new System.Drawing.Point(4, 26);
            this.tabPageUpdateDeleteRuang.Name = "tabPageUpdateDeleteRuang";
            this.tabPageUpdateDeleteRuang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDeleteRuang.Size = new System.Drawing.Size(1034, 376);
            this.tabPageUpdateDeleteRuang.TabIndex = 2;
            this.tabPageUpdateDeleteRuang.Text = "Update dan Delete Ruang";
            this.tabPageUpdateDeleteRuang.UseVisualStyleBackColor = true;
            // 
            // rdbNo
            // 
            this.rdbNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbNo.AutoSize = true;
            this.rdbNo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNo.Location = new System.Drawing.Point(230, 169);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(48, 24);
            this.rdbNo.TabIndex = 4;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbYes
            // 
            this.rdbYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbYes.AutoSize = true;
            this.rdbYes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbYes.Location = new System.Drawing.Point(153, 169);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.Size = new System.Drawing.Size(50, 24);
            this.rdbYes.TabIndex = 3;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "Yes";
            this.rdbYes.UseVisualStyleBackColor = true;
            // 
            // cmbListRuangan
            // 
            this.cmbListRuangan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbListRuangan.BackColor = System.Drawing.Color.White;
            this.cmbListRuangan.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cmbListRuangan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListRuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbListRuangan.FormattingEnabled = true;
            this.cmbListRuangan.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.cmbListRuangan.Location = new System.Drawing.Point(153, 89);
            this.cmbListRuangan.Name = "cmbListRuangan";
            this.cmbListRuangan.Size = new System.Drawing.Size(304, 25);
            this.cmbListRuangan.TabIndex = 1;
            this.cmbListRuangan.UseWaitCursor = true;
            // 
            // btnTambahRuangan
            // 
            this.btnTambahRuangan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTambahRuangan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnTambahRuangan.FlatAppearance.BorderSize = 0;
            this.btnTambahRuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahRuangan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahRuangan.ForeColor = System.Drawing.Color.White;
            this.btnTambahRuangan.Location = new System.Drawing.Point(153, 219);
            this.btnTambahRuangan.Name = "btnTambahRuangan";
            this.btnTambahRuangan.Size = new System.Drawing.Size(126, 40);
            this.btnTambahRuangan.TabIndex = 5;
            this.btnTambahRuangan.Text = "Tambah";
            this.btnTambahRuangan.UseVisualStyleBackColor = false;
            // 
            // txtPhoneTambahRuangan
            // 
            this.txtPhoneTambahRuangan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhoneTambahRuangan.Location = new System.Drawing.Point(579, 89);
            this.txtPhoneTambahRuangan.Name = "txtPhoneTambahRuangan";
            this.txtPhoneTambahRuangan.Size = new System.Drawing.Size(305, 23);
            this.txtPhoneTambahRuangan.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(575, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone No : ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(148, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ketersediaan Ruangan : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(148, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tipe Ruangan : ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(18, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tambah Ruangan :";
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlCariRuang);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlCariRuang.ResumeLayout(false);
            this.tabPageTambahRuang.ResumeLayout(false);
            this.tabPageTambahRuang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCariRuang;
        private System.Windows.Forms.TabPage tabPageTambahRuang;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPageUpdateDeleteRuang;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbYes;
        private System.Windows.Forms.ComboBox cmbListRuangan;
        private System.Windows.Forms.Button btnTambahRuangan;
        private System.Windows.Forms.TextBox txtPhoneTambahRuangan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
